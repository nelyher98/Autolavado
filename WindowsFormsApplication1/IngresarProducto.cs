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
    public partial class IngresarProducto : Form
    {
        string s;
        int g;
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        ActualizarEmpleado q = new ActualizarEmpleado();
        public IngresarProducto()
        {
            InitializeComponent();
            s = TU.datomaxp();
            if (s == "")
            {
                g = 1;
            }
            else
            {
                g = Int32.Parse(s);
                g = g + 1;
            }
            TxtId.Text = g.ToString();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            Inv.Visible = true;
            this.Visible = false;
        }

        //VERIFICATION
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != " " && txtCantidad.Text != "" && txtPrecio.Text != " ")
            {
                u.setcodi(int.Parse(TxtId.Text));
                u.setNombreEmp(txtNombre.Text);
                u.setCantidad(int.Parse(txtCantidad.Text));
                u.setPrecio(float.Parse(txtPrecio.Text));

                try { TU.InsertarPro(u); }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
                Inventario n = new Inventario();
                this.Hide();
                n.Show();
            }
            else
            {
                MessageBox.Show("No se han ingresado todos los datos");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumeroDecimal(sender, e);
        }
    }
}
