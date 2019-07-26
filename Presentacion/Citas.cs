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
        }

        private void pCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;//Este codigo se lo tienen que poner a los form principales en su boton que cierre el formulario
            this.Close();//Este codigo se lo tienen que poner a los form principales en su boton que cierre el formulario
        }
    }
}
