namespace Weather_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            degree_lbl = new Label();
            sehir_cbox = new ComboBox();
            label1 = new Label();
            hava_pcbx = new PictureBox();
            havaDurumu_lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            ruzgarHizi_lbl = new Label();
            nemYuzdesi_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)hava_pcbx).BeginInit();
            SuspendLayout();
            // 
            // degree_lbl
            // 
            degree_lbl.AutoSize = true;
            degree_lbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            degree_lbl.Location = new Point(155, 133);
            degree_lbl.Name = "degree_lbl";
            degree_lbl.Size = new Size(323, 106);
            degree_lbl.TabIndex = 0;
            degree_lbl.Text = "00.00 C";
            // 
            // sehir_cbox
            // 
            sehir_cbox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sehir_cbox.FormattingEnabled = true;
            sehir_cbox.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" });
            sehir_cbox.Location = new Point(12, 39);
            sehir_cbox.Name = "sehir_cbox";
            sehir_cbox.Size = new Size(183, 49);
            sehir_cbox.TabIndex = 1;
            sehir_cbox.SelectedIndexChanged += sehir_cbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 2;
            label1.Text = "Şehir Seçiniz:";
            // 
            // hava_pcbx
            // 
            hava_pcbx.Image = (Image)resources.GetObject("hava_pcbx.Image");
            hava_pcbx.Location = new Point(24, 133);
            hava_pcbx.Name = "hava_pcbx";
            hava_pcbx.Size = new Size(113, 106);
            hava_pcbx.SizeMode = PictureBoxSizeMode.StretchImage;
            hava_pcbx.TabIndex = 3;
            hava_pcbx.TabStop = false;
            // 
            // havaDurumu_lbl
            // 
            havaDurumu_lbl.AutoSize = true;
            havaDurumu_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            havaDurumu_lbl.Location = new Point(171, 226);
            havaDurumu_lbl.Name = "havaDurumu_lbl";
            havaDurumu_lbl.Size = new Size(137, 28);
            havaDurumu_lbl.TabIndex = 4;
            havaDurumu_lbl.Text = "hava durumu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(24, 292);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 5;
            label2.Text = "Nem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(24, 333);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 6;
            label3.Text = "Rüzgar:";
            // 
            // ruzgarHizi_lbl
            // 
            ruzgarHizi_lbl.AutoSize = true;
            ruzgarHizi_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ruzgarHizi_lbl.Location = new Point(114, 333);
            ruzgarHizi_lbl.Name = "ruzgarHizi_lbl";
            ruzgarHizi_lbl.Size = new Size(113, 28);
            ruzgarHizi_lbl.TabIndex = 8;
            ruzgarHizi_lbl.Text = "rüzgar hızı";
            // 
            // nemYuzdesi_lbl
            // 
            nemYuzdesi_lbl.AutoSize = true;
            nemYuzdesi_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nemYuzdesi_lbl.Location = new Point(114, 292);
            nemYuzdesi_lbl.Name = "nemYuzdesi_lbl";
            nemYuzdesi_lbl.Size = new Size(130, 28);
            nemYuzdesi_lbl.TabIndex = 7;
            nemYuzdesi_lbl.Text = "nem yüzdesi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(462, 450);
            Controls.Add(ruzgarHizi_lbl);
            Controls.Add(nemYuzdesi_lbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(havaDurumu_lbl);
            Controls.Add(hava_pcbx);
            Controls.Add(label1);
            Controls.Add(sehir_cbox);
            Controls.Add(degree_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)hava_pcbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label degree_lbl;
        private ComboBox sehir_cbox;
        private Label label1;
        private PictureBox hava_pcbx;
        private Label havaDurumu_lbl;
        private Label label2;
        private Label label3;
        private Label ruzgarHizi_lbl;
        private Label nemYuzdesi_lbl;
    }
}