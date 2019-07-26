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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Aqui Implemente el metodo login
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = D_Usuario.Login(this.txtUsuario.Text, this.txtpass.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos.", "ERROR DE AUTENTICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CacheLoginUser.IdUsuario = Convert.ToInt16(dt.Rows[0][0].ToString());
                CacheLoginUser.IdEmpleado = Convert.ToInt16(dt.Rows[0][1].ToString());
                CacheLoginUser.Nombre = dt.Rows[0][2].ToString();
                CacheLoginUser.Apellido = dt.Rows[0][3].ToString();
                CacheLoginUser.IdCargo = Convert.ToInt32(dt.Rows[0][4].ToString());
                CacheLoginUser.Cargo = dt.Rows[0][5].ToString();
                CacheLoginUser.Usuario = dt.Rows[0][6].ToString();
                Principal pn = new Principal();
                pn.Show();
                this.Hide();
            }
        }
        #endregion
    }
}
