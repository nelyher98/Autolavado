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
    public partial class ActualizarEmpleado : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public static int idUsuario;
        public ActualizarEmpleado()
        {
            InitializeComponent();
        }

        private void ActualizarEmpleado_Load(object sender, EventArgs e)
        {
            DataGridActualizarE.DataSource = TU.mostrarTablaUsuario();
            try {
                CombAEm.DropDownStyle = ComboBoxStyle.DropDownList;
                CombAEm.Text = "Id";
                CombAEm.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT id_empleado FROM empleado",conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()){
                    CombAEm.Refresh();
                    CombAEm.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            } catch (MySqlException h){
                MessageBox.Show(h.Message); }
        }

        //VERIFICATION
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtApellido.Text != "" && CombAEm.SelectedIndex > -1)
            {

                u.setNombreEmp(txtNombre.Text);
                u.setApellido(txtApellido.Text);
                idUsuario = Convert.ToInt32(CombAEm.SelectedItem.ToString());

                try
                {
                    TU.ActualizarEmp(u, idUsuario);
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
                MessageBox.Show("No se han  registrado algunos datos");
;            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerEmpleado MP = new VerEmpleado();
            MP.Visible = true;
            this.Visible = false;
        }

        private void CombAEm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int u;
            txtApellido.Text = "";
            txtNombre.Text = "";
            try
            {
                u = int.Parse(CombAEm.SelectedItem.ToString());
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT nombre,apellidos FROM empleado WHERE id_empleado="+u, conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txtNombre.Text = lector.GetString(0);
                    txtApellido.Text = lector.GetString(1);

                }
                conectar1.cerrarConexion();
            }
            catch(MySqlException r){
                MessageBox.Show(r.Message);
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
