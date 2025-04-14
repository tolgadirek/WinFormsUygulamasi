namespace BurcYorumUygulamasi
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
            groupBox1 = new GroupBox();
            label25 = new Label();
            label6 = new Label();
            button1 = new Button();
            text_kilosu = new TextBox();
            text_boyu = new TextBox();
            text_dtarihi = new TextBox();
            text_soyadi = new TextBox();
            text_adi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            isim_label = new Label();
            soyisim_label = new Label();
            gun_label = new Label();
            ay_label = new Label();
            vki_label = new Label();
            burc_yorum_label = new Label();
            burc_label = new Label();
            yil_label = new Label();
            vki_yorum_label = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(text_kilosu);
            groupBox1.Controls.Add(text_boyu);
            groupBox1.Controls.Add(text_dtarihi);
            groupBox1.Controls.Add(text_soyadi);
            groupBox1.Controls.Add(text_adi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1093, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Red;
            label25.Location = new Point(6, 158);
            label25.Name = "label25";
            label25.Size = new Size(535, 28);
            label25.TabIndex = 12;
            label25.Text = "Not: Boy ve Kilo Bilgisi Girerken \".\" değil \",\" kullanınız.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(904, 58);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 11;
            label6.Text = "(GG.AA.YYYY)";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Lime;
            button1.Location = new Point(790, 151);
            button1.Name = "button1";
            button1.Size = new Size(231, 42);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // text_kilosu
            // 
            text_kilosu.Location = new Point(510, 98);
            text_kilosu.Name = "text_kilosu";
            text_kilosu.Size = new Size(161, 34);
            text_kilosu.TabIndex = 9;
            // 
            // text_boyu
            // 
            text_boyu.Location = new Point(510, 58);
            text_boyu.Name = "text_boyu";
            text_boyu.Size = new Size(161, 34);
            text_boyu.TabIndex = 8;
            // 
            // text_dtarihi
            // 
            text_dtarihi.Location = new Point(790, 98);
            text_dtarihi.Name = "text_dtarihi";
            text_dtarihi.Size = new Size(231, 34);
            text_dtarihi.TabIndex = 7;
            // 
            // text_soyadi
            // 
            text_soyadi.Location = new Point(112, 98);
            text_soyadi.Name = "text_soyadi";
            text_soyadi.Size = new Size(161, 34);
            text_soyadi.TabIndex = 6;
            // 
            // text_adi
            // 
            text_adi.Location = new Point(112, 58);
            text_adi.Name = "text_adi";
            text_adi.Size = new Size(161, 34);
            text_adi.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 98);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 4;
            label5.Text = "Kilosu (kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 58);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 3;
            label4.Text = "Boyu (m)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(769, 58);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyadı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(234, 262);
            label7.Name = "label7";
            label7.Size = new Size(51, 28);
            label7.TabIndex = 12;
            label7.Text = "İsim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(234, 302);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 13;
            label8.Text = "Soyisim";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(235, 342);
            label9.Name = "label9";
            label9.Size = new Size(50, 28);
            label9.TabIndex = 14;
            label9.Text = "Gün";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(235, 383);
            label10.Name = "label10";
            label10.Size = new Size(37, 28);
            label10.TabIndex = 15;
            label10.Text = "Ay";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(236, 424);
            label11.Name = "label11";
            label11.Size = new Size(36, 28);
            label11.TabIndex = 16;
            label11.Text = "Yıl";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(235, 463);
            label12.Name = "label12";
            label12.Size = new Size(55, 28);
            label12.TabIndex = 17;
            label12.Text = "Burç";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(236, 504);
            label13.Name = "label13";
            label13.Size = new Size(121, 28);
            label13.TabIndex = 18;
            label13.Text = "Burç Yorum";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(234, 544);
            label14.Name = "label14";
            label14.Size = new Size(189, 28);
            label14.TabIndex = 19;
            label14.Text = "Vücut Kitle İndeksi";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(236, 588);
            label15.Name = "label15";
            label15.Size = new Size(110, 28);
            label15.TabIndex = 20;
            label15.Text = "VKİ Yorum";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(439, 262);
            label16.Name = "label16";
            label16.Size = new Size(17, 28);
            label16.TabIndex = 21;
            label16.Text = ":";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.Location = new Point(439, 544);
            label17.Name = "label17";
            label17.Size = new Size(17, 28);
            label17.TabIndex = 22;
            label17.Text = ":";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label18.Location = new Point(439, 383);
            label18.Name = "label18";
            label18.Size = new Size(17, 28);
            label18.TabIndex = 23;
            label18.Text = ":";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.Location = new Point(439, 424);
            label19.Name = "label19";
            label19.Size = new Size(17, 28);
            label19.TabIndex = 24;
            label19.Text = ":";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label20.Location = new Point(439, 463);
            label20.Name = "label20";
            label20.Size = new Size(17, 28);
            label20.TabIndex = 25;
            label20.Text = ":";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.Location = new Point(439, 504);
            label21.Name = "label21";
            label21.Size = new Size(17, 28);
            label21.TabIndex = 26;
            label21.Text = ":";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label22.Location = new Point(439, 342);
            label22.Name = "label22";
            label22.Size = new Size(17, 28);
            label22.TabIndex = 27;
            label22.Text = ":";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label23.Location = new Point(439, 302);
            label23.Name = "label23";
            label23.Size = new Size(17, 28);
            label23.TabIndex = 28;
            label23.Text = ":";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label24.Location = new Point(439, 588);
            label24.Name = "label24";
            label24.Size = new Size(17, 28);
            label24.TabIndex = 29;
            label24.Text = ":";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(916, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 180);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 272);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 344);
            listBox1.TabIndex = 31;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // isim_label
            // 
            isim_label.AutoSize = true;
            isim_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            isim_label.Location = new Point(462, 262);
            isim_label.Name = "isim_label";
            isim_label.Size = new Size(0, 28);
            isim_label.TabIndex = 32;
            // 
            // soyisim_label
            // 
            soyisim_label.AutoSize = true;
            soyisim_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            soyisim_label.Location = new Point(462, 302);
            soyisim_label.Name = "soyisim_label";
            soyisim_label.Size = new Size(0, 28);
            soyisim_label.TabIndex = 33;
            // 
            // gun_label
            // 
            gun_label.AutoSize = true;
            gun_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gun_label.Location = new Point(462, 342);
            gun_label.Name = "gun_label";
            gun_label.Size = new Size(0, 28);
            gun_label.TabIndex = 34;
            // 
            // ay_label
            // 
            ay_label.AutoSize = true;
            ay_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ay_label.Location = new Point(462, 383);
            ay_label.Name = "ay_label";
            ay_label.Size = new Size(0, 28);
            ay_label.TabIndex = 35;
            // 
            // vki_label
            // 
            vki_label.AutoSize = true;
            vki_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            vki_label.Location = new Point(462, 545);
            vki_label.Name = "vki_label";
            vki_label.Size = new Size(0, 28);
            vki_label.TabIndex = 39;
            // 
            // burc_yorum_label
            // 
            burc_yorum_label.AutoSize = true;
            burc_yorum_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            burc_yorum_label.Location = new Point(462, 504);
            burc_yorum_label.Name = "burc_yorum_label";
            burc_yorum_label.Size = new Size(0, 28);
            burc_yorum_label.TabIndex = 38;
            // 
            // burc_label
            // 
            burc_label.AutoSize = true;
            burc_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            burc_label.Location = new Point(462, 464);
            burc_label.Name = "burc_label";
            burc_label.Size = new Size(0, 28);
            burc_label.TabIndex = 37;
            // 
            // yil_label
            // 
            yil_label.AutoSize = true;
            yil_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            yil_label.Location = new Point(462, 424);
            yil_label.Name = "yil_label";
            yil_label.Size = new Size(0, 28);
            yil_label.TabIndex = 36;
            // 
            // vki_yorum_label
            // 
            vki_yorum_label.AutoSize = true;
            vki_yorum_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            vki_yorum_label.Location = new Point(462, 588);
            vki_yorum_label.Name = "vki_yorum_label";
            vki_yorum_label.Size = new Size(0, 28);
            vki_yorum_label.TabIndex = 40;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 634);
            button2.Name = "button2";
            button2.Size = new Size(195, 38);
            button2.TabIndex = 41;
            button2.Text = "Kişi Listesini Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1117, 715);
            Controls.Add(button2);
            Controls.Add(vki_yorum_label);
            Controls.Add(vki_label);
            Controls.Add(burc_yorum_label);
            Controls.Add(burc_label);
            Controls.Add(yil_label);
            Controls.Add(ay_label);
            Controls.Add(gun_label);
            Controls.Add(soyisim_label);
            Controls.Add(isim_label);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox text_adi;
        private Button button1;
        private TextBox text_kilosu;
        private TextBox text_boyu;
        private TextBox text_dtarihi;
        private TextBox text_soyadi;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private PictureBox pictureBox1;
        private Label label25;
        private ListBox listBox1;
        private Label isim_label;
        private Label soyisim_label;
        private Label gun_label;
        private Label ay_label;
        private Label vki_label;
        private Label burc_yorum_label;
        private Label burc_label;
        private Label yil_label;
        private Label vki_yorum_label;
        private Button button2;
    }
}
