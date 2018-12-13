namespace Autolavado
{
    partial class VerAdm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataAdministradores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.btnSalirProp = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataAdministradores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.DataAdministradores);
            this.panel4.Location = new System.Drawing.Point(27, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 244);
            this.panel4.TabIndex = 15;
            // 
            // DataAdministradores
            // 
            this.DataAdministradores.AllowUserToAddRows = false;
            this.DataAdministradores.AllowUserToDeleteRows = false;
            this.DataAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAdministradores.Location = new System.Drawing.Point(23, 19);
            this.DataAdministradores.Name = "DataAdministradores";
            this.DataAdministradores.ReadOnly = true;
            this.DataAdministradores.Size = new System.Drawing.Size(493, 198);
            this.DataAdministradores.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 46);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Administradores";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(13, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 42);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnMod);
            this.panel2.Controls.Add(this.btnSalirProp);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 322);
            this.panel2.TabIndex = 25;
            // 
            // BtnMenu
            // 
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMenu.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMenu.Location = new System.Drawing.Point(442, 260);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(86, 32);
            this.BtnMenu.TabIndex = 20;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNuevo.Image = global::Autolavado.Properties.Resources.button;
            this.BtnNuevo.Location = new System.Drawing.Point(190, 260);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(86, 32);
            this.BtnNuevo.TabIndex = 19;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMod.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMod.Location = new System.Drawing.Point(64, 260);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(86, 32);
            this.BtnMod.TabIndex = 18;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // btnSalirProp
            // 
            this.btnSalirProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalirProp.Image = global::Autolavado.Properties.Resources.button1;
            this.btnSalirProp.Location = new System.Drawing.Point(316, 260);
            this.btnSalirProp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirProp.Name = "btnSalirProp";
            this.btnSalirProp.Size = new System.Drawing.Size(86, 32);
            this.btnSalirProp.TabIndex = 17;
            this.btnSalirProp.Text = "Eliminar";
            this.btnSalirProp.UseVisualStyleBackColor = true;
            this.btnSalirProp.Click += new System.EventHandler(this.btnSalirProp_Click);
            // 
            // VerAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerAdm";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataAdministradores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DataAdministradores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button btnSalirProp;
    }
}