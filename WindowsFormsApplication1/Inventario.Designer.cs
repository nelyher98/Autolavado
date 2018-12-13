namespace Autolavado
{
    partial class Inventario
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridInventario = new System.Windows.Forms.DataGridView();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 57);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventario";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel4.Location = new System.Drawing.Point(17, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 52);
            this.panel4.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnMod);
            this.panel2.Location = new System.Drawing.Point(-1, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 396);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel3.Controls.Add(this.DataGridInventario);
            this.panel3.Location = new System.Drawing.Point(36, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 300);
            this.panel3.TabIndex = 14;
            // 
            // DataGridInventario
            // 
            this.DataGridInventario.AllowUserToAddRows = false;
            this.DataGridInventario.AllowUserToDeleteRows = false;
            this.DataGridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridInventario.Location = new System.Drawing.Point(31, 23);
            this.DataGridInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridInventario.Name = "DataGridInventario";
            this.DataGridInventario.ReadOnly = true;
            this.DataGridInventario.Size = new System.Drawing.Size(657, 244);
            this.DataGridInventario.TabIndex = 0;
            // 
            // BtnMenu
            // 
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMenu.Image = global::Autolavado.Properties.Resources.button;
            this.BtnMenu.Location = new System.Drawing.Point(577, 320);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(115, 39);
            this.BtnMenu.TabIndex = 5;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = global::Autolavado.Properties.Resources.button1;
            this.BtnEliminar.Location = new System.Drawing.Point(409, 320);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 39);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNuevo.Image = global::Autolavado.Properties.Resources.button;
            this.BtnNuevo.Location = new System.Drawing.Point(241, 320);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 39);
            this.BtnNuevo.TabIndex = 3;
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
            this.BtnMod.TabIndex = 2;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGridInventario;
    }
}