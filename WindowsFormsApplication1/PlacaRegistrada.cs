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
    public partial class PlacaRegistrada : Form
    {
        public PlacaRegistrada()
        {
            InitializeComponent();
        }

        private void btnActualizada_Click(object sender, EventArgs e)
        {
            Registro Reg = new Registro();
            Reg.Visible = true;
            this.Visible = false;
        }
    }
}
