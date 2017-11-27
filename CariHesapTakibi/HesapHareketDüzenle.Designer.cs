namespace CariHesapTakibi
{
    partial class HesapHareketDüzenle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.nm_Tutar = new System.Windows.Forms.NumericUpDown();
            this.rb_NakitTediye = new System.Windows.Forms.RadioButton();
            this.rb_NakitTahsilat = new System.Windows.Forms.RadioButton();
            this.dtp_IslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_VadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.nm_VadeGunu = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_EvrakNo = new System.Windows.Forms.TextBox();
            this.cb_EvrakTipi = new System.Windows.Forms.ComboBox();
            this.cb_EvrakCinsi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_CariHesap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Tutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VadeGunu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CariHesap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "İşlem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "İşlem tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "VadeTarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "VadeGünü";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(609, 293);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(100, 40);
            this.btn_Guncelle.TabIndex = 14;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // nm_Tutar
            // 
            this.nm_Tutar.Location = new System.Drawing.Point(144, 64);
            this.nm_Tutar.Margin = new System.Windows.Forms.Padding(4);
            this.nm_Tutar.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nm_Tutar.Name = "nm_Tutar";
            this.nm_Tutar.Size = new System.Drawing.Size(160, 30);
            this.nm_Tutar.TabIndex = 7;
            // 
            // rb_NakitTediye
            // 
            this.rb_NakitTediye.AutoSize = true;
            this.rb_NakitTediye.Location = new System.Drawing.Point(144, 132);
            this.rb_NakitTediye.Margin = new System.Windows.Forms.Padding(4);
            this.rb_NakitTediye.Name = "rb_NakitTediye";
            this.rb_NakitTediye.Size = new System.Drawing.Size(146, 29);
            this.rb_NakitTediye.TabIndex = 8;
            this.rb_NakitTediye.TabStop = true;
            this.rb_NakitTediye.Text = "Nakit Tediye";
            this.rb_NakitTediye.UseVisualStyleBackColor = true;
            // 
            // rb_NakitTahsilat
            // 
            this.rb_NakitTahsilat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_NakitTahsilat.Location = new System.Drawing.Point(270, 132);
            this.rb_NakitTahsilat.Margin = new System.Windows.Forms.Padding(4);
            this.rb_NakitTahsilat.Name = "rb_NakitTahsilat";
            this.rb_NakitTahsilat.Size = new System.Drawing.Size(139, 21);
            this.rb_NakitTahsilat.TabIndex = 9;
            this.rb_NakitTahsilat.TabStop = true;
            this.rb_NakitTahsilat.Text = "Nakit Tahsilat";
            this.rb_NakitTahsilat.UseVisualStyleBackColor = true;
            // 
            // dtp_IslemTarihi
            // 
            this.dtp_IslemTarihi.Location = new System.Drawing.Point(144, 192);
            this.dtp_IslemTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_IslemTarihi.Name = "dtp_IslemTarihi";
            this.dtp_IslemTarihi.Size = new System.Drawing.Size(265, 30);
            this.dtp_IslemTarihi.TabIndex = 10;
            // 
            // dtp_VadeTarihi
            // 
            this.dtp_VadeTarihi.Location = new System.Drawing.Point(144, 246);
            this.dtp_VadeTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_VadeTarihi.Name = "dtp_VadeTarihi";
            this.dtp_VadeTarihi.Size = new System.Drawing.Size(265, 30);
            this.dtp_VadeTarihi.TabIndex = 11;
            // 
            // nm_VadeGunu
            // 
            this.nm_VadeGunu.Location = new System.Drawing.Point(144, 298);
            this.nm_VadeGunu.Margin = new System.Windows.Forms.Padding(4);
            this.nm_VadeGunu.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nm_VadeGunu.Name = "nm_VadeGunu";
            this.nm_VadeGunu.Size = new System.Drawing.Size(160, 30);
            this.nm_VadeGunu.TabIndex = 12;
            this.nm_VadeGunu.ValueChanged += new System.EventHandler(this.nm_VadeGunu_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Evrak No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "EvrakTipi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Evrak Cinsi";
            // 
            // txt_EvrakNo
            // 
            this.txt_EvrakNo.Location = new System.Drawing.Point(99, 60);
            this.txt_EvrakNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EvrakNo.Name = "txt_EvrakNo";
            this.txt_EvrakNo.Size = new System.Drawing.Size(160, 30);
            this.txt_EvrakNo.TabIndex = 3;
            // 
            // cb_EvrakTipi
            // 
            this.cb_EvrakTipi.FormattingEnabled = true;
            this.cb_EvrakTipi.Location = new System.Drawing.Point(99, 137);
            this.cb_EvrakTipi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_EvrakTipi.Name = "cb_EvrakTipi";
            this.cb_EvrakTipi.Size = new System.Drawing.Size(160, 33);
            this.cb_EvrakTipi.TabIndex = 4;
            // 
            // cb_EvrakCinsi
            // 
            this.cb_EvrakCinsi.FormattingEnabled = true;
            this.cb_EvrakCinsi.Location = new System.Drawing.Point(99, 219);
            this.cb_EvrakCinsi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_EvrakCinsi.Name = "cb_EvrakCinsi";
            this.cb_EvrakCinsi.Size = new System.Drawing.Size(160, 33);
            this.cb_EvrakCinsi.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_EvrakCinsi);
            this.groupBox1.Controls.Add(this.cb_EvrakTipi);
            this.groupBox1.Controls.Add(this.txt_EvrakNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(440, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 261);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evraklar";
            // 
            // cb_CariHesap
            // 
            this.cb_CariHesap.FormattingEnabled = true;
            this.cb_CariHesap.Location = new System.Drawing.Point(144, 16);
            this.cb_CariHesap.Margin = new System.Windows.Forms.Padding(4);
            this.cb_CariHesap.Name = "cb_CariHesap";
            this.cb_CariHesap.Size = new System.Drawing.Size(160, 33);
            this.cb_CariHesap.TabIndex = 6;
            // 
            // HesapHareketDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 352);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nm_VadeGunu);
            this.Controls.Add(this.dtp_VadeTarihi);
            this.Controls.Add(this.dtp_IslemTarihi);
            this.Controls.Add(this.rb_NakitTahsilat);
            this.Controls.Add(this.rb_NakitTediye);
            this.Controls.Add(this.nm_Tutar);
            this.Controls.Add(this.cb_CariHesap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HesapHareketDüzenle";
            this.Text = "HesapHareketDüzenle";
            this.Load += new System.EventHandler(this.HesapHareketDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_Tutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_VadeGunu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_EvrakNo;
        private System.Windows.Forms.ComboBox cb_EvrakTipi;
        private System.Windows.Forms.ComboBox cb_EvrakCinsi;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_Guncelle;
        public System.Windows.Forms.NumericUpDown nm_Tutar;
        public System.Windows.Forms.RadioButton rb_NakitTediye;
        public System.Windows.Forms.RadioButton rb_NakitTahsilat;
        public System.Windows.Forms.DateTimePicker dtp_IslemTarihi;
        public System.Windows.Forms.DateTimePicker dtp_VadeTarihi;
        public System.Windows.Forms.NumericUpDown nm_VadeGunu;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cb_CariHesap;
    }
}