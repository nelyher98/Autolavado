namespace Autolavado
{
    partial class EliminarProducto
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
            this.btnReg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBEliPro = new System.Windows.Forms.ComboBox();
            this.lblIdP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridEliminarP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElim
            // 
            this.btnElim.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnElim.Image = global::Autolavado.Properties.Resources.button__1_;
            this.btnElim.Location = new System.Drawing.Point(316, 287);
            this.btnElim.Margin = new System.Windows.Forms.Padding(2);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(86, 32);
            this.btnElim.TabIndex = 3;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnReg.Image = global::Autolavado.Properties.Resources.button1;
            this.btnReg.Location = new System.Drawing.Point(193, 287);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 32);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.LblEliminar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 46);
            this.panel1.TabIndex = 22;
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.ForeColor = System.Drawing.Color.White;
            this.LblEliminar.Location = new System.Drawing.Point(94, 8);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(181, 25);
            this.LblEliminar.TabIndex = 18;
            this.LblEliminar.Text = "Eliminar Producto";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel4.Location = new System.Drawing.Point(13, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 42);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.CBEliPro);
            this.panel2.Controls.Add(this.lblIdP);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.btnElim);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 331);
            this.panel2.TabIndex = 23;
            // 
            // CBEliPro
            // 
            this.CBEliPro.FormattingEnabled = true;
            this.CBEliPro.Location = new System.Drawing.Point(262, 245);
            this.CBEliPro.Name = "CBEliPro";
            this.CBEliPro.Size = new System.Drawing.Size(176, 21);
            this.CBEliPro.TabIndex = 23;
            // 
            // lblIdP
            // 
            this.lblIdP.AutoSize = true;
            this.lblIdP.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblIdP.Location = new System.Drawing.Point(189, 245);
            this.lblIdP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdP.Name = "lblIdP";
            this.lblIdP.Size = new System.Drawing.Size(68, 21);
            this.lblIdP.TabIndex = 22;
            this.lblIdP.Text = "Clave:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel3.Controls.Add(this.DataGridEliminarP);
            this.panel3.Location = new System.Drawing.Point(31, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 202);
            this.panel3.TabIndex = 21;
            // 
            // DataGridEliminarP
            // 
            this.DataGridEliminarP.AllowUserToAddRows = false;
            this.DataGridEliminarP.AllowUserToDeleteRows = false;
            this.DataGridEliminarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarP.Location = new System.Drawing.Point(23, 19);
            this.DataGridEliminarP.Name = "DataGridEliminarP";
            this.DataGridEliminarP.ReadOnly = true;
            this.DataGridEliminarP.Size = new System.Drawing.Size(490, 164);
            this.DataGridEliminarP.TabIndex = 0;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EliminarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGridEliminarP;
        private System.Windows.Forms.Label lblIdP;
        private System.Windows.Forms.ComboBox CBEliPro;
    }
}