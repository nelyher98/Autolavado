using MySql.Data.MySqlClient;
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
    public partial class IngresarEmpleado : Form
    {
        string s;
        int g;
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        ActualizarEmpleado q = new ActualizarEmpleado();
        public IngresarEmpleado()
        {
            InitializeComponent();
            s = TU.datomax();
            if (s=="")
            {
                g = 1;
            }
            else
            {
                g = Int32.Parse(s);
                g = g + 1;

            }
            TxtClave.Text = g.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerEmpleado n = new VerEmpleado();
            this.Hide();
            n.Show();
        }

        //VERIFICATION
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text != "" && txtNombre.Text != "" && txtApellido.Text != "")
            {
                u.setcod(TxtClave.Text);
                u.setNombreEmp(txtNombre.Text);
                u.setApellido(txtApellido.Text);

                try
                {
                    TU.InsertarEmp(u);
                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
                VerEmpleado n = new VerEmpleado();
                this.Hide();
                n.Show();

            }
            else
            {
                MessageBox.Show("No se han ingresado algunos datos");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }
    }
}
