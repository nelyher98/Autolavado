namespace Autolavado
{
    partial class VerEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEmp = new System.Windows.Forms.Label();
            this.PanelFoto = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelD = new System.Windows.Forms.Panel();
            this.DataGridEmpleandos = new System.Windows.Forms.DataGridView();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpleandos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.LblEmp);
            this.panel1.Controls.Add(this.PanelFoto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 46);
            this.panel1.TabIndex = 22;
            // 
            // LblEmp
            // 
            this.LblEmp.AutoSize = true;
            this.LblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmp.ForeColor = System.Drawing.Color.White;
            this.LblEmp.Location = new System.Drawing.Point(93, 8);
            this.LblEmp.Name = "LblEmp";
            this.LblEmp.Size = new System.Drawing.Size(119, 25);
            this.LblEmp.TabIndex = 12;
            this.LblEmp.Text = "Empleados";
            // 
            // PanelFoto
            // 
            this.PanelFoto.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.PanelFoto.Location = new System.Drawing.Point(12, 3);
            this.PanelFoto.Name = "PanelFoto";
            this.PanelFoto.Size = new System.Drawing.Size(75, 42);
            this.PanelFoto.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.PanelD);
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnMod);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 320);
            this.panel2.TabIndex = 23;
            // 
            // PanelD
            // 
            this.PanelD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.PanelD.Controls.Add(this.DataGridEmpleandos);
            this.PanelD.Location = new System.Drawing.Point(27, 10);
            this.PanelD.Name = "PanelD";
            this.PanelD.Size = new System.Drawing.Size(536, 244);
            this.PanelD.TabIndex = 19;
            // 
            // DataGridEmpleandos
            // 
            this.DataGridEmpleandos.AllowUserToAddRows = false;
            this.DataGridEmpleandos.AllowUserToDeleteRows = false;
            this.DataGridEmpleandos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmpleandos.Location = new System.Drawing.Point(23, 19);
            this.DataGridEmpleandos.Name = "DataGridEmpleandos";
            this.DataGridEmpleandos.ReadOnly = true;
            this.DataGridEmpleandos.Size = new System.Drawing.Size(493, 198);
            this.DataGridEmpleandos.TabIndex = 0;
            // 
            // BtnMenu
            // 
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenu.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMenu.Location = new System.Drawing.Point(433, 260);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(86, 32);
            this.BtnMenu.TabIndex = 18;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = global::Autolavado.Properties.Resources.button1;
            this.BtnEliminar.Location = new System.Drawing.Point(307, 260);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 32);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNuevo.Image = global::Autolavado.Properties.Resources.button;
            this.BtnNuevo.Location = new System.Drawing.Point(181, 260);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(86, 32);
            this.BtnNuevo.TabIndex = 16;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMod.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMod.Location = new System.Drawing.Point(55, 260);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(86, 32);
            this.BtnMod.TabIndex = 15;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // VerEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Empleado";
            this.Load += new System.EventHandler(this.VerEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpleandos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEmp;
        private System.Windows.Forms.Panel PanelFoto;
        private System.Windows.Forms.Panel PanelD;
        private System.Windows.Forms.DataGridView DataGridEmpleandos;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnMod;
    }
}