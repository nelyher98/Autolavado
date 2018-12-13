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
    public partial class NuevoAdmi : Form
    {
        TablaUsuario tu = new TablaUsuario();
        Usuario u = new Usuario();
        public NuevoAdmi()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerAdm n = new VerAdm();
            this.Hide();
            n.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            u.setNombreEnc(TxtUsuario.Text);
            u.setContraseña(TxtContra.Text);
            u.setNombreEmp(txtNombre.Text);
            u.setApellido(txtApellido.Text);
            tu.InsertarAdm(u);
            VerAdm n = new VerAdm();
            this.Hide();
            n.Show();
        }
    }
}
