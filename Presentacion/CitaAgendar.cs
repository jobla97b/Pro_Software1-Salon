using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Dominio.Cache;

namespace Presentacion
{
    public partial class CitaAgendar : Form
    {
        public CitaAgendar()
        {
            InitializeComponent();
            Privilegios();
            labelfecha();
        }
        public DataView dv= new DataView();
        #region Declaracion de variables
        public static bool IsAgregado = false;
        string consultafecha;
        string fechaparametro;
        string dia, mes;
        //Inicio por defecto
        //int d1, m1, A1;
        int d1 = DateTime.Today.Day;
        int m1 = DateTime.Today.Month;
        int A1 = DateTime.Today.Year;
        //Parametro Index para el datagrid
        int indexRow = -1;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Agendar ag = new Agendar();
            ag.FormClosed += AgendarClose;
            ag.dateTimePickFecha.Value = Convert.ToDateTime(fechaparametro);
            Agendar.IsNuevo = true;
            indexRow = -1;
            Data_Citas.ClearSelection();
            ag.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Enabled = true;
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnCambio.Enabled = false;
            btnConfir.Enabled = false;
            txtFiltro.Enabled = false;
            Data_Citas.Enabled = false;
            indexRow = -1;
            Data_Citas.ClearSelection();
        }

        #region Metodo de carga para la label Fecha
        private void labelfecha()
        {
            if (Citas.Corroborar != "Agendar")
            {
                valida_datos_pasados(d1, m1);
                fechaparametro= "" + dia + "/" + mes + "/" + A1.ToString();
                FechaActual(d1, m1, A1);
                Cargardatos('A');
                dateTimePickerBuscar.Value = Convert.ToDateTime(fechaparametro);
            }
            else
            {
                lblFecha.Text = Citas.nombredia;
                valida_datos_pasados(Citas.dia, Citas.mes);
                fechaparametro = "" + dia + "/" + mes + "/" + Citas.Año.ToString();
                Cargardatos('A');
                dateTimePickerBuscar.Value = Convert.ToDateTime(fechaparametro);
            }
            Citas.Corroborar = "null";
        }
        #endregion

        #region Sin nombre
        private void valida_datos_pasados(int di, int meses)
        {
            if(di<10){
                dia = "0"+di.ToString();
            }
            else
            {
                dia = di.ToString();
            }
            if (meses < 10)
            {
                mes = "0"+meses.ToString();
            }
            else
            {
                mes = meses.ToString();
            }
        }
        #endregion

        #region Metodo para cargar el data griview
        private void Cargardatos(char Estad)
        {
            if (CacheLoginUser.Cargo == Estructura_Cargos.Estilista)
            {
                dv.Table= D_Cita.D_ListEstilista(fechaparametro, Estad, Convert.ToInt16(CacheLoginUser.IdEmpleado));
                this.Data_Citas.DataSource = dv;
                AjustarColumnas();
                OcultarColumnas();
            }
            else
            {
                dv.Table = D_Cita.D_Listado(fechaparametro, Estad);
                this.Data_Citas.DataSource = dv;
                AjustarColumnas();
                OcultarColumnas();
            }
            Filas_DataCitas();
            Verificar_Fecha();
            BloqueoBtnporFecha();
        }

        private void Filas_DataCitas()
        {
            if (Data_Citas.RowCount <= 0)
            {
                lblMensajeData.Visible = true;
                lblMensajeData.Text = "No existen citas registradas para esta fecha.";
                Data_Citas.Enabled = false; 
            }
            else
            {
                ConteoCitas();
                lblMensajeData.Visible = false;
                Data_Citas.Enabled = true;
            }
        }
        #endregion

        #region Metodo para cargar fecha actual
        private void FechaActual(int a, int m, int Añ)
        {
            DateTime Dia = Convert.ToDateTime("" + a + "/" + m + "/" + Añ + "");
            string Nombredia = Application.CurrentCulture.Calendar.GetDayOfWeek(Dia).ToString();
            string Nombre_mes = Application.CurrentCulture.DateTimeFormat.GetMonthName(m).ToString();
            lblFecha.Text = Nombredia + ", " + a + " de " + Nombre_mes + " del " + Añ;
        }
        #endregion

        #region Privilegios del Formulario 
        private void Privilegios()
        {
            if (CacheLoginUser.Cargo == Estructura_Cargos.Estilista)
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnCambio.Enabled = false;
            }
        }
        #endregion

        #region Mostrar Conteo de Citas
        private void ConteoCitas()
        {
            DataTable dt = D_Cita.D_ConteoCita(fechaparametro);
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 0) {
                lblTotal.Text = "Citas Totales: "+dt.Rows[0][0].ToString();
                lblFacturadas.Text = "Citas Facturadas: " + dt.Rows[0][1].ToString();
                lblCanceladas.Text = "Citas Canceladas: " + dt.Rows[0][2].ToString();
            }
            else
            {
                lblTotal.Text = "Citas Totales: --";
                lblFacturadas.Text = "Citas Totales: --";
                lblCanceladas.Text = "Citas Canceladas: --";
            }
            if(Convert.ToInt32(dt.Rows[0][3].ToString()) != 0)
            {
                lblConfirmadas.Enabled = true;
                lblConfirmadas.Text = "Citas Confirmadas: "+dt.Rows[0][3].ToString();
            }
            else
            {
                lblConfirmadas.Enabled = false;
                lblConfirmadas.Text = "Citas Confirmadas: --";
            }

        }
        #endregion

        private void Verificar_Fecha()
        {
            string Actual = DateTime.Now.ToShortDateString();
            int value = DateTime.Compare(Convert.ToDateTime(fechaparametro),Convert.ToDateTime(Actual));
            if (value > 0)
            {
                consultafecha = "Futura";
            }
            else if (value < 0)
            {
                consultafecha = "Pasada";
            }
            else
            {
                consultafecha = "Actual";
            }
        }

        private void BloqueoBtnporFecha()
        {
            if (consultafecha=="Pasada" && CacheLoginUser.Cargo != Estructura_Cargos.Estilista)
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
            }
            else if(consultafecha!="Pasada" && CacheLoginUser.Cargo != Estructura_Cargos.Estilista)
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        #region Propiedades del DataGrid
        private void AjustarColumnas()
        {
            this.Data_Citas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Citas.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Data_Citas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Data_Citas.ClearSelection();
            foreach (DataGridViewColumn Col in Data_Citas.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Data_Citas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            if (e.RowIndex < 0) { return; }
            if (CacheLoginUser.Cargo==Estructura_Cargos.Estilista)
            {
                DataGridViewRow fila = Data_Citas.CurrentRow;
                Agendar.Cita = Convert.ToInt16(fila.Cells[0].Value);
                Agendar ag = new Agendar();
                ag.dateTimePickFecha.Value = Convert.ToDateTime(fila.Cells[1].Value);
                ag.dateTimePickFecha.Format = DateTimePickerFormat.Short;
                ag.ShowDialog();
            }
            else
            {
                if (Data_Citas.CurrentRow.Index > -1) { }
                indexRow = Data_Citas.CurrentRow.Index;//para validar los botones Modificar
                if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "C")
                {
                        if (consultafecha != "Pasada"){
                            btnCambio.Visible = false;
                            btnConfir.Enabled = true;
                            btnConfir.Visible = true;                   
                    }
                }
                else if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "P") {
                        if (consultafecha != "Pasada")
                        {
                            btnConfir.Visible = false;
                            btnCambio.Enabled = true;
                            btnCambio.Visible = true;
                        }
                    //}
                }
            }
        }

        private void btnFech_Click(object sender, EventArgs e)
        {
            fechaparametro = dateTimePickerBuscar.Value.Date.ToShortDateString().ToString();
            Cargardatos('A');
            MessageBox.Show(dateTimePickerBuscar.Value.Date.ToShortDateString());
            panelBusqueda.Enabled = false;
            if (consultafecha != "Pasada")
            {
                if (CacheLoginUser.Cargo != Estructura_Cargos.Estilista) {
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            btnBuscar.Enabled = true;
            txtFiltro.Enabled = true;
            Data_Citas.Enabled = true;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            string resp = "";
            if (MessageBox.Show("Esta Seguro que desea Cancelar la Cita", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                D_Cita dc = new D_Cita();
                Int16 Id = Convert.ToInt16(Data_Citas.CurrentRow.Cells[0].Value.ToString()); 
                resp= dc.D_ActualizaCita(Id, 'C');
                if (resp.Equals("Ok"))
                {
                    btnCambio.Visible = false;
                    btnConfir.Enabled=false;
                    btnConfir.Visible = true;
                    Cargardatos('A');
                    Data_Citas.ClearSelection();
                }
                else
                {
                    MessageBox.Show(resp);
                }
            }
            indexRow = -1;
            Data_Citas.ClearSelection();
        }

        private void btnConfir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea Activar la Cita", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string resp = "";
                    D_Cita dc = new D_Cita();
                    Int16 Id = Convert.ToInt16(Data_Citas.CurrentRow.Cells[0].Value.ToString());
                    resp = dc.D_ActualizaCita(Id, 'P');
                    if (resp.Equals("Ok"))
                    {             
                        btnConfir.Visible = false;
                        btnCambio.Enabled = false;
                        btnCambio.Visible = true;
                        Cargardatos('A');
                        Data_Citas.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show(resp);
                    }   
            }
            indexRow = -1;
            Data_Citas.ClearSelection();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (indexRow != -1)
            {
                if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "F") {
                    MessageBox.Show("No puede mofificar una cita Facturada.","Mensaje Informativo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "C") {
                    MessageBox.Show("Es requerido activar la Cita, para realizar cambios.","Mensaje Informativo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else {
                    
                    Agendar.Modificar = true;
                    Agendar.Cita = Convert.ToInt16(Data_Citas.CurrentRow.Cells[0].Value.ToString());
                    Agendar ag = new Agendar();
                    ag.FormClosed += ModificarFormClosed;
                    ag.ShowDialog();
                    
                }
            }
            else { MessageBox.Show("Seleccione la Cita que desea modificar."); }
            indexRow = -1;
            Data_Citas.ClearSelection();
        }

        private void OcultarColumnas()
        {
            this.Data_Citas.Columns[0].Visible = false;
            this.Data_Citas.Columns[5].Visible = false;
        }
        #endregion

        private void IsNuevaCita() {
            if (IsAgregado){
                Cargardatos('A');
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
                dv.RowFilter = string.Format("Primer_Nombre like '%{0}%'",txtFiltro.Text);
            Data_Citas.ClearSelection();
            btnCambio.Enabled = false;
        }

        private void AgendarClose(object sender, FormClosedEventArgs e) {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK){
                IsNuevaCita();
                IsAgregado = false;
            }
        }

        private void ModificarFormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                Cargardatos('A');
            }
        }

    }
}
