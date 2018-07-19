using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentasCS
{
    public partial class FormRecuperarContraseña : Form
    {
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void buttonRecuperar_Click(object sender, EventArgs e)
        {
            Loginuser.CrudUsuarios x = new Loginuser.CrudUsuarios();
          txtMensaje.Text =  x.RecuperarContraseña(txtCurp.Text);
        }
    }
}
