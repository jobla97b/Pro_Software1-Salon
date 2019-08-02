using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Citas : Form 
    {
        public Citas()
        {
            InitializeComponent();
            InicioBotones();
        }

        #region Declaracion de Variables estaticas 
        public static string Fecha;
        public static string Corroborar; 
        
        public static int Año;
        public static int mes;
        public static bool jump;

        public static int dia;
        public static string nombredia;
        #endregion

        private void pCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;//Este codigo se lo tienen que poner a los form principales en su boton que cierre el formulario
            this.Close();//Este codigo se lo tienen que poner a los form principales en su boton que cierre el formulario
        }

        private void pToday_Click(object sender, EventArgs e)
        {
            FormInicio();
            PTodayBtn();
        }

        private void pAgendar_Click(object sender, EventArgs e)
        {
            //Cita_ViewDias ct = new Cita_ViewDias();
            AbrirFormularioPanel<Cita_ViewDias>();
            PAgendarBtn();
        }

        private void pDays_Click(object sender, EventArgs e)
        {
            //Cita_ViewDias ct = new Cita_ViewDias();
            AbrirFormularioPanel<Cita_ViewDias>();
            pDaysBtn();
        }

        private void pMonth_Click(object sender, EventArgs e)
        {
            //Cita_ViewMeses ct = new Cita_ViewMeses();
            AbrirFormularioPanel<Cita_ViewMeses>();
            pMonthBtn();
        }


        //Metodos del Formulario

        #region Bloqueo de los botones del menu
        public void InicioBotones()
        {
            FormInicio();//Abre el formulario de Inicio
            pToday.Enabled = false;
            pToday.BackColor = Color.Yellow;
            lineShape2.Visible = false;
            pDays.Visible = false;
            pMonth.Visible = false;
        } //Bloqueo de los botones al abrir el formulario

        public void PAgendarBtn() //Bloqueo los botones al hacer clic sobre Agendar
        {
            ClearMenu();
            pAgendar.Enabled = false;
            pAgendar.BackColor = Color.Yellow;
            pDays.Enabled = false;
            pDays.BackColor = Color.Yellow;
            lineShape2.Visible = true;
            pDays.Visible = true;
            pMonth.Visible = true;
        }

        public void PTodayBtn() //Bloquea los botones al hacer clic para ver la vista por defecto del fomulario de Citas
        {
            ClearMenu();
            pToday.Enabled = false;
            pToday.BackColor = Color.Yellow;
            lineShape2.Visible = false;
            pDays.Visible = false;
            pMonth.Visible = false;
        }

        public void pDaysBtn()//Bloquea los botones al entrar en modo vista del calendario
        {
            ClearMenu();
            pAgendar.Enabled = false;
            pDays.Enabled = false;
            pDays.BackColor = Color.Yellow;
            pAgendar.BackColor = Color.Yellow;
        }

        public void pMonthBtn()//Bloquea los botones al entrar en modo vista de los meses del año
        {
            ClearMenu();
            pAgendar.Enabled = false;
            pMonth.Enabled = false;
            pMonth.BackColor = Color.Yellow;
            pAgendar.BackColor = Color.Yellow;
        }

        public void ClearMenu()//Metodo para limpiar el color de seleccion de los pictureBox
        {
            List<Control> lista = new List<Control>();
            foreach (Control c in panelMenu.Controls)
            {
                if (c is PictureBox)
                {
                    c.BackColor = Color.White;
                    c.Enabled = true;
                }
            }
        }
        #endregion

        #region Metodo para abrir en cita los formularios respectivos de Cita
        public void AbrirFormularioPanel<T>() where T : Form, new()
        {
            CierreInstancias();//nuevo
            Form Formulario = panelContenido.Controls.OfType<T>().FirstOrDefault();
            if (Formulario != null)
            {
                if (Formulario.WindowState == FormWindowState.Minimized)
                {
                    Formulario.WindowState = FormWindowState.Maximized;
                }
                Formulario.BringToFront();
                return;
            }
            Formulario = new T();
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(Formulario);
            panelContenido.Tag = Formulario;
            Formulario.FormClosed += Prueba_FrmClose;
            Formulario.Show();
            Formulario.BringToFront();
        }
        #endregion

        #region Abre el formulario de inicio por defecto para el panel de citas
        public void FormInicio()
        {
            AbrirFormularioPanel<CitaAgendar>();
        }
        
        private void Prueba_FrmClose(Object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if(frm.DialogResult == DialogResult.OK)
            {
                if (Corroborar == "Agendar") {
                    PTodayBtn();
                    AbrirFormularioPanel<CitaAgendar>();
                    MessageBox.Show("Se pudo ajajajaja");
                }
                if (Corroborar == "Dias")
                {
                    PAgendarBtn();
                    AbrirFormularioPanel<Cita_ViewDias>();
                }
            }
            MessageBox.Show("Se pudo ajajajaja");
        }
        #endregion

        #region cierre de instancias
        //Puedo modificar el metodo de abrir formularios de Citas
        //ya que al no cerrar el formulario y solamente esconderlo o quitarlo del primer plano
        //no se realizan las instrucciones que se quieren ejecutar, ya que sigue siendo el mismo formulario que se inicio y no actualiza
        //Por razones de tiempo se dejara asi. Pero analizar y modificar.
        public void CierreInstancias()
        {
            var frm1 = Application.OpenForms.OfType<CitaAgendar>().FirstOrDefault();
            var frm2 = Application.OpenForms.OfType<Cita_ViewDias>().FirstOrDefault();
            var frm3 = Application.OpenForms.OfType<Cita_ViewMeses>().FirstOrDefault();
            if (frm1 != null)
            {
                frm1.Close();
                MessageBox.Show("Formulario Activo de Agendar formulario por defcto");
            }
            if (frm2 != null)
            {
                frm2.Close();
                MessageBox.Show("Formulario de View Dias");
            }
            if (frm3 != null)
            {
                frm3.Close();
                MessageBox.Show("Formulario de View Meses");
            }
        } 
        #endregion

    }

}
