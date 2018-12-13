namespace Autolavado
{
    partial class Lavado
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
            this.TxtLavado = new System.Windows.Forms.TextBox();
            this.TxtPulido = new System.Windows.Forms.TextBox();
            this.TxtEncerado = new System.Windows.Forms.TextBox();
            this.TxtLavadoM = new System.Windows.Forms.TextBox();
            this.LavadoMotorCheck = new System.Windows.Forms.CheckBox();
            this.EnceradoCheck = new System.Windows.Forms.CheckBox();
            this.PulidoCheck = new System.Windows.Forms.CheckBox();
            this.LavadoCheck = new System.Windows.Forms.CheckBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComBLavador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComBPlacas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.btnSalirProp = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.TxtLavado);
            this.panel4.Controls.Add(this.TxtPulido);
            this.panel4.Controls.Add(this.TxtEncerado);
            this.panel4.Controls.Add(this.TxtLavadoM);
            this.panel4.Controls.Add(this.LavadoMotorCheck);
            this.panel4.Controls.Add(this.EnceradoCheck);
            this.panel4.Controls.Add(this.PulidoCheck);
            this.panel4.Controls.Add(this.LavadoCheck);
            this.panel4.Controls.Add(this.TxtTotal);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.ComBLavador);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.ComBPlacas);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(36, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 300);
            this.panel4.TabIndex = 15;
            // 
            // TxtLavado
            // 
            this.TxtLavado.Location = new System.Drawing.Point(268, 145);
            this.TxtLavado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLavado.Name = "TxtLavado";
            this.TxtLavado.Size = new System.Drawing.Size(163, 22);
            this.TxtLavado.TabIndex = 40;
            this.TxtLavado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLavado_KeyPress);
            // 
            // TxtPulido
            // 
            this.TxtPulido.Location = new System.Drawing.Point(268, 177);
            this.TxtPulido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPulido.Name = "TxtPulido";
            this.TxtPulido.Size = new System.Drawing.Size(163, 22);
            this.TxtPulido.TabIndex = 39;
            this.TxtPulido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPulido_KeyPress);
            // 
            // TxtEncerado
            // 
            this.TxtEncerado.Location = new System.Drawing.Point(268, 209);
            this.TxtEncerado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEncerado.Name = "TxtEncerado";
            this.TxtEncerado.Size = new System.Drawing.Size(163, 22);
            this.TxtEncerado.TabIndex = 38;
            this.TxtEncerado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEncerado_KeyPress);
            // 
            // TxtLavadoM
            // 
            this.TxtLavadoM.Location = new System.Drawing.Point(268, 241);
            this.TxtLavadoM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLavadoM.Name = "TxtLavadoM";
            this.TxtLavadoM.Size = new System.Drawing.Size(163, 22);
            this.TxtLavadoM.TabIndex = 37;
            this.TxtLavadoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLavadoM_KeyPress);
            // 
            // LavadoMotorCheck
            // 
            this.LavadoMotorCheck.AutoSize = true;
            this.LavadoMotorCheck.Location = new System.Drawing.Point(96, 241);
            this.LavadoMotorCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LavadoMotorCheck.Name = "LavadoMotorCheck";
            this.LavadoMotorCheck.Size = new System.Drawing.Size(137, 21);
            this.LavadoMotorCheck.TabIndex = 36;
            this.LavadoMotorCheck.Text = "Lavado de Motor";
            this.LavadoMotorCheck.UseVisualStyleBackColor = true;
            this.LavadoMotorCheck.CheckedChanged += new System.EventHandler(this.LavadoCheck_CheckedChanged);
            // 
            // EnceradoCheck
            // 
            this.EnceradoCheck.AutoSize = true;
            this.EnceradoCheck.Location = new System.Drawing.Point(96, 209);
            this.EnceradoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnceradoCheck.Name = "EnceradoCheck";
            this.EnceradoCheck.Size = new System.Drawing.Size(91, 21);
            this.EnceradoCheck.TabIndex = 35;
            this.EnceradoCheck.Text = "Encerado";
            this.EnceradoCheck.UseVisualStyleBackColor = true;
            this.EnceradoCheck.CheckedChanged += new System.EventHandler(this.LavadoCheck_CheckedChanged);
            // 
            // PulidoCheck
            // 
            this.PulidoCheck.AutoSize = true;
            this.PulidoCheck.Location = new System.Drawing.Point(96, 177);
            this.PulidoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PulidoCheck.Name = "PulidoCheck";
            this.PulidoCheck.Size = new System.Drawing.Size(69, 21);
            this.PulidoCheck.TabIndex = 34;
            this.PulidoCheck.Text = "Pulido";
            this.PulidoCheck.UseVisualStyleBackColor = true;
            this.PulidoCheck.CheckedChanged += new System.EventHandler(this.LavadoCheck_CheckedChanged);
            // 
            // LavadoCheck
            // 
            this.LavadoCheck.AutoSize = true;
            this.LavadoCheck.Location = new System.Drawing.Point(96, 149);
            this.LavadoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LavadoCheck.Name = "LavadoCheck";
            this.LavadoCheck.Size = new System.Drawing.Size(77, 21);
            this.LavadoCheck.TabIndex = 33;
            this.LavadoCheck.Text = "Lavado";
            this.LavadoCheck.UseVisualStyleBackColor = true;
            this.LavadoCheck.CheckedChanged += new System.EventHandler(this.LavadoCheck_CheckedChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(533, 256);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(163, 22);
            this.TxtTotal.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(451, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total:";
            // 
            // ComBLavador
            // 
            this.ComBLavador.FormattingEnabled = true;
            this.ComBLavador.Location = new System.Drawing.Point(268, 81);
            this.ComBLavador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBLavador.Name = "ComBLavador";
            this.ComBLavador.Size = new System.Drawing.Size(292, 24);
            this.ComBLavador.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(137, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lavador:";
            // 
            // ComBPlacas
            // 
            this.ComBPlacas.FormattingEnabled = true;
            this.ComBPlacas.Location = new System.Drawing.Point(268, 20);
            this.ComBPlacas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBPlacas.Name = "ComBPlacas";
            this.ComBPlacas.Size = new System.Drawing.Size(292, 24);
            this.ComBPlacas.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(317, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Servicios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Placa:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nuevo Lavado";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Autolavado.Properties.Resources.Logopaginas;
            this.panel3.Location = new System.Drawing.Point(17, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 52);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.btnSalirProp);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-4, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 396);
            this.panel2.TabIndex = 27;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::Autolavado.Properties.Resources.button__1_;
            this.BtnNuevo.Location = new System.Drawing.Point(592, 341);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 39);
            this.BtnNuevo.TabIndex = 19;
            this.BtnNuevo.Text = "Ejecutar";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnSalirProp
            // 
            this.btnSalirProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalirProp.Image = global::Autolavado.Properties.Resources.button1;
            this.btnSalirProp.Location = new System.Drawing.Point(456, 341);
            this.btnSalirProp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalirProp.Name = "btnSalirProp";
            this.btnSalirProp.Size = new System.Drawing.Size(115, 39);
            this.btnSalirProp.TabIndex = 17;
            this.btnSalirProp.Text = "Cancelar";
            this.btnSalirProp.UseVisualStyleBackColor = true;
            this.btnSalirProp.Click += new System.EventHandler(this.btnSalirProp_Click);
            // 
            // Lavado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lavado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lavado";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button btnSalirProp;
        private System.Windows.Forms.ComboBox ComBPlacas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComBLavador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPulido;
        private System.Windows.Forms.TextBox TxtEncerado;
        private System.Windows.Forms.TextBox TxtLavadoM;
        private System.Windows.Forms.CheckBox LavadoMotorCheck;
        private System.Windows.Forms.CheckBox EnceradoCheck;
        private System.Windows.Forms.CheckBox PulidoCheck;
        private System.Windows.Forms.CheckBox LavadoCheck;
        private System.Windows.Forms.TextBox TxtLavado;
    }
}