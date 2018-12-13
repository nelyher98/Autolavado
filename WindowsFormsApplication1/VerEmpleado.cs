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
    public partial class VerEmpleado : Form
    {
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public VerEmpleado()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarEmpleado IngEmp = new IngresarEmpleado();
            IngEmp.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPropietario MP = new MenuPropietario();
            MP.Visible = true;
            this.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado ElimEmp = new EliminarEmpleado();
            ElimEmp.Visible = true;
            this.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado ActEmp = new ActualizarEmpleado();
            ActEmp.Visible = true;
            this.Visible = false;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuPropietario n = new MenuPropietario();
            this.Hide();
            n.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            IngresarEmpleado n = new IngresarEmpleado();
            this.Hide();
            n.Show();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            EliminarEmpleado n = new EliminarEmpleado();
            this.Hide();
            n.Show();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado n = new ActualizarEmpleado();
            this.Hide();
            n.Show();
        }
     
        private void VerEmpleado_Load(object sender, EventArgs e)
        {
            DataGridEmpleandos.DataSource = TU.mostrarTablaUsuario();
        }
    }
}
