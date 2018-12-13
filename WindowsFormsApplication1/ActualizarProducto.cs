using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autolavado
{
    public partial class ActualizarProducto : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario t = new TablaUsuario();
        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            DataGridActualizarP.DataSource = t.mostrarInventario();
            try
            {
                CBActualizar.DropDownStyle = ComboBoxStyle.DropDownList;
                CBActualizar.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT idProducto FROM Producto",conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    CBActualizar.Refresh();
                    CBActualizar.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            }catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            Inv.Visible = true;
            this.Visible = false;
        }

        private void CBActualizar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPrecio.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            int u;
            try
            {
                u = int.Parse(CBActualizar.SelectedItem.ToString());
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT nombre, cantidad, precio FROM Producto WHERE idProducto="+u, conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txtNombre.Text = lector.GetString(0);
                    txtCantidad.Text = Convert.ToString(lector.GetInt32(1));
                    txtPrecio.Text = Convert.ToString(lector.GetFloat(2));
                }
                conectar1.cerrarConexion();
            }catch (MySqlException r){
                MessageBox.Show(r.Message);
            }
        }

        //VERIFICATION
        private void btnActPro_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtCantidad.Text != "" && txtPrecio.Text != "" && CBActualizar.SelectedIndex > -1)
            {
                u.setNombreEmp(txtNombre.Text);
                u.setCantidad(int.Parse(txtCantidad.Text));
                u.setPrecio(float.Parse(txtPrecio.Text));
                int i = int.Parse(CBActualizar.SelectedItem.ToString());
                try
                {
                    t.ActualizarProductos(u, i);
                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
                Inventario o = new Inventario();
                this.Hide();
                o.Show();
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
