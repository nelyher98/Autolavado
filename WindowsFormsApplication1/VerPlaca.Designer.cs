﻿namespace Autolavado
{
    partial class VerPlaca
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataPlacas = new System.Windows.Forms.DataGridView();
            this.btnSalirProp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPlacas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 46);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Placas";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(13, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 42);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnMod);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnSalirProp);
            this.panel2.Location = new System.Drawing.Point(-1, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 322);
            this.panel2.TabIndex = 29;
            // 
            // BtnMenu
            // 
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenu.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMenu.Location = new System.Drawing.Point(433, 260);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(86, 32);
            this.BtnMenu.TabIndex = 16;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNuevo.Image = global::Autolavado.Properties.Resources.button;
            this.BtnNuevo.Location = new System.Drawing.Point(181, 260);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(86, 32);
            this.BtnNuevo.TabIndex = 15;
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
            this.BtnMod.TabIndex = 14;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.DataPlacas);
            this.panel4.Location = new System.Drawing.Point(27, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 244);
            this.panel4.TabIndex = 13;
            // 
            // DataPlacas
            // 
            this.DataPlacas.AllowUserToAddRows = false;
            this.DataPlacas.AllowUserToDeleteRows = false;
            this.DataPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPlacas.Location = new System.Drawing.Point(23, 19);
            this.DataPlacas.Name = "DataPlacas";
            this.DataPlacas.ReadOnly = true;
            this.DataPlacas.Size = new System.Drawing.Size(493, 198);
            this.DataPlacas.TabIndex = 0;
            // 
            // btnSalirProp
            // 
            this.btnSalirProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalirProp.Image = global::Autolavado.Properties.Resources.button1;
            this.btnSalirProp.Location = new System.Drawing.Point(307, 260);
            this.btnSalirProp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirProp.Name = "btnSalirProp";
            this.btnSalirProp.Size = new System.Drawing.Size(86, 32);
            this.btnSalirProp.TabIndex = 12;
            this.btnSalirProp.Text = "Eliminar";
            this.btnSalirProp.UseVisualStyleBackColor = true;
            this.btnSalirProp.Click += new System.EventHandler(this.btnSalirProp_Click);
            // 
            // VerPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPlaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerPlaca";
            this.Load += new System.EventHandler(this.VerPlaca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPlacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalirProp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DataPlacas;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnMod;
    }
}