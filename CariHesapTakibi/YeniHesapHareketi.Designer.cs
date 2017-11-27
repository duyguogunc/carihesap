namespace CariHesapTakibi
{
    partial class YeniHesapHareketi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_EvrakCins = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_EvrakTip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_EvrakNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nm_vadegun = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_vadetarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_islemtarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_NakitTahsilat = new System.Windows.Forms.RadioButton();
            this.rb_NakitTediye = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nm_Tutar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CariHesap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_vadegun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Tutar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_EvrakCins);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_EvrakTip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_EvrakNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(613, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 305);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evraklar";
            // 
            // cmb_EvrakCins
            // 
            this.cmb_EvrakCins.FormattingEnabled = true;
            this.cmb_EvrakCins.Items.AddRange(new object[] {
            "Fatura",
            "Dekont"});
            this.cmb_EvrakCins.Location = new System.Drawing.Point(10, 254);
            this.cmb_EvrakCins.Name = "cmb_EvrakCins";
            this.cmb_EvrakCins.Size = new System.Drawing.Size(242, 41);
            this.cmb_EvrakCins.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "Evrak Cinsi:";
            // 
            // cmb_EvrakTip
            // 
            this.cmb_EvrakTip.FormattingEnabled = true;
            this.cmb_EvrakTip.Items.AddRange(new object[] {
            "Alış faturası",
            "Alacak dekontu",
            "Borç dekontu"});
            this.cmb_EvrakTip.Location = new System.Drawing.Point(10, 170);
            this.cmb_EvrakTip.Name = "cmb_EvrakTip";
            this.cmb_EvrakTip.Size = new System.Drawing.Size(242, 41);
            this.cmb_EvrakTip.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "Evrak Tipi:";
            // 
            // txt_EvrakNo
            // 
            this.txt_EvrakNo.Location = new System.Drawing.Point(10, 97);
            this.txt_EvrakNo.Name = "txt_EvrakNo";
            this.txt_EvrakNo.Size = new System.Drawing.Size(242, 40);
            this.txt_EvrakNo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Evrak No:";
            // 
            // nm_vadegun
            // 
            this.nm_vadegun.Location = new System.Drawing.Point(182, 295);
            this.nm_vadegun.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nm_vadegun.Name = "nm_vadegun";
            this.nm_vadegun.Size = new System.Drawing.Size(149, 40);
            this.nm_vadegun.TabIndex = 28;
            this.nm_vadegun.ValueChanged += new System.EventHandler(this.nm_vadegun_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 33);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vade Günü:";
            // 
            // dtp_vadetarih
            // 
            this.dtp_vadetarih.Location = new System.Drawing.Point(182, 242);
            this.dtp_vadetarih.Name = "dtp_vadetarih";
            this.dtp_vadetarih.Size = new System.Drawing.Size(386, 40);
            this.dtp_vadetarih.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vade Tarihi:";
            // 
            // dtp_islemtarih
            // 
            this.dtp_islemtarih.Location = new System.Drawing.Point(182, 189);
            this.dtp_islemtarih.Name = "dtp_islemtarih";
            this.dtp_islemtarih.Size = new System.Drawing.Size(386, 40);
            this.dtp_islemtarih.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "İşlem Tarihi:";
            // 
            // rb_NakitTahsilat
            // 
            this.rb_NakitTahsilat.AutoSize = true;
            this.rb_NakitTahsilat.Location = new System.Drawing.Point(383, 138);
            this.rb_NakitTahsilat.Name = "rb_NakitTahsilat";
            this.rb_NakitTahsilat.Size = new System.Drawing.Size(218, 37);
            this.rb_NakitTahsilat.TabIndex = 22;
            this.rb_NakitTahsilat.TabStop = true;
            this.rb_NakitTahsilat.Text = "Nakit Tahsilat";
            this.rb_NakitTahsilat.UseVisualStyleBackColor = true;
            // 
            // rb_NakitTediye
            // 
            this.rb_NakitTediye.AutoSize = true;
            this.rb_NakitTediye.Location = new System.Drawing.Point(182, 138);
            this.rb_NakitTediye.Name = "rb_NakitTediye";
            this.rb_NakitTediye.Size = new System.Drawing.Size(203, 37);
            this.rb_NakitTediye.TabIndex = 21;
            this.rb_NakitTediye.TabStop = true;
            this.rb_NakitTediye.Text = "Nakit Tediye";
            this.rb_NakitTediye.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "İşlem:";
            // 
            // nm_Tutar
            // 
            this.nm_Tutar.Location = new System.Drawing.Point(182, 85);
            this.nm_Tutar.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nm_Tutar.Name = "nm_Tutar";
            this.nm_Tutar.Size = new System.Drawing.Size(149, 40);
            this.nm_Tutar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tutar:";
            // 
            // cmb_CariHesap
            // 
            this.cmb_CariHesap.FormattingEnabled = true;
            this.cmb_CariHesap.Location = new System.Drawing.Point(182, 30);
            this.cmb_CariHesap.Name = "cmb_CariHesap";
            this.cmb_CariHesap.Size = new System.Drawing.Size(351, 41);
            this.cmb_CariHesap.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cari Hesap:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YeniHesapHareketi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nm_vadegun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_vadetarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_islemtarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_NakitTahsilat);
            this.Controls.Add(this.rb_NakitTediye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nm_Tutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_CariHesap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YeniHesapHareketi";
            this.Text = "YeniHesapHareketi";
            this.Load += new System.EventHandler(this.YeniHesapHareketi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_vadegun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Tutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_EvrakCins;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_EvrakTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_EvrakNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nm_vadegun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_vadetarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_islemtarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_NakitTahsilat;
        private System.Windows.Forms.RadioButton rb_NakitTediye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nm_Tutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_CariHesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}