namespace Autolavado
{
    partial class Actualizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizada));
            this.btnActualizada = new System.Windows.Forms.Button();
            this.lblActualizada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizada
            // 
            this.btnActualizada.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnActualizada.ForeColor = System.Drawing.Color.White;
            this.btnActualizada.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizada.Image")));
            this.btnActualizada.Location = new System.Drawing.Point(138, 108);
            this.btnActualizada.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizada.Name = "btnActualizada";
            this.btnActualizada.Size = new System.Drawing.Size(86, 32);
            this.btnActualizada.TabIndex = 0;
            this.btnActualizada.Text = "Hecho";
            this.btnActualizada.UseVisualStyleBackColor = true;
            this.btnActualizada.Click += new System.EventHandler(this.btnActualizada_Click);
            // 
            // lblActualizada
            // 
            this.lblActualizada.AutoSize = true;
            this.lblActualizada.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizada.Location = new System.Drawing.Point(17, 27);
            this.lblActualizada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualizada.Name = "lblActualizada";
            this.lblActualizada.Size = new System.Drawing.Size(192, 28);
            this.lblActualizada.TabIndex = 1;
            this.lblActualizada.Text = "Placa Actualizada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 24);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.btnActualizada);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 140);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.lblActualizada);
            this.panel3.Location = new System.Drawing.Point(64, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 86);
            this.panel3.TabIndex = 2;
            // 
            // Actualizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 152);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actualizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizada";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizada;
        private System.Windows.Forms.Label lblActualizada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}