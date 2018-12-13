namespace Autolavado
{
    partial class ActualizarProducto
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
            this.lblIdPro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnActPro = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBActualizar = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridActualizarP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridActualizarP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPro
            // 
            this.lblIdPro.AutoSize = true;
            this.lblIdPro.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblIdPro.Location = new System.Drawing.Point(49, 221);
            this.lblIdPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPro.Name = "lblIdPro";
            this.lblIdPro.Size = new System.Drawing.Size(119, 21);
            this.lblIdPro.TabIndex = 1;
            this.lblIdPro.Text = "IdProducto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblNombre.Location = new System.Drawing.Point(49, 247);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblMarca.Location = new System.Drawing.Point(49, 271);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(102, 21);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblPrecio.Location = new System.Drawing.Point(49, 298);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 21);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(176, 248);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(176, 275);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(143, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(176, 299);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnActPro
            // 
            this.btnActPro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnActPro.Image = global::Autolavado.Properties.Resources.button__1_;
            this.btnActPro.Location = new System.Drawing.Point(480, 287);
            this.btnActPro.Margin = new System.Windows.Forms.Padding(2);
            this.btnActPro.Name = "btnActPro";
            this.btnActPro.Size = new System.Drawing.Size(86, 32);
            this.btnActPro.TabIndex = 9;
            this.btnActPro.Text = "Actualizar";
            this.btnActPro.UseVisualStyleBackColor = true;
            this.btnActPro.Click += new System.EventHandler(this.btnActPro_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnReg.Image = global::Autolavado.Properties.Resources.button1;
            this.btnReg.Location = new System.Drawing.Point(379, 288);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 32);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 46);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Actualizar Producto";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel4.Location = new System.Drawing.Point(13, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 42);
            this.panel4.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.CBActualizar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblIdPro);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.btnActPro);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.lblMarca);
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Location = new System.Drawing.Point(-1, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 331);
            this.panel2.TabIndex = 23;
            // 
            // CBActualizar
            // 
            this.CBActualizar.FormattingEnabled = true;
            this.CBActualizar.Location = new System.Drawing.Point(176, 221);
            this.CBActualizar.Name = "CBActualizar";
            this.CBActualizar.Size = new System.Drawing.Size(143, 21);
            this.CBActualizar.TabIndex = 16;
            this.CBActualizar.SelectionChangeCommitted += new System.EventHandler(this.CBActualizar_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel3.Controls.Add(this.DataGridActualizarP);
            this.panel3.Location = new System.Drawing.Point(30, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 202);
            this.panel3.TabIndex = 15;
            // 
            // DataGridActualizarP
            // 
            this.DataGridActualizarP.AllowUserToAddRows = false;
            this.DataGridActualizarP.AllowUserToDeleteRows = false;
            this.DataGridActualizarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridActualizarP.Location = new System.Drawing.Point(23, 19);
            this.DataGridActualizarP.Name = "DataGridActualizarP";
            this.DataGridActualizarP.ReadOnly = true;
            this.DataGridActualizarP.Size = new System.Drawing.Size(493, 162);
            this.DataGridActualizarP.TabIndex = 0;
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActualizarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarProducto";
            this.Load += new System.EventHandler(this.ActualizarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridActualizarP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIdPro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnActPro;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGridActualizarP;
        private System.Windows.Forms.ComboBox CBActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}