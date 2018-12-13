namespace Autolavado
{
    partial class Loader
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
            this.components = new System.ComponentModel.Container();
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.Barradecarga = new System.Windows.Forms.ProgressBar();
            this.LblPorceso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            this.SuspendLayout();
            // 
            // Img1
            // 
            this.Img1.Image = global::Autolavado.Properties.Resources.IMG_20180731_WA00091;
            this.Img1.Location = new System.Drawing.Point(0, -5);
            this.Img1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Img1.Name = "Img1";
            this.Img1.Size = new System.Drawing.Size(381, 256);
            this.Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img1.TabIndex = 0;
            this.Img1.TabStop = false;
            // 
            // Barradecarga
            // 
            this.Barradecarga.Location = new System.Drawing.Point(0, 258);
            this.Barradecarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Barradecarga.Name = "Barradecarga";
            this.Barradecarga.Size = new System.Drawing.Size(381, 49);
            this.Barradecarga.TabIndex = 1;
            this.Barradecarga.Click += new System.EventHandler(this.Barradecarga_Click);
            // 
            // LblPorceso
            // 
            this.LblPorceso.AutoSize = true;
            this.LblPorceso.Location = new System.Drawing.Point(159, 290);
            this.LblPorceso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPorceso.Name = "LblPorceso";
            this.LblPorceso.Size = new System.Drawing.Size(0, 17);
            this.LblPorceso.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.ControlBox = false;
            this.Controls.Add(this.LblPorceso);
            this.Controls.Add(this.Barradecarga);
            this.Controls.Add(this.Img1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img1;
        private System.Windows.Forms.ProgressBar Barradecarga;
        private System.Windows.Forms.Label LblPorceso;
        private System.Windows.Forms.Timer timer1;
    }
}