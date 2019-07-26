using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio.Cache;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            datos();
            Privilegios();
        }

        #region Movilidad del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Variables 
        int Lx, Ly, Sw, Sh;//Capturan posicion y tamaño
        #endregion

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            //else
            //{
            //}
        }

        private void pMax_Click(object sender, EventArgs e)
        {
            Lx = this.Location.X;
            Ly = this.Location.Y;
            Sw = this.Size.Width;
            Sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pRestaurar.Visible = true;
            pMax.Visible = false;
        }

        private void pMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pRestaurar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Lx, Ly);
            this.Size = new Size(Sw, Sh);
            pRestaurar.Visible = false;
            pMax.Visible = true;
        }

        private void pMenu_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 280)
            {
                Menu.Width = 45;
                pMenu.Location = new Point(6, 5);
                pUser.Size = new Size(37, 63);
                pUser.Location = new Point(3, 71);
                //pMenu.Size = new Size(48, 48);
                label4.Visible = false;

            }
            else
            {
                Menu.Width = 280;
                pMenu.Location = new Point(245, 3);
                pMenu.Size = new Size(32, 32);
                pUser.Location = new Point(3, 62);
                pUser.Size = new Size(64, 82);
                label4.Visible = true;
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas(); //Instancian el formulario que van abrir
            if (FormularioAbierto(citas/*Aqui agregan la instancia*/) == true)
            {
                MessageBox.Show("El formulario ya se encuentra abierto");
            }
            else
            {
                Clic_botonesMenu(citas, btnCitas);//Aqui pasan al metodo la instancia y el nombre del boton 
                //ahi estan los metodos los pueden revisar
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            Facturacion factura = new Facturacion(); 
            if (FormularioAbierto(factura) == true)
            {
                MessageBox.Show("El formulario ya se encuentra abierto");
            }
            else
            {
                Clic_botonesMenu(factura, btnFacturacion); 
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes report = new Reportes();
            if (FormularioAbierto(report) == true)
            {
                MessageBox.Show("El formulario ya se encuentra abierto");
            }
            else
            {
                Clic_botonesMenu(report, btnReportes);
            }
        }

        //Metodos y Eventos del Formulario
        #region Timer para la fecha y Hora
        private void HorayFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");//Formato de 24 horas
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
        #endregion

        #region Cambio de Color MouseOverBack

        private void EntradaMouse(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.ForeColor == Color.White)
            {
                btn.ForeColor = Color.FromArgb(64, 64, 64/*38,38,38/*1--59, 79, 81*/);
            }
            if (btn.BackColor == Color.FromArgb(20, 125, 217)) {
                btn.ForeColor = Color.White;
            }           
            if (btn.BackColor == Color.FromArgb(20, 125, 217))
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 125, 217);
            }
            else { btn.FlatAppearance.MouseOverBackColor = Color.Yellow; }
        }

        private void SalidaMouse(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.FromArgb(64, 64, 64/*2--38,38,38/*1--59,79,81*/))//Color.White)
            {
                btn.ForeColor = Color.White;//Color.FromArgb(25, 125, 217);
            }
            else { btn.ForeColor = Color.White; }
        }

        #endregion

        #region Metodos para los nuevos Formularios

        private void AbrirFormularioPanel(object FormHijo)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        } //Metodo para abrir el formulario dentro del panel Contenedor

        private void ej_FormClosed(Object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                ClearbtnMenu();
            }
        }//Metodo para capturar cuando el Formulario contenido en Panel Contenedor se cierre 


        #endregion

        #region Verificacion de panel Contenedor

        public bool revisar()
        {
            if (this.Contenedor.Controls.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool FormularioAbierto(Form form)
        {
            bool clave = false;
            List<Control> lista = new List<Control>();
            foreach (Control c in this.Contenedor.Controls)
            {
                if (c is Form)
                {
                    if (c.Name == form.Name)
                    {
                        clave = true;
                    }
                    else { clave = false; }
                }
            }
            return clave;
        }

        #endregion

        #region Metodos Click sobre los botones

        private void ClearbtnMenu()
        {
            List<Control> lista = new List<Control>();
            foreach (Control c in this.Menu.Controls)
            {
                if (c is Button)
                {
                    c.ForeColor = Color.White;//Color.FromArgb(20, 125, 217);
                    c.BackColor = Color.FromArgb(64, 64, 64/*2--38,38,38/*1--59,79,81*/);
                }
            }
        }

        private void cambiocolor(Button btn)
        {
            ClearbtnMenu();
            btn.BackColor = Color.FromArgb(20, 125, 217);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 125, 217);
        }

        private void Clic_botonesMenu(Form Formulario, Button btn)
        {
            btn.BackColor = /*Color.FromArgb(59, 79, 81);*/Color.FromArgb(20, 125, 217);
            if (revisar() == true)
            {
                if (MessageBox.Show("¿Se encuentra Abierto otro Formulario. Realmente desea Cerrar el actual?", "Mensaje Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cambiocolor(btn);
                    Formulario.FormClosed += ej_FormClosed;
                    AbrirFormularioPanel(Formulario);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(64, 64, 64/*38,38,38/*59, 79, 81*/);//Color.White;
                    btn.ForeColor = Color.White;//Color.FromArgb(20, 125, 217);
                }
            }
            else
            {
                cambiocolor(btn);
                Formulario.FormClosed += ej_FormClosed;
                AbrirFormularioPanel(Formulario);   
            }
        }

        #endregion

        #region Carga los Datos del usuario en Formulario Principal  
        private void datos() {
            lblNombre.Text = CacheLoginUser.Nombre + " " + CacheLoginUser.Apellido;
            lblUsuario.Text = CacheLoginUser.Usuario;
            lblCargo.Text = CacheLoginUser.Cargo;
        }
        #endregion

        #region Privilegios segun el cargo

        private void Privilegios()
        {
            if (CacheLoginUser.Cargo == Estructura_Cargos.Supervisor)
            {
                btnClientes.Enabled = false;
            }
            if (CacheLoginUser.Cargo == Estructura_Cargos.Recpcionista)
            {
                btnReportes.Enabled = false;
                btnEmpleados.Enabled = false;
                btnServicios.Enabled = false;
                btnClientes.Enabled = false;         
            }
            if (CacheLoginUser.Cargo == Estructura_Cargos.Estilista)
            {
                btnFacturacion.Enabled = false;
                btnEmpleados.Enabled = false;
                btnServicios.Enabled = false;
                btnClientes.Enabled = false;
            }
        }

        #endregion

    }
}
