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
    public partial class Cita_ViewMeses : Form
    {
        public Cita_ViewMeses()
        {
            InitializeComponent();
            loadlabels();
        }

        string e = Convert.ToString(DateTime.Today.Year);

        #region Metodos del Formulario Meses
        protected internal void loadlabels()
        {
            lblAño.Text = e;
            if (lblAño.Text == Convert.ToString(DateTime.Today.Year))
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                    Enero.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 2)
                    Febero.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 3)
                    Marzo.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 4)
                    Abril.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 5)
                    Mayo.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 6)
                    Junio.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 7)
                    Julio.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 8)
                    Agosto.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 9)
                    Septiembre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 10)
                    Octubre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 11)
                    Noviembre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 12)
                    Diciembre.BackColor = Color.FromArgb(176, 180, 43);
            }
            else
                transparentlabels();
        }
        private void transparentlabels()
        {
            Enero.BackColor = Color.FromArgb(50, 50, 50);
            Febero.BackColor = Color.FromArgb(50, 50, 50);
            Marzo.BackColor = Color.FromArgb(50, 50, 50);
            Abril.BackColor = Color.FromArgb(50, 50, 50);
            Mayo.BackColor = Color.FromArgb(50, 50, 50);
            Junio.BackColor = Color.FromArgb(50, 50, 50);
            Julio.BackColor = Color.FromArgb(50, 50, 50);
            Agosto.BackColor = Color.FromArgb(50, 50, 50);
            Septiembre.BackColor = Color.FromArgb(50, 50, 50);
            Octubre.BackColor = Color.FromArgb(50, 50, 50);
            Noviembre.BackColor = Color.FromArgb(50, 50, 50);
            Diciembre.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void completer()
        {
            Citas.jump = true;
        }

        #endregion

        #region Metodo para los picturebox
        private void pAtras_Click(object sender, EventArgs e)
        {
            string xrt = lblAño.Text;
            int primero = Convert.ToInt32(xrt);
            primero -= 1;
            lblAño.Text = Convert.ToString(primero);
            if (lblAño.Text == Convert.ToString(DateTime.Today.Year))
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                    Enero.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 2)
                    Febero.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 3)
                    Marzo.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 4)
                    Abril.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 5)
                    Mayo.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 6)
                    Junio.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 7)
                    Julio.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 8)
                    Agosto.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 9)
                    Septiembre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 10)
                    Octubre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 11)
                    Noviembre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 12)
                    Diciembre.BackColor = Color.FromArgb(176, 180, 43);
            }
            else
                transparentlabels();
        }

        private void pAdelante_Click(object sender, EventArgs e)
        {
            string xrt = lblAño.Text;
            int primero = Convert.ToInt32(xrt);
            primero += 1;
            lblAño.Text = Convert.ToString(primero);
            if (lblAño.Text == Convert.ToString(DateTime.Today.Year))
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                    Enero.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 2)
                    Febero.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 3)
                    Marzo.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 4)
                    Abril.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 5)
                    Mayo.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 6)
                    Junio.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 7)
                    Julio.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 8)
                    Agosto.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 9)
                    Septiembre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 10)
                    Octubre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 11)
                    Noviembre.BackColor = Color.FromArgb(176, 180, 43);
                else if (monthno == 12)
                    Diciembre.BackColor = Color.FromArgb(176, 180, 43);
            }
            else
                transparentlabels();
        }

        #endregion

        #region Evento click sobre las etiquetas
        public void Enero_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Febero_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Marzo_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 3;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Abril_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 4;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Mayo_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 5;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Junio_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 6;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Julio_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 7;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Agosto_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 8;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Septiembre_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 9;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Octubre_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 10;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Noviembre_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 11;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Diciembre_Click(object sender, EventArgs e)
        {
            completer();
            Citas.Corroborar = "Dias";
            Citas.Año = Convert.ToInt32(lblAño.Text);
            Citas.mes = 12;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }

}
