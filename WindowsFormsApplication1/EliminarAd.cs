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
    public partial class EliminarAd : Form
    {
        TablaUsuario u = new TablaUsuario();
        Conexion conectar1 = new Conexion();
        TablaUsuario t = new TablaUsuario();
        public EliminarAd()
        {
            InitializeComponent();
            DataGridEliminarP.DataSource= u.MostrarAdm();
            try
            {
                CBEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
                CBEliminar.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT usuario FROM encargado", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    CBEliminar.Refresh();
                    CBEliminar.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            }
            catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerAdm n = new VerAdm();
            this.Hide();
            n.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = CBEliminar.SelectedItem.ToString();
            t.EliminarAdm(id);
            VerAdm n = new VerAdm();
            this.Hide();
            n.Show();
        }
    }
}
