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
    public partial class EliminarProducto : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario t = new TablaUsuario();
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            DataGridEliminarP.DataSource = t.mostrarInventario();
            try {
                CBEliPro.DropDownStyle = ComboBoxStyle.DropDownList;
                CBEliPro.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT idProducto FROM Producto",conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    CBEliPro.Refresh();
                    CBEliPro.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            }catch (MySqlException r){
                MessageBox.Show(r.Message);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            Inv.Visible = true;
            this.Visible = false;
        }

        //VERIFICATION
        private void btnElim_Click(object sender, EventArgs e)
        {
            if (CBEliPro.SelectedIndex > -1)
            {
                int id = int.Parse(CBEliPro.SelectedItem.ToString());
                t.EliminarPro(id);
                Inventario u = new Inventario();
                this.Hide();
                u.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado el ID del artículo a eliminar");
            }

        }
    }
}
