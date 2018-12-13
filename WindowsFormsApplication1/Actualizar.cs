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
    public partial class Actualizar : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public Actualizar()
        {
            InitializeComponent();
            CBTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTipo.Items.Add("Chico");
            CBTipo.Items.Add("Mediano");
            CBTipo.Items.Add("Grande");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerPlaca M = new VerPlaca();
            M.Visible = true;
            this.Visible = false;
        }

        private void btnActual_Click(object sender, EventArgs e)
        {
            if (CBTipo.SelectedIndex > -1 || txtNombre.Text != "")
            {
                string p;
                p = CBActualizarP.SelectedItem.ToString();
                u.setTipo(CBTipo.SelectedItem.ToString());
                u.setNombreEmp(txtNombre.Text);
                u.setFecha(FechaPlaca.Value.ToString("yyyy-MM-dd"));
                TU.ActualizarPlac(u, p);
                Actualizada Act = new Actualizada();
                Act.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("No se han ingresado todos los datos");
            }
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
            DActualizarP.DataSource = TU.VerPlacas();
            try {
                CBActualizarP.DropDownStyle = ComboBoxStyle.DropDownList;
                CBActualizarP.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT placa FROM carro",conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()){
                    CBActualizarP.Refresh();
                    CBActualizarP.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            } catch(MySqlException f){
                MessageBox.Show(f.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }
    }
}
