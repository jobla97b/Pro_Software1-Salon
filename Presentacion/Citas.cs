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
            AbrirFormularioPanel<Cita_ViewDias>();
            PAgendarBtn();
        }

        private void pDays_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel<Cita_ViewDias>();
            pDaysBtn();
        }

        private void pMonth_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel<Cita_ViewMeses>();
            pMonthBtn();
        }


        //Metodos del Formulario

        #region Bloqueo de los botones del menu
        public void InicioBotones()
        {
            FormInicio();
            pToday.Enabled = false;
            pToday.BackColor = Color.FromArgb(46, 59, 104);
            lineShape2.Visible = false;
            pDays.Visible = false;
            pMonth.Visible = false;
        } 
        public void PAgendarBtn()
        {
            ClearMenu();
            pAgendar.Enabled = false;
            pAgendar.BackColor = Color.FromArgb(46, 59, 104);
            pDays.Enabled = false;
            pDays.BackColor = Color.FromArgb(46, 59, 104);
            lineShape2.Visible = true;
            pDays.Visible = true;
            pMonth.Visible = true;
        }

        public void PTodayBtn() 
        {
            ClearMenu();
            pToday.Enabled = false;
            pToday.BackColor = Color.FromArgb(46, 59, 104);
            lineShape2.Visible = false;
            pDays.Visible = false;
            pMonth.Visible = false;
        }

        public void pDaysBtn()
        {
            ClearMenu();
            pAgendar.Enabled = false;
            pDays.Enabled = false;
            pDays.BackColor = Color.FromArgb(46, 59, 104);
            pAgendar.BackColor = Color.FromArgb(46, 59, 104);
        }

        public void pMonthBtn()
        {
            ClearMenu();
            pAgendar.Enabled = false;
            pMonth.Enabled = false;
            pMonth.BackColor = Color.FromArgb(46, 59, 104);
            pAgendar.BackColor = Color.FromArgb(46, 59, 104);
        }

        public void ClearMenu()
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
            CierreInstancias();
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
                    //MessageBox.Show("Se pudo ajajajaja");
                }
                if (Corroborar == "Dias")
                {
                    PAgendarBtn();
                    AbrirFormularioPanel<Cita_ViewDias>();
                }
            }
            //MessageBox.Show("Se pudo ajajajaja");
        }
        #endregion

        #region cierre de instancias
        public void CierreInstancias()
        {
            var frm1 = Application.OpenForms.OfType<CitaAgendar>().FirstOrDefault();
            var frm2 = Application.OpenForms.OfType<Cita_ViewDias>().FirstOrDefault();
            var frm3 = Application.OpenForms.OfType<Cita_ViewMeses>().FirstOrDefault();
            if (frm1 != null)
            {
                frm1.Close();

                //MessageBox.Show("Formulario Activo de Agendar formulario por defcto");
            }
            if (frm2 != null)
            {
                frm2.Close();

                //MessageBox.Show("Formulario de View Dias");
            }
            if (frm3 != null)
            {
                frm3.Close();

                //MessageBox.Show("Formulario de View Meses");

            }
        } 
        #endregion

    }

}
