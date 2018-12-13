using MySql.Data.MySqlClient;
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
    public partial class Lavado : Form
    {
        float t;
        float q, r, a, y;
        string f;
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario x = new TablaUsuario();

       
        private void LavadoCheck_CheckedChanged(object sender, EventArgs e)
        {
            TxtEncerado.Enabled = false;
            TxtPulido.Enabled = false;
            TxtLavadoM.Enabled = false;
            TxtLavado.Enabled = false;
            TxtTotal.Enabled = false;


            if (LavadoCheck.Checked == true)
            {
                TxtLavado.Enabled = true;
                TxtLavado.ReadOnly = false;
            }
            if (PulidoCheck.Checked == true)
            {
                TxtPulido.Enabled = true;
                TxtPulido.ReadOnly = false;
            }
            if (EnceradoCheck.Checked == true)
            {
                TxtEncerado.Enabled = true;
                TxtEncerado.ReadOnly = false;
            }
            if (LavadoMotorCheck.Checked == true)
            {
                TxtLavadoM.Enabled = true;
                TxtLavadoM.ReadOnly = false;
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (ComBPlacas.SelectedIndex > -1 || ComBLavador.SelectedIndex > -1)
            {
                if (LavadoCheck.Checked == true)
                {
                    x.g = "Lavado_Normal";
                }
                else
                {
                    x.g = "";
                }
                if (PulidoCheck.Checked == true)
                {
                    x.h = "Pulido";
                }
                else
                {
                    x.h = "";
                }
                if (EnceradoCheck.Checked == true)
                {
                    x.z = "Encerado";
                }
                else
                {
                    x.z = "";
                }
                if (LavadoMotorCheck.Checked == true)
                {
                    x.q = "Lavado_Motor";
                }
                else
                {
                    x.q = "";
                }
                if (TxtLavado.Text != "") { q = float.Parse(TxtLavado.Text); }
                if (TxtPulido.Text != "") { a = float.Parse(TxtPulido.Text); }
                if (TxtEncerado.Text != "") { r = float.Parse(TxtEncerado.Text); }
                if (TxtLavadoM.Text != "") { y = float.Parse(TxtLavadoM.Text); }

                t = q + a + r + y;

                //CHECKING OUT WHETHER THIS WORKS OR NOT
                MessageBox.Show("Total =" + t.ToString());

                f = Convert.ToString(t);

                TxtTotal.Text = f;
                u.setNombreEmp(ComBLavador.SelectedItem.ToString());
                u.setPlaca(ComBPlacas.SelectedItem.ToString());
                u.setPrecio(t);
                x.InsertarTicket(u);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un empleado o una placa");
            }
        }

        public Lavado()
        {
            InitializeComponent();
            CBPlaca();
            CBEmpleado();
            TxtLavado.ReadOnly = true;
            TxtPulido.ReadOnly = true;
            TxtLavadoM.ReadOnly = true;
            TxtEncerado.ReadOnly = true;
        }

        private void TxtLavado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void TxtPulido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void TxtEncerado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void TxtLavadoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(sender, e);
        }

        private void btnSalirProp_Click(object sender, EventArgs e)
        {
            MenuPropietario n = new MenuPropietario();
            this.Hide();
            n.Show();
        }
        private void CBPlaca()
        {
            try
            {
                ComBPlacas.DropDownStyle = ComboBoxStyle.DropDownList;
                ComBPlacas.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT placa FROM carro", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ComBPlacas.Refresh();
                    ComBPlacas.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.ToString());
            }
        }
        public void CBEmpleado()
        {
            try
            {
                ComBLavador.DropDownStyle = ComboBoxStyle.DropDownList;
                ComBLavador.Items.Clear();
                conectar1.conectar();
                conectar1.abrirConexion();
                MySqlCommand comando = new MySqlCommand("SELECT nombre FROM Empleado", conectar1.getconexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ComBLavador.Refresh();
                    ComBLavador.Items.Add(lector.GetValue(0).ToString());
                }
                conectar1.cerrarConexion();
            }catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
    }
}
