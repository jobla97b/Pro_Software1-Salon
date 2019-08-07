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

        #region Declaracion de variables
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
            ag.dateTimePickFecha.Value = Convert.ToDateTime(fechaparametro);
            ag.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (indexRow!=-1) { MessageBox.Show("Se puede"); Data_Citas.ClearSelection();
                indexRow = -1;
            } else { MessageBox.Show("No hay seleccion"); }
            panelBusqueda.Enabled = true;
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
        }

        #region Metodo de carga para la label Fecha
        private void labelfecha()
        {
            if (Citas.Corroborar != "Agendar")
            {
                //lblFecha.Text = "Aqui va estar fecha actual";
                valida_datos_pasados(d1, m1);
                fechaparametro= "" + dia + "/" + mes + "/" + A1.ToString();
                txtFiltro.Text = fechaparametro;
                FechaActual(d1, m1, A1);
                Cargardatos('Z');
                dateTimePickerBuscar.Value = Convert.ToDateTime(fechaparametro);
            }
            else
            {
                lblFecha.Text = Citas.nombredia;
                valida_datos_pasados(Citas.dia, Citas.mes);
                fechaparametro = "" + dia + "/" + mes + "/" + Citas.Año.ToString();
                Cargardatos('A');
                txtFiltro.Text=fechaparametro;
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
            //para el Mes
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

            }
            else
            {
                this.Data_Citas.DataSource = D_Cita.D_Listado(fechaparametro, Estad);
                //if (Data_Citas.Rows.Count <= 1) { MessageBox.Show("En efecto no hay seleccion"); }
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
                //MessageBox.Show("Fecha Futura");
                consultafecha = "Futura";
            }
            else if (value < 0)
            {
                //MessageBox.Show("Fecha Pasada");
                consultafecha = "Pasada";
            }
            else
            {
                //MessageBox.Show("Fecha Actual");
                consultafecha = "Actual";
            }
        }

        private void BloqueoBtnporFecha()
        {
            if (consultafecha=="Pasada" && CacheLoginUser.Cargo != Estructura_Cargos.Estilista)
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                //btnCambio.Enabled = false;
            }
            else if(consultafecha!="Pasada" && CacheLoginUser.Cargo != Estructura_Cargos.Estilista)
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                //btnCambio.Enabled = true;
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

        private void Data_Citas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //evento clic sobre una colummna
        {
            if (e.RowIndex < 0) { return; }
            if (CacheLoginUser.Cargo==Estructura_Cargos.Estilista)//Evento cuando el ususario sea un empleado y de clic sobre el datgridview
            {
                DataGridViewRow fila = Data_Citas.CurrentRow;
                MessageBox.Show("Solo prueba" + fila.Cells[0].Value + " " + fila.Cells[5].Value);
            }
            else//Cualquier otro Ususario va a tener permitido esto
            {
                if (Data_Citas.CurrentRow.Index > -1) { /*MessageBox.Show("He seleccionado"); */}
                indexRow = Data_Citas.CurrentRow.Index;//para validar los botones Modificar
                //Cambio de estado de la cita 
                if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "F")
                {
                    MessageBox.Show("No puede Realizar cambio sobre citas facturadas");
                }
                if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "C")
                {
                    //btnCambio.Text = "Confirmar";
                    btnCambio.Visible = false;
                    btnConfir.Enabled = true;
                }
                else if (Data_Citas.CurrentRow.Cells[4].Value.ToString() == "P") {
                    //btnCambio.Text = "Cancelar";
                    btnConfir.Visible = false;
                    btnCambio.Enabled = true;
                }
            }
        }

        private void btnFech_Click(object sender, EventArgs e)//Revisar este evento de busqueda por la fecha en citaagendar
        {
            //string nom = Application.CurrentCulture.Calendar.GetDayOfWeek(dateTimePickerBuscar.Value.Date).ToString();
            //string nommes = Application.CurrentCulture.DateTimeFormat.GetMonthName(dateTimePickerBuscar.Value.Month).ToString();
            //lblFecha.Text = nom + "," + dateTimePickerBuscar.Value.Day + " de " + nommes+ " del " + dateTimePickerBuscar.Value.Year;
            fechaparametro = dateTimePickerBuscar.Value.Date.ToShortDateString().ToString();
            //txtFiltro.Text = fechaparametro;
            Cargardatos('A');
            MessageBox.Show(dateTimePickerBuscar.Value.Date.ToShortDateString());
            panelBusqueda.Enabled = false;
            if (consultafecha!="Pasada")
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
            }
            btnBuscar.Enabled = true;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            btnCambio.Enabled = false;
            btnConfir.Visible = true;
        }

        private void btnConfir_Click(object sender, EventArgs e)
        {
            btnConfir.Enabled = false;
            btnCambio.Visible = true;
        }

        private void OcultarColumnas()
        {
            this.Data_Citas.Columns[0].Visible = false;
            this.Data_Citas.Columns[5].Visible = false;
        }
        #endregion

    }
}
