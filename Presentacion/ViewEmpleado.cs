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
    public partial class ViewEmpleado : Form
    {
        public ViewEmpleado()
        {
            InitializeComponent();
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewColumn Col in dataGridView1.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ViewEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'salonDataSet2.EmpleadoCitas' Puede moverla o quitarla según sea necesario.
            this.empleadoCitasTableAdapter.Fill(this.salonDataSet2.EmpleadoCitas);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Nombre"))
            {
                salonDataSet2.Tables[0].DefaultView.RowFilter = ("PrimerNombre like '" + textBox1.Text + "%'");
            }
            else
            {
                salonDataSet2.Tables[0].DefaultView.RowFilter = ("PrimerApellido like '" + textBox1.Text + "%'");
            }

            dataGridView1.DataSource = salonDataSet2.Tables[0].DefaultView;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow fila = dataGridView1.CurrentRow;
            Agendar.idempleado = fila.Cells[0].Value.ToString();
            Agendar.EmpleadoNombre = fila.Cells[2].Value.ToString() + " " + fila.Cells[3].Value.ToString();
            Agendar.EmpleadoApellido = fila.Cells[4].Value.ToString() + " " + fila.Cells[5].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
