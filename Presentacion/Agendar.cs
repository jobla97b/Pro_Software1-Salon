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
    public partial class Agendar : Form
    {
        public Agendar()
        {
            InitializeComponent();
            validacionDateTime();
            AjustarColumnas();
            EventoModificar();
            BloquearControles();
            BloqueoEstilista();
            //prueba();
        }
        public static bool IsNuevo = false;
        public static bool Modificar = false;
        public static int Cita = 0;

        public static string Nombres;
        public static string Apellidos;
        public static string Telefono;
        public static string id;
        public static string EmpleadoNombre;
        public static string EmpleadoApellido;
        public static string idempleado;
        //
        public static string id_Serv;
        public static string Servicio;
        public static string Duracion;
        public static string Costo;
        public static string Moneda;
        public static int rows;
        public static string ultimoid;
        //public static DataTable tablaid = new DataTable();
        public bool elim = false;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void validacionDateTime()
        {
            //dateTimePicker1.Value = DateTime.Now;
            dateTimePickHour.Value = DateTime.Parse("8:00");
            dateTimePickHour.Format = DateTimePickerFormat.Custom;
            dateTimePickHour.CustomFormat = "HH:mm";
            dateTimePickHour.MinDate = DateTime.Parse("8:00");
            dateTimePickHour.MaxDate = DateTime.Parse("17:00");
            //
            dateTimePickFecha.Enabled = false;
            dateTimePickFecha.Value = DateTime.Now;
            dateTimePickFecha.Format = DateTimePickerFormat.Short;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+dateTimePickHour.Value.Hour+dateTimePickHour.Value.Minute);
            ViewClient vc = new ViewClient();
            vc.FormClosed += ClienteView;
            vc.ShowDialog();
        }

        private void ClienteView(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                txtNombres.Text = Nombres;
                txtApellidos.Text = Apellidos;
                txtTelefono.Text = Telefono;
                Id_Cliente.Text = id;
            }

        }

        private void btnNewEmpleado_Click(object sender, EventArgs e)
        {
            ViewEmpleado ve = new ViewEmpleado();
            ve.FormClosed += EmpleadoFormClosed;
            ve.ShowDialog();
        }

        private void btnNewServicio_Click(object sender, EventArgs e)
        {
            VerificaDatagrid();
            ViewServicios vs = new ViewServicios();
            vs.FormClosed += ServicioFromClosed;
            vs.ShowDialog();
        }

        private void EmpleadoFormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = sender as Form;
            if (f.DialogResult == DialogResult.OK) {
                Id_Empleado.Text = idempleado;
                txtEmpleadoNombre.Text = EmpleadoNombre;
                txtEmpleadoApellido.Text = EmpleadoApellido;
            }
        }

        private void ServicioFromClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            //MessageBox.Show(""+dataGridViewServicios.Rows.Count);
            if (frm.DialogResult == DialogResult.OK)
            {
                if (dataGridViewServicios.RowCount <= 0)
                {
                    //MessageBox.Show("No hay Celdas");
                    dataGridViewServicios.Rows.Add(id_Serv, Servicio, Duracion, Costo, Moneda);
                }
                else
                {
                    bool consulta = false;
                    for (int i = 0; i <= dataGridViewServicios.Rows.Count - 1; i++)
                    {
                        if (dataGridViewServicios.Rows[i].Cells[0].Value.ToString().Equals(id_Serv)) { consulta = true; }
                    }

                    if (consulta == true)
                    {
                        MessageBox.Show("Servicio ya ha sido agreegado.");
                    }
                    else
                    {
                        dataGridViewServicios.Rows.Add(id_Serv, Servicio, Duracion, Costo, Moneda);
                    }
                }
            }
        }

        private void VerificaDatagrid()
        {
            //DataRow row = tablaid.NewRow();

            //rows = dataGridViewServicios.RowCount;
            //for (int i = 0; i <= dataGridViewServicios.Rows.Count - 1; i++)
            //{
            //    ultimoid = dataGridViewServicios.Rows[i].Cells[0].Value.ToString();
            //    tablaid.Columns.Add(column);
            //    row["IdServ"] = ultimoid;
            //    tablaid.Rows.Add(row);
            //}

        }

        private void AjustarColumnas()
        {
            this.dataGridViewServicios.Columns[0].Visible = false;
            this.dataGridViewServicios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewServicios.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewServicios.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewServicios.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void prueba() {
            DataColumn column;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IdServ";
            //tablaid.Columns.Add(column);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Desea cancelar la cita", "Mensaje de Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string respt = "";
            string respt1 = "";
            if (Id_Cliente.Text!="")
            {
                if (Id_Empleado.Text != "")
                {
                    if (dataGridViewServicios.RowCount > 0) {
                        if (IsNuevo)
                        {
                            string hour;
                            hour = HoraCita(dateTimePickHour.Value.Hour.ToString(), dateTimePickHour.Value.Minute.ToString());
                            D_Cita dc = new D_Cita();
                            respt = dc.D_NuevaCita(Convert.ToInt16(Id_Cliente.Text.ToString()), dateTimePickFecha.Value.Date.ToShortDateString().ToString(),hour);
                            //MessageBox.Show("Nuevo Registro" + Id_Cliente.Text + " " + dateTimePickFecha.Value.Date.ToShortDateString().ToString() + " " +hour);
                            //respt = "No se pudo";
                            //MessageBox.Show("Cita agregada");
                        }
                        else
                        {
                            MessageBox.Show("Modificar");
                        }
                        if (respt.Equals("Ok")){
                            for(int fila = 0; fila <= dataGridViewServicios.Rows.Count-1; fila++)
                            {
                                D_DetalleCita dtc = new D_DetalleCita();
                                Int16 valor1 = Convert.ToInt16(dataGridViewServicios.Rows[fila].Cells[0].Value.ToString());
                                decimal valor2= Convert.ToDecimal(dataGridViewServicios.Rows[fila].Cells[3].Value.ToString());
                                respt1 = dtc.NuevoDetCita(valor1,Convert.ToInt16(Id_Empleado.Text.ToString()),valor2);
                                if (respt1.Equals("Ok"))
                                {
                                    if (fila == dataGridViewServicios.Rows.Count - 1) { MessageBox.Show("Cita Agregada Satisfactoriamente.","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information); ClearDatos(); btnNewClient.Focus();CitaAgendar.IsAgregado = true; }
                                }
                                else { MessageBox.Show("" + respt1); break; }
                            }
                        }
                        else
                        {
                            MessageBox.Show("" + respt);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es necesario que ingrese por lo menos un servicio.","Mensage de Notificacion");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor Indique el empleado asociado a la cita.");
                }
            }
            else
            {
                MessageBox.Show("Debe de especificar un Cliente para una Cita.", "Mensaje de Notificacion");
            }
        }

        private string HoraCita(string Hora, string minutos)
        {
            string Horaprogramada,hor,minut = "";
            if (Convert.ToInt16(Hora) < 10)
            {
                hor = "0"+Hora;
            }
            else { hor = Hora; }
            if (Convert.ToInt16(minutos) < 10) {
                minut = "0" + minutos;
            }else { minut = minutos; }
            return Horaprogramada=hor+":"+minut;
        }

        private void ClearDatos(){
            foreach(Control c in this.Controls){
                if (c is TextBox) {
                    c.Text = "";
                }
                if(c is Panel){
                    foreach (Control b in c.Controls){
                        if (b is TextBox) {
                            b.Text = "";
                        }
                    }
                }
            }
            dataGridViewServicios.Rows.Clear();
            dateTimePickHour.Value = DateTime.Parse("8:00");
        }

        private void EventoModificar()
        {
            if (Modificar)
            {
                MessageBox.Show("En Efecto entro a modificar");
                MessageBox.Show("" + Cita);
                cargarDatos();
                CargarDataCita();
                btnModificar.Visible = true;
                button5.Visible = false;
                dateTimePickFecha.Enabled = true;
                elim = true;
            }
            Modificar = false;
        }

        private void cargarDatos() {
            DataTable dt = D_Cita.D_BuscMod(Convert.ToInt16(Cita));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CITA NO ENCONTRADA.", "ERROR DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id_Cliente.Text = dt.Rows[0][0].ToString();
                txtNombres.Text = dt.Rows[0][1].ToString() +" "+ dt.Rows[0][2].ToString();
                txtApellidos.Text = dt.Rows[0][3].ToString()+" "+ dt.Rows[0][4].ToString();
                txtTelefono.Text = dt.Rows[0][5].ToString();
                dateTimePickHour.Value = DateTime.Parse(dt.Rows[0][6].ToString());
                Id_Empleado.Text = dt.Rows[0][7].ToString();
                txtEmpleadoNombre.Text = dt.Rows[0][8].ToString()+" "+dt.Rows[0][9].ToString();
                txtEmpleadoApellido.Text = dt.Rows[0][10].ToString()+" "+ dt.Rows[0][11].ToString();
            }
        }

        private void CargarDataCita(){
            DataTable dt = D_Cita.D_ServBuscMod(Convert.ToInt16(Cita));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("SERVICIO NO ENCONTRADA.", "ERROR DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dataGridViewServicios.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                                                   dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
                }
            }
        }

        #region Metodos de Bloqueo de Botones
        private void BloquearControles()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false; ;
                }
                if (c is Panel)
                {
                    foreach (Control b in c.Controls)
                    {
                        if (b is TextBox)
                        {
                            b.Enabled = false;
                        }
                    }
                }
            }
        }
        private void BloqueoEstilista(){
            if (CacheLoginUser.Cargo==Estructura_Cargos.Estilista) {
                btnNewClient.Enabled = false;
                btnNewEmpleado.Enabled = false;
                btnNewServicio.Enabled = false;
                btnQuitarServicio.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                dateTimePickHour.Enabled = false;
                cargarDatos();
                CargarDataCita();
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CacheLoginUser.Cargo==Estructura_Cargos.Estilista)
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Desea cancelar la cita", "Mensaje de Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnQuitarServicio_Click(object sender, EventArgs e)
        {
            if (dataGridViewServicios.RowCount>0) {
            if (dataGridViewServicios.CurrentRow.Index == null)
            {
                return;
            }
            else
            {
                if (elim)
                {
                    MessageBox.Show("Aqui va ir el procedimiento de eliminacion de detalle");
                }
                else
                {
                    if (MessageBox.Show("Desea Remover el Servicio.","Mensaje de Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                        dataGridViewServicios.Rows.Remove(dataGridViewServicios.CurrentRow);
                    }
                }
            }
          }
          else { MessageBox.Show("La tabla se Encuentra Vacia.","Mensaje Informativo",MessageBoxButtons.OK,MessageBoxIcon.Information); }
        }

    }
}
