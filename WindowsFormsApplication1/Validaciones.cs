using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolavado
{
    class Validaciones
    {
        public static void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void SoloNumeros(object sender, KeyPressEventArgs r)
        {
            if (char.IsDigit(r.KeyChar))
            {
                r.Handled = false;
            }
            else if (char.IsSeparator(r.KeyChar))
            {
                r.Handled = false;
            }
            else if (Char.IsControl(r.KeyChar))
            {
                r.Handled = false;
            }
            else
            {
                r.Handled = true;
            }
        }
        public static void NumeroDecimal(object sender, KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
         }
    }
}
