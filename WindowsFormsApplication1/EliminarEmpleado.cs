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
    public partial class EliminarEmpleado : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public static int idUsuario;
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void EliminarEmpleado_Load(object sender, EventArgs e)
        {
            DataGridEliminarE.DataSource = TU.mostrarTablaUsuario();
            try
            {
                CoEliEmpl.DropDownStyle = ComboBoxStyle.DropDownList;
                CoEliEmpl.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT id_empleado FROM empleado", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()) {
                    CoEliEmpl.Refresh();
                    CoEliEmpl.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
                }catch(MySqlException r){
                MessageBox.Show(r.Message);
            }
        }

        //VERIFICATION
        private void btnElim_Click(object sender, EventArgs e)
        {
            if (CoEliEmpl.SelectedIndex > -1)
            {
                idUsuario = Convert.ToInt32(CoEliEmpl.SelectedItem.ToString());
                TU.EliminarEmp(idUsuario);
                VerEmpleado n = new VerEmpleado();
                this.Hide();
                n.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un ID de empleado");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerEmpleado MP = new VerEmpleado();
            MP.Visible = true;
            this.Visible = false;
        }
    }
}
