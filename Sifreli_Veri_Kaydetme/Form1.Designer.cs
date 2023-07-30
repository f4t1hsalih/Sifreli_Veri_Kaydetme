namespace Sifreli_Veri_Kaydetme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAd = new TextBox();
            dataGridView1 = new DataGridView();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            txtHesapNo = new TextBox();
            label5 = new Label();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 16);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 99;
            label1.Text = "Ad: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(84, 13);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(145, 27);
            txtAd.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.GradientInactiveCaption;
            dataGridView1.Location = new Point(12, 151);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 217);
            dataGridView1.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(84, 48);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(145, 27);
            txtSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 98;
            label2.Text = "Soyad: ";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(84, 83);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(145, 27);
            txtMail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 86);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 97;
            label3.Text = "Mail: ";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(362, 13);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(145, 27);
            txtSifre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 16);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 96;
            label4.Text = "Şifre: ";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(362, 48);
            txtHesapNo.Margin = new Padding(3, 4, 3, 4);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Size = new Size(145, 27);
            txtHesapNo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 51);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 95;
            label5.Text = "Hesap No: ";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(385, 86);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 35);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(538, 381);
            Controls.Add(btnKaydet);
            Controls.Add(txtHesapNo);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifreli Kaydetme";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private DataGridView dataGridView1;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtMail;
        private Label label3;
        private TextBox txtSifre;
        private Label label4;
        private TextBox txtHesapNo;
        private Label label5;
        private Button btnKaydet;
    }
}