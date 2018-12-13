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
    public partial class UsuarioRegistrado : Form
    {
        public UsuarioRegistrado()
        {
            InitializeComponent();
        }

        private void UsuarioRegistrado_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizada_Click(object sender, EventArgs e)
        {
            VerPlaca w = new VerPlaca();
            this.Hide();
            w.Show();
        }
    }
}
