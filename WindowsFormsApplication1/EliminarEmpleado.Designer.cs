namespace Autolavado
{
    partial class EliminarEmpleado
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
            this.btnElim = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoEliEmpl = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridEliminarE = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElim
            // 
            this.btnElim.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnElim.Image = global::Autolavado.Properties.Resources.button__1_;
            this.btnElim.Location = new System.Drawing.Point(303, 286);
            this.btnElim.Margin = new System.Windows.Forms.Padding(2);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(86, 32);
            this.btnElim.TabIndex = 3;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnMenu.Image = global::Autolavado.Properties.Resources.button1;
            this.btnMenu.Location = new System.Drawing.Point(199, 286);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 32);
            this.btnMenu.TabIndex = 4;
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
            this.panel1.Size = new System.Drawing.Size(596, 46);
            this.panel1.TabIndex = 22;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.ForeColor = System.Drawing.Color.White;
            this.LblEmpleado.Location = new System.Drawing.Point(94, 9);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(191, 25);
            this.LblEmpleado.TabIndex = 16;
            this.LblEmpleado.Text = "Eliminar Empleado";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(13, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 42);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.CoEliEmpl);
            this.panel2.Controls.Add(this.lblProducto);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnElim);
            this.panel2.Location = new System.Drawing.Point(-1, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 330);
            this.panel2.TabIndex = 23;
            // 
            // CoEliEmpl
            // 
            this.CoEliEmpl.FormattingEnabled = true;
            this.CoEliEmpl.Location = new System.Drawing.Point(268, 243);
            this.CoEliEmpl.Name = "CoEliEmpl";
            this.CoEliEmpl.Size = new System.Drawing.Size(135, 21);
            this.CoEliEmpl.TabIndex = 25;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblProducto.Location = new System.Drawing.Point(136, 243);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(128, 21);
            this.lblProducto.TabIndex = 24;
            this.lblProducto.Text = "IdEmpleado:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.DataGridEliminarE);
            this.panel4.Location = new System.Drawing.Point(32, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 206);
            this.panel4.TabIndex = 20;
            // 
            // DataGridEliminarE
            // 
            this.DataGridEliminarE.AllowUserToAddRows = false;
            this.DataGridEliminarE.AllowUserToDeleteRows = false;
            this.DataGridEliminarE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarE.Location = new System.Drawing.Point(23, 19);
            this.DataGridEliminarE.Name = "DataGridEliminarE";
            this.DataGridEliminarE.ReadOnly = true;
            this.DataGridEliminarE.Size = new System.Drawing.Size(477, 166);
            this.DataGridEliminarE.TabIndex = 0;
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EliminarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Empleado";
            this.Load += new System.EventHandler(this.EliminarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DataGridEliminarE;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox CoEliEmpl;
    }
}