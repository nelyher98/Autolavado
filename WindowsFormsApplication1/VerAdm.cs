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
    public partial class VerAdm : Form
    {
        TablaUsuario u = new TablaUsuario();
        public VerAdm()
        {
            InitializeComponent();
            DataAdministradores.DataSource = u.MostrarAdm();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuPropietario n = new MenuPropietario();
            this.Hide();
            n.Show();
        }

        private void btnSalirProp_Click(object sender, EventArgs e)
        {
            EliminarAd a = new EliminarAd();
            this.Hide();
            a.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoAdmi a = new NuevoAdmi();
            this.Hide();
            a.Show();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ModificarAdm a = new ModificarAdm();
            this.Hide();
            a.Show();
        }
    }
}
