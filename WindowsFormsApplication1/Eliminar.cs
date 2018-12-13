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
    public partial class Eliminar : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string g;
            g = CBEliminar.SelectedItem.ToString();
            TU.EliminarPlac(g);
            Eliminada E = new Eliminada();
            E.Visible = true;
            this.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerPlaca M = new VerPlaca();
            M.Visible = true;
            this.Visible = false;
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            DataGridEliminarP.DataSource = TU.VerPlacas();
            try
            {
                CBEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
                CBEliminar.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT placa FROM carro", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    CBEliminar.Refresh();
                    CBEliminar.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            }
            catch (MySqlException f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
