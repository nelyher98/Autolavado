namespace Autolavado
{
    partial class Eliminada
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
            this.lblEliminada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnElim
            // 
            this.btnElim.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElim.Image = global::Autolavado.Properties.Resources.button;
            this.btnElim.Location = new System.Drawing.Point(129, 97);
            this.btnElim.Margin = new System.Windows.Forms.Padding(2);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(86, 32);
            this.btnElim.TabIndex = 0;
            this.btnElim.Text = "Hecho";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // lblEliminada
            // 
            this.lblEliminada.AutoSize = true;
            this.lblEliminada.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.lblEliminada.ForeColor = System.Drawing.Color.Black;
            this.lblEliminada.Location = new System.Drawing.Point(23, 19);
            this.lblEliminada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminada.Name = "lblEliminada";
            this.lblEliminada.Size = new System.Drawing.Size(173, 28);
            this.lblEliminada.TabIndex = 1;
            this.lblEliminada.Text = "Placa Eliminada";
            this.lblEliminada.Click += new System.EventHandler(this.lblEliminada_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 24);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.btnElim);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 140);
            this.panel2.TabIndex = 23;
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
            // Eliminada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 152);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Eliminada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminada";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Label lblEliminada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}