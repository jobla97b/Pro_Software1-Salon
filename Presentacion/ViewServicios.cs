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
    public partial class ViewServicios : Form
    {
        public ViewServicios()
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

        private void ViewServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'salonDataSet1.ServiciosCitas' Puede moverla o quitarla según sea necesario.
            this.serviciosCitasTableAdapter.Fill(this.salonDataSet1.ServiciosCitas);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Nombre Servicio"))
            {
                salonDataSet1.Tables[0].DefaultView.RowFilter = ("Nombre_Servicio like '" + textBox1.Text + "%'");
            }
            else
            {
                salonDataSet1.Tables[0].DefaultView.RowFilter = ("Categoria like '" + textBox1.Text + "%'");
            }

            dataGridView1.DataSource = salonDataSet1.Tables[0].DefaultView;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow fila = dataGridView1.CurrentRow;
            //Agendar agenda = new Agendar();
            ////MessageBox.Show(""+agenda.dataGridViewServicios.RowCount);
            //if (Agendar.rows <= 0)
            //{
            //    MessageBox.Show("No hay Celdas");
                //dataGridViewServicios.Rows.Add(id_Serv, Servicio, Duracion, Costo, Moneda);
                Agendar.id_Serv = fila.Cells[0].Value.ToString();
                Agendar.Servicio = fila.Cells[2].Value.ToString();
                Agendar.Duracion = fila.Cells[3].Value.ToString();
                Agendar.Costo = fila.Cells[4].Value.ToString();
                Agendar.Moneda = fila.Cells[5].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            //}
            //else
            //{
            //    bool consulta = false;
            //    for (int i = 0; i <= Agendar.tablaid.Rows.Count - 1; i++)
            //    {
            //        if (Agendar.tablaid.Rows[i]["IdServ"].ToString().Equals(fila.Cells[0].Value.ToString())) { consulta = true; }
            //    }

            //    if (consulta == true)
            //    //if(Agendar.ultimoid== fila.Cells[0].Value.ToString())
            //    {
            //        MessageBox.Show("Servicio ya ha sido agreegado.");
            //    }
            //    else
            //    {
            //        Agendar.id_Serv = fila.Cells[0].Value.ToString();
            //        Agendar.Servicio = fila.Cells[2].Value.ToString();
            //        Agendar.Duracion = fila.Cells[3].Value.ToString();
            //        Agendar.Costo = fila.Cells[4].Value.ToString();
            //        Agendar.Moneda = fila.Cells[5].Value.ToString();

            //        this.DialogResult = DialogResult.OK;
            //        this.Close();
            //    }
            //}

        }
    }
}
