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
    public partial class Registro : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();

        public Registro()
        {
            InitializeComponent();
            CBTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTipo.Items.Add("Chico");
            CBTipo.Items.Add("Mediano");
            CBTipo.Items.Add("Grande");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            u.setPlaca(TxtPlaca.Text);
            u.setTipo(CBTipo.SelectedItem.ToString());
            u.setNombreEmp(TxtNombre.Text);
            u.setApellido(TxtApellidos.Text);
            u.setFecha(FechaData.Value.ToString("yyyy-MM-dd"));
            try
            {
                TU.InsertarPlac(u);
            }catch(MySqlException z)
            {
                MessageBox.Show(z.Message);
            }
            UsuarioRegistrado r = new UsuarioRegistrado();
            r.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VerPlaca M = new VerPlaca();
            M.Visible = true;
            this.Visible = false;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(sender, e);
        }
    }
}
