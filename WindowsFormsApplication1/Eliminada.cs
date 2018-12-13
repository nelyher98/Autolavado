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
    public partial class Eliminada : Form
    {
        public Eliminada()
        {
            InitializeComponent();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            Eliminar Elim = new Eliminar();
            Elim.Visible = true;
            this.Visible = false;
        }

        private void lblEliminada_Click(object sender, EventArgs e)
        {

        }
    }
}
