
namespace library
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStudentGiris = new System.Windows.Forms.Button();
            this.btnGorevliGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentGiris
            // 
            this.btnStudentGiris.Location = new System.Drawing.Point(201, 46);
            this.btnStudentGiris.Name = "btnStudentGiris";
            this.btnStudentGiris.Size = new System.Drawing.Size(167, 37);
            this.btnStudentGiris.TabIndex = 0;
            this.btnStudentGiris.Text = "Öğrenci Giriş";
            this.btnStudentGiris.UseVisualStyleBackColor = true;
            this.btnStudentGiris.Click += new System.EventHandler(this.btnStudentGiris_Click);
            // 
            // btnGorevliGiris
            // 
            this.btnGorevliGiris.Location = new System.Drawing.Point(201, 112);
            this.btnGorevliGiris.Name = "btnGorevliGiris";
            this.btnGorevliGiris.Size = new System.Drawing.Size(167, 37);
            this.btnGorevliGiris.TabIndex = 1;
            this.btnGorevliGiris.Text = "Görevli Giriş";
            this.btnGorevliGiris.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 209);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGorevliGiris);
            this.Controls.Add(this.btnStudentGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStudentGiris;
        private System.Windows.Forms.Button btnGorevliGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}