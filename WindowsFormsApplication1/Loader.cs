using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolavado
{
   
    public partial class Loader : Form
    {
        public int valor = 0;
        public Loader()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (valor != 100)
            {
                this.Barradecarga.Increment(2);
                valor = this.Barradecarga.Value;
                LblPorceso.Text = valor.ToString() + " %";
            }
            else
            {
                Thread.Sleep(1000);
                MenuPropietario l = new MenuPropietario();
                l.Show();
                this.Visible = false;
                this.timer1.Stop();
            }
        
    }

        private void Barradecarga_Click(object sender, EventArgs e)
        {

        }
    }
}
