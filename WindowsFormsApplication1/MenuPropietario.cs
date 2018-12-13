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
    public partial class MenuPropietario : Form
    {
        public MenuPropietario()
        {
            InitializeComponent();
        }
        private void btnSalirProp_Click(object sender, EventArgs e)
        {
            Login SalProp = new Login();
            SalProp.Visible = true;
            this.Visible = false;
        }


        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            Inv.Visible = true;
            this.Visible = false;
        }

        private void BtnInf_Click(object sender, EventArgs e)
        {
            Informe InfProp = new Informe();
            InfProp.Visible = true;
            this.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VerEmpleado VerEmp = new VerEmpleado();
            VerEmp.Visible = true;
            this.Visible = false;
        }

        private void BtnPlaca_Click(object sender, EventArgs e)
        {
            VerPlaca n = new VerPlaca();
            n.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VerAdm a = new VerAdm();
            this.Hide();
            a.Show();
        }

        private void BtnLavado_Click(object sender, EventArgs e)
        {
            Lavado n = new Lavado();
            this.Hide();
            n.Show();
        }
    }
}
