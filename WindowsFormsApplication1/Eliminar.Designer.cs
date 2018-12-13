namespace Autolavado
{
    partial class Eliminar
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBEliminar = new System.Windows.Forms.ComboBox();
            this.Placa = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridEliminarP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnEliminar.Image = global::Autolavado.Properties.Resources.button__1_;
            this.btnEliminar.Location = new System.Drawing.Point(331, 278);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 32);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnMenu.Image = global::Autolavado.Properties.Resources.button1;
            this.btnMenu.Location = new System.Drawing.Point(224, 278);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 32);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Regresar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.LblEmpleado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 49);
            this.panel1.TabIndex = 22;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.ForeColor = System.Drawing.Color.White;
            this.LblEmpleado.Location = new System.Drawing.Point(94, 12);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(149, 25);
            this.LblEmpleado.TabIndex = 18;
            this.LblEmpleado.Text = "Eliminar Placa";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(13, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 42);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.CBEliminar);
            this.panel2.Controls.Add(this.Placa);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(-1, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 322);
            this.panel2.TabIndex = 23;
            // 
            // CBEliminar
            // 
            this.CBEliminar.FormattingEnabled = true;
            this.CBEliminar.Location = new System.Drawing.Point(258, 232);
            this.CBEliminar.Name = "CBEliminar";
            this.CBEliminar.Size = new System.Drawing.Size(159, 21);
            this.CBEliminar.TabIndex = 27;
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.Placa.Location = new System.Drawing.Point(186, 233);
            this.Placa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(66, 21);
            this.Placa.TabIndex = 26;
            this.Placa.Text = "Placa:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.DataGridEliminarP);
            this.panel4.Location = new System.Drawing.Point(32, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 206);
            this.panel4.TabIndex = 14;
            // 
            // DataGridEliminarP
            // 
            this.DataGridEliminarP.AllowUserToAddRows = false;
            this.DataGridEliminarP.AllowUserToDeleteRows = false;
            this.DataGridEliminarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarP.Location = new System.Drawing.Point(20, 16);
            this.DataGridEliminarP.Name = "DataGridEliminarP";
            this.DataGridEliminarP.ReadOnly = true;
            this.DataGridEliminarP.Size = new System.Drawing.Size(477, 166);
            this.DataGridEliminarP.TabIndex = 0;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DataGridEliminarP;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.ComboBox CBEliminar;
    }
}