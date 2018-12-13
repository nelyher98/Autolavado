namespace Autolavado
{
    partial class Actualizar
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
            this.btnActual = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.FechaPlaca = new System.Windows.Forms.DateTimePicker();
            this.CBActualizarP = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DActualizarP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DActualizarP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActual
            // 
            this.btnActual.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnActual.Image = global::Autolavado.Properties.Resources.button__1_;
            this.btnActual.Location = new System.Drawing.Point(282, 287);
            this.btnActual.Margin = new System.Windows.Forms.Padding(2);
            this.btnActual.Name = "btnActual";
            this.btnActual.Size = new System.Drawing.Size(86, 32);
            this.btnActual.TabIndex = 0;
            this.btnActual.Text = "Actualizar";
            this.btnActual.UseVisualStyleBackColor = true;
            this.btnActual.Click += new System.EventHandler(this.btnActual_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnMenu.Image = global::Autolavado.Properties.Resources.button1;
            this.btnMenu.Location = new System.Drawing.Point(174, 287);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 32);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Regresar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.LblEmpleado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 49);
            this.panel1.TabIndex = 19;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.ForeColor = System.Drawing.Color.White;
            this.LblEmpleado.Location = new System.Drawing.Point(93, 8);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(167, 25);
            this.LblEmpleado.TabIndex = 20;
            this.LblEmpleado.Text = "Actualizar Placa";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 42);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.CBTipo);
            this.panel2.Controls.Add(this.FechaPlaca);
            this.panel2.Controls.Add(this.CBActualizarP);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.lblPlaca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnActual);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 331);
            this.panel2.TabIndex = 20;
            // 
            // CBTipo
            // 
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(255, 187);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(210, 21);
            this.CBTipo.TabIndex = 25;
            // 
            // FechaPlaca
            // 
            this.FechaPlaca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaPlaca.Location = new System.Drawing.Point(255, 238);
            this.FechaPlaca.Name = "FechaPlaca";
            this.FechaPlaca.Size = new System.Drawing.Size(210, 20);
            this.FechaPlaca.TabIndex = 24;
            // 
            // CBActualizarP
            // 
            this.CBActualizarP.FormattingEnabled = true;
            this.CBActualizarP.Location = new System.Drawing.Point(255, 161);
            this.CBActualizarP.Name = "CBActualizarP";
            this.CBActualizarP.Size = new System.Drawing.Size(210, 21);
            this.CBActualizarP.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(255, 211);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label1.Location = new System.Drawing.Point(39, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblTipo.Location = new System.Drawing.Point(39, 185);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(139, 21);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo de carro:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.lblPlaca.Location = new System.Drawing.Point(39, 161);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(66, 21);
            this.lblPlaca.TabIndex = 16;
            this.lblPlaca.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label2.Location = new System.Drawing.Point(39, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.DActualizarP);
            this.panel4.Location = new System.Drawing.Point(43, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 135);
            this.panel4.TabIndex = 15;
            // 
            // DActualizarP
            // 
            this.DActualizarP.AllowUserToAddRows = false;
            this.DActualizarP.AllowUserToDeleteRows = false;
            this.DActualizarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DActualizarP.Location = new System.Drawing.Point(20, 16);
            this.DActualizarP.Name = "DActualizarP";
            this.DActualizarP.ReadOnly = true;
            this.DActualizarP.Size = new System.Drawing.Size(477, 94);
            this.DActualizarP.TabIndex = 0;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Actualizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DActualizarP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActual;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DActualizarP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBActualizarP;
        private System.Windows.Forms.DateTimePicker FechaPlaca;
        private System.Windows.Forms.ComboBox CBTipo;
    }
}