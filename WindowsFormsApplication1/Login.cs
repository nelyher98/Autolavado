using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolavado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="Hola" && txtContra.Text=="1234") {
                MessageBox.Show("Usuario correcto","CORRECTO",MessageBoxButtons.OK,MessageBoxIcon.Information);

                 Loader M = new Loader();
                 this.Visible = false;
                 M.Visible = true;
            }
            else
            {
                MessageBox.Show("Error en usuario o contraseña","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender,e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }
    }
}
