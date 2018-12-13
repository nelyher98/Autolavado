namespace Autolavado
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 57);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Placas";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(17, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 52);
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
            this.panel2.Location = new System.Drawing.Point(-1, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 396);
            this.panel2.TabIndex = 29;
            // 
            // BtnMenu
            // 
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenu.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMenu.Location = new System.Drawing.Point(582, 321);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(115, 39);
            this.BtnMenu.TabIndex = 16;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNuevo.Image = global::Autolavado.Properties.Resources.button;
            this.BtnNuevo.Location = new System.Drawing.Point(241, 320);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 39);
            this.BtnNuevo.TabIndex = 15;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMod.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMod.Location = new System.Drawing.Point(73, 320);
            this.BtnMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(115, 39);
            this.BtnMod.TabIndex = 14;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.DataPlacas);
            this.panel4.Location = new System.Drawing.Point(36, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 300);
            this.panel4.TabIndex = 13;
            // 
            // DataPlacas
            // 
            this.DataPlacas.AllowUserToAddRows = false;
            this.DataPlacas.AllowUserToDeleteRows = false;
            this.DataPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPlacas.Location = new System.Drawing.Point(31, 23);
            this.DataPlacas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataPlacas.Name = "DataPlacas";
            this.DataPlacas.ReadOnly = true;
            this.DataPlacas.Size = new System.Drawing.Size(657, 244);
            this.DataPlacas.TabIndex = 0;
            // 
            // btnSalirProp
            // 
            this.btnSalirProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalirProp.Image = global::Autolavado.Properties.Resources.button1;
            this.btnSalirProp.Location = new System.Drawing.Point(409, 320);
            this.btnSalirProp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalirProp.Name = "btnSalirProp";
            this.btnSalirProp.Size = new System.Drawing.Size(115, 39);
            this.btnSalirProp.TabIndex = 12;
            this.btnSalirProp.Text = "Eliminar";
            this.btnSalirProp.UseVisualStyleBackColor = true;
            this.btnSalirProp.Click += new System.EventHandler(this.btnSalirProp_Click);
            // 
            // VerPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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