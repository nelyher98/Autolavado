namespace Autolavado
{
    partial class UsuarioInvalido
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnElim = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEliminada = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 24);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.btnElim);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 142);
            this.panel2.TabIndex = 25;
            // 
            // btnElim
            // 
            this.btnElim.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnElim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnElim.Image = global::Autolavado.Properties.Resources.button;
            this.btnElim.Location = new System.Drawing.Point(129, 97);
            this.btnElim.Margin = new System.Windows.Forms.Padding(2);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(86, 32);
            this.btnElim.TabIndex = 0;
            this.btnElim.Text = "Hecho";
            this.btnElim.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(162)))));
            this.panel3.Controls.Add(this.lblEliminada);
            this.panel3.Location = new System.Drawing.Point(72, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 74);
            this.panel3.TabIndex = 2;
            // 
            // lblEliminada
            // 
            this.lblEliminada.AutoSize = true;
            this.lblEliminada.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.lblEliminada.ForeColor = System.Drawing.Color.Black;
            this.lblEliminada.Location = new System.Drawing.Point(23, 19);
            this.lblEliminada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminada.Name = "lblEliminada";
            this.lblEliminada.Size = new System.Drawing.Size(179, 28);
            this.lblEliminada.TabIndex = 1;
            this.lblEliminada.Text = "Usuario Invalido";
            // 
            // UsuarioInvalido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 153);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioInvalido";
            this.Text = "Usuario Inválido";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEliminada;
    }
}