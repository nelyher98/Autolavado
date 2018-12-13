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
    public partial class Inventario : Form
    {
        TablaUsuario t = new TablaUsuario();
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnMenuInv_Click(object sender, EventArgs e)
        {
            MenuPropietario M = new MenuPropietario();
            M.Visible = true;
            this.Visible = false;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            DataGridInventario.DataSource = t.mostrarInventario();

        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuPropietario n = new MenuPropietario();
            this.Hide();
            n.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            IngresarProducto n = new IngresarProducto();
            this.Hide();
            n.Show();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ActualizarProducto n = new ActualizarProducto();
            this.Hide();
            n.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto n = new EliminarProducto();
            this.Hide();
            n.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
