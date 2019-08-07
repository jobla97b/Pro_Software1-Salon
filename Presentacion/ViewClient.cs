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
    public partial class ViewClient : Form
    {
        public ViewClient()
        {
            InitializeComponent();
            AjustarColumnas();
        }

        private void ViewClient_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'salonDataSet.ClientesCitas' Puede moverla o quitarla según sea necesario.
            this.clientesCitasTableAdapter.Fill(this.salonDataSet.ClientesCitas);
        }

        private void AjustarColumnas()
        {
            this.dataGridViewClient.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewClient.Columns[0].Visible = false;
            this.comboBox1.SelectedIndex = 0;
        }

        private void dataGridViewClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow fila = dataGridViewClient.CurrentRow;
            Agendar.id = fila.Cells[0].Value.ToString();
            Agendar.Nombres = fila.Cells[2].Value.ToString() + " " + fila.Cells[3].Value.ToString();
            Agendar.Apellidos = fila.Cells[4].Value.ToString() + " " + fila.Cells[5].Value.ToString();
            Agendar.Telefono = fila.Cells[6].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridViewClient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn Col in dataGridViewClient.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Nombre"))
            {
                salonDataSet.Tables[0].DefaultView.RowFilter = ("PrimerNombre like '" + textBox1.Text + "%'");
            }
            else
            {
                salonDataSet.Tables[0].DefaultView.RowFilter = ("PrimerApellido like '" + textBox1.Text + "%'");
            }

            dataGridViewClient.DataSource = salonDataSet.Tables[0].DefaultView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                label1.Text = "Apellido";
            }
            if (comboBox1.SelectedIndex==1)
            {
                label1.Text = "Nombre";
            }
        }
    }
}
