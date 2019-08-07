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
    public partial class Agendar : Form
    {
        public Agendar()
        {
            InitializeComponent();
            validacionDateTime();
        }

        public static string Nombres;
        public static string Apellidos;
        public static string Telefono;
        public static string id;

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
    }
}
