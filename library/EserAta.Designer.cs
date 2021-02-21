
namespace library
{
    partial class EserAta
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
            this.datagEserAta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEserID = new System.Windows.Forms.TextBox();
            this.txtEserAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPersonBilgi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpEserTeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpeserAtamaTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagEserAta)).BeginInit();
            this.SuspendLayout();
            // 
            // datagEserAta
            // 
            this.datagEserAta.AllowUserToAddRows = false;
            this.datagEserAta.AllowUserToDeleteRows = false;
            this.datagEserAta.AllowUserToOrderColumns = true;
            this.datagEserAta.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagEserAta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagEserAta.Location = new System.Drawing.Point(66, 351);
            this.datagEserAta.Name = "datagEserAta";
            this.datagEserAta.ReadOnly = true;
            this.datagEserAta.RowHeadersWidth = 51;
            this.datagEserAta.RowTemplate.Height = 24;
            this.datagEserAta.Size = new System.Drawing.Size(603, 155);
            this.datagEserAta.TabIndex = 0;
            this.datagEserAta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagEserAta_CellContentClick);
            this.datagEserAta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagEserAta_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eser Atamak için Müsait olan Eserler";
            // 
            // txtEserID
            // 
            this.txtEserID.Location = new System.Drawing.Point(141, 56);
            this.txtEserID.Name = "txtEserID";
            this.txtEserID.Size = new System.Drawing.Size(150, 22);
            this.txtEserID.TabIndex = 2;
            // 
            // txtEserAdı
            // 
            this.txtEserAdı.Location = new System.Drawing.Point(141, 99);
            this.txtEserAdı.Name = "txtEserAdı";
            this.txtEserAdı.Size = new System.Drawing.Size(150, 22);
            this.txtEserAdı.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eser ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eser Adı";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(141, 155);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(152, 22);
            this.txtPersonID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personal ID";
            // 
            // btnPersonBilgi
            // 
            this.btnPersonBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonBilgi.Location = new System.Drawing.Point(141, 189);
            this.btnPersonBilgi.Name = "btnPersonBilgi";
            this.btnPersonBilgi.Size = new System.Drawing.Size(143, 27);
            this.btnPersonBilgi.TabIndex = 6;
            this.btnPersonBilgi.Text = "Personel Bilgisi";
            this.btnPersonBilgi.UseVisualStyleBackColor = true;
            this.btnPersonBilgi.Click += new System.EventHandler(this.btnPersonBilgi_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(495, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eser Ata";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpEserTeslimTarih
            // 
            this.dtpEserTeslimTarih.Location = new System.Drawing.Point(458, 101);
            this.dtpEserTeslimTarih.Name = "dtpEserTeslimTarih";
            this.dtpEserTeslimTarih.Size = new System.Drawing.Size(211, 22);
            this.dtpEserTeslimTarih.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(346, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teslim Tarihi";
            // 
            // dtpeserAtamaTarih
            // 
            this.dtpeserAtamaTarih.Location = new System.Drawing.Point(458, 56);
            this.dtpeserAtamaTarih.Name = "dtpeserAtamaTarih";
            this.dtpeserAtamaTarih.Size = new System.Drawing.Size(211, 22);
            this.dtpeserAtamaTarih.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(358, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alma Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(358, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Alma Tarihi";
            // 
            // btnDonMenu
            // 
            this.btnDonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonMenu.Location = new System.Drawing.Point(495, 260);
            this.btnDonMenu.Name = "btnDonMenu";
            this.btnDonMenu.Size = new System.Drawing.Size(152, 44);
            this.btnDonMenu.TabIndex = 10;
            this.btnDonMenu.Text = "Menüye Dön";
            this.btnDonMenu.UseVisualStyleBackColor = true;
            this.btnDonMenu.Click += new System.EventHandler(this.btnDonMenu_Click);
            // 
            // EserAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 534);
            this.Controls.Add(this.btnDonMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpeserAtamaTarih);
            this.Controls.Add(this.dtpEserTeslimTarih);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPersonBilgi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEserAdı);
            this.Controls.Add(this.txtEserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagEserAta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EserAta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EserAta";
            this.Load += new System.EventHandler(this.EserAta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagEserAta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagEserAta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEserID;
        private System.Windows.Forms.TextBox txtEserAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersonBilgi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpEserTeslimTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpeserAtamaTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDonMenu;
    }
}