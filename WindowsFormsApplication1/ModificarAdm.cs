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
    public partial class ModificarAdm : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario q = new Usuario();
        TablaUsuario u = new TablaUsuario();
        public ModificarAdm()
        {
            InitializeComponent();
            DataGridActualizarE.DataSource = u.MostrarAdm();
            try
            {
                CombAEm.DropDownStyle = ComboBoxStyle.DropDownList;
                CombAEm.Text = "Id";
                CombAEm.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT usuario FROM encargado", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    CombAEm.Refresh();
                    CombAEm.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();

            }
            catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerAdm n = new VerAdm();
            this.Hide();
            n.Show();
        }

        private void CombAEm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string g;
            try
            {
                g = CombAEm.SelectedItem.ToString();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT contraseña,nombre,apellidos FROM encargado WHERE usuario ='"+g+"'", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txtNombre.Text = lector.GetString(0);
                    txtApellido.Text = lector.GetString(1);
                    TxtContra.Text = lector.GetString(2);
                }
                conectar1.cerrarConexion();
            }
            catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }


        //VERIFICATION
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (CombAEm.SelectedIndex > -1 && TxtContra.Text != "" && txtNombre.Text != "" && txtApellido.Text != "")
            {
                string g;
                g = CombAEm.SelectedItem.ToString();
                q.setContraseña(TxtContra.Text);
                q.setNombreEmp(txtNombre.Text);
                q.setApellido(txtApellido.Text);
                try
                {
                    u.ActualizaAdnm(q, g);
                } catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
                VerAdm n = new VerAdm();
                this.Hide();
                n.Show();
            }
            else
            {
                MessageBox.Show("No se han ingresado todos los datos");
            }
        }
    }
}
