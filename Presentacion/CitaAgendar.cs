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
            labelfecha();
        }
        #region Declaracion de variables
        string fechaparametro;
        string dia, mes;
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #region Metodo de carga para la label Fecha
        private void labelfecha()
        {
            if (Citas.Corroborar != "Agendar")
            {
                lblFecha.Text = "Aqui va estar fecha actual";
            }
            else
            {
                lblFecha.Text = Citas.nombredia;
                valida_datos_pasados(Citas.dia, Citas.mes);
                fechaparametro = "" + dia + "/" + mes + "/" + Citas.Año.ToString();
                Cargardatos();
                txtFiltro.Text=fechaparametro;
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
        private void Cargardatos()
        {
            this.Data_Citas.DataSource = D_Cita.D_Listado(fechaparametro, 'A');
        }
        #endregion
    }
}
