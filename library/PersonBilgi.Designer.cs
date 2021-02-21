
namespace library
{
    partial class PersonBilgi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonAd = new System.Windows.Forms.TextBox();
            this.txtPersonSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.datagPersonEserBilgi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagPersonEserBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person ID si";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soy Adı";
            // 
            // txtPersonAd
            // 
            this.txtPersonAd.Enabled = false;
            this.txtPersonAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonAd.Location = new System.Drawing.Point(95, 28);
            this.txtPersonAd.Name = "txtPersonAd";
            this.txtPersonAd.Size = new System.Drawing.Size(138, 28);
            this.txtPersonAd.TabIndex = 2;
            // 
            // txtPersonSoyad
            // 
            this.txtPersonSoyad.Enabled = false;
            this.txtPersonSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonSoyad.Location = new System.Drawing.Point(95, 65);
            this.txtPersonSoyad.Name = "txtPersonSoyad";
            this.txtPersonSoyad.Size = new System.Drawing.Size(138, 28);
            this.txtPersonSoyad.TabIndex = 2;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Enabled = false;
            this.txtPersonID.Location = new System.Drawing.Point(95, 96);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(138, 22);
            this.txtPersonID.TabIndex = 2;
            // 
            // datagPersonEserBilgi
            // 
            this.datagPersonEserBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagPersonEserBilgi.BackgroundColor = System.Drawing.Color.MintCream;
            this.datagPersonEserBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagPersonEserBilgi.Location = new System.Drawing.Point(8, 167);
            this.datagPersonEserBilgi.Name = "datagPersonEserBilgi";
            this.datagPersonEserBilgi.RowHeadersWidth = 51;
            this.datagPersonEserBilgi.RowTemplate.Height = 24;
            this.datagPersonEserBilgi.Size = new System.Drawing.Size(490, 111);
            this.datagPersonEserBilgi.TabIndex = 3;
            this.datagPersonEserBilgi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagPersonEserBilgi_CellEnter);
            // 
            // PersonBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 289);
            this.Controls.Add(this.datagPersonEserBilgi);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.txtPersonSoyad);
            this.Controls.Add(this.txtPersonAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonBilgi";
            this.Text = "PersonBilgi";
            this.Load += new System.EventHandler(this.PersonBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagPersonEserBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonAd;
        private System.Windows.Forms.TextBox txtPersonSoyad;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.DataGridView datagPersonEserBilgi;
    }
}