
namespace library
{
    partial class EserTeslim
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
            this.datagEserTeslim = new System.Windows.Forms.DataGridView();
            this.txtEserIdTeslim = new System.Windows.Forms.TextBox();
            this.txtEserIsmiTeslim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEserTeslimAl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagEserTeslim)).BeginInit();
            this.SuspendLayout();
            // 
            // datagEserTeslim
            // 
            this.datagEserTeslim.AllowUserToAddRows = false;
            this.datagEserTeslim.AllowUserToDeleteRows = false;
            this.datagEserTeslim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagEserTeslim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagEserTeslim.Location = new System.Drawing.Point(16, 261);
            this.datagEserTeslim.Name = "datagEserTeslim";
            this.datagEserTeslim.ReadOnly = true;
            this.datagEserTeslim.RowHeadersWidth = 51;
            this.datagEserTeslim.RowTemplate.Height = 24;
            this.datagEserTeslim.Size = new System.Drawing.Size(675, 217);
            this.datagEserTeslim.TabIndex = 0;
            this.datagEserTeslim.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagEserTeslim_CellEnter);
            // 
            // txtEserIdTeslim
            // 
            this.txtEserIdTeslim.Location = new System.Drawing.Point(107, 27);
            this.txtEserIdTeslim.Name = "txtEserIdTeslim";
            this.txtEserIdTeslim.Size = new System.Drawing.Size(169, 22);
            this.txtEserIdTeslim.TabIndex = 1;
            // 
            // txtEserIsmiTeslim
            // 
            this.txtEserIsmiTeslim.Location = new System.Drawing.Point(109, 82);
            this.txtEserIsmiTeslim.Name = "txtEserIsmiTeslim";
            this.txtEserIsmiTeslim.Size = new System.Drawing.Size(169, 22);
            this.txtEserIsmiTeslim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eser ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eser İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanımda Olan Eserler";
            // 
            // btnEserTeslimAl
            // 
            this.btnEserTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEserTeslimAl.Location = new System.Drawing.Point(111, 130);
            this.btnEserTeslimAl.Name = "btnEserTeslimAl";
            this.btnEserTeslimAl.Size = new System.Drawing.Size(167, 46);
            this.btnEserTeslimAl.TabIndex = 4;
            this.btnEserTeslimAl.Text = "Eser Teslim Al";
            this.btnEserTeslimAl.UseVisualStyleBackColor = true;
            this.btnEserTeslimAl.Click += new System.EventHandler(this.btnEserTeslimAl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(516, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EserTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEserTeslimAl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEserIsmiTeslim);
            this.Controls.Add(this.txtEserIdTeslim);
            this.Controls.Add(this.datagEserTeslim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EserTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EserTeslim";
            this.Load += new System.EventHandler(this.EserTeslim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagEserTeslim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagEserTeslim;
        private System.Windows.Forms.TextBox txtEserIdTeslim;
        private System.Windows.Forms.TextBox txtEserIsmiTeslim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEserTeslimAl;
        private System.Windows.Forms.Button button1;
    }
}