﻿using System;
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
    public partial class VerPlaca : Form
    {
        Conexion conectar1 = new Conexion();
        Usuario u = new Usuario();
        TablaUsuario TU = new TablaUsuario();
        public VerPlaca()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuPropietario n = new MenuPropietario();
            this.Hide();
            n.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Registro n = new Registro();
            this.Hide();
            n.Show();
        }

        private void btnSalirProp_Click(object sender, EventArgs e)
        {
            Eliminar n = new Eliminar();
            this.Hide();
            n.Show();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            Actualizar n = new Actualizar();
            this.Hide();
            n.Show();
        }

        private void VerPlaca_Load(object sender, EventArgs e)
        {
            DataPlacas.DataSource = TU.VerPlacas();
        }
    }
}
