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
    public partial class Actualizada : Form
    {
        public Actualizada()
        {
            InitializeComponent();
        }

        private void btnActualizada_Click(object sender, EventArgs e)
        {
            Actualizar n = new Actualizar();
            this.Hide();
            n.Show();
        }

    }
}
