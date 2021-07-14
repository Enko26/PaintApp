namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cizgi = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kare = new System.Windows.Forms.Button();
            this.yuvarlak = new System.Windows.Forms.Button();
            this.silgi = new System.Windows.Forms.Button();
            this.renkler = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.kalem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaplanrenk = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Çizim = new System.Windows.Forms.GroupBox();
            this.sekiller = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Çizim.SuspendLayout();
            this.sekiller.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cizgi
            // 
            this.cizgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cizgi.ImageKey = "cizgi.png";
            this.cizgi.ImageList = this.ımageList1;
            this.cizgi.Location = new System.Drawing.Point(96, 41);
            this.cizgi.Name = "cizgi";
            this.cizgi.Size = new System.Drawing.Size(47, 48);
            this.cizgi.TabIndex = 1;
            this.cizgi.UseVisualStyleBackColor = true;
            this.cizgi.Click += new System.EventHandler(this.cizgi_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arkaplanrenk.jpg");
            this.ımageList1.Images.SetKeyName(1, "cizgi.png");
            this.ımageList1.Images.SetKeyName(2, "kare.png");
            this.ımageList1.Images.SetKeyName(3, "silgi.png");
            this.ımageList1.Images.SetKeyName(4, "temizle.png");
            this.ımageList1.Images.SetKeyName(5, "yuvarlak.png");
            this.ımageList1.Images.SetKeyName(6, "kalem.png");
            this.ımageList1.Images.SetKeyName(7, "renkler.png");
            // 
            // kare
            // 
            this.kare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kare.ImageKey = "kare.png";
            this.kare.ImageList = this.ımageList1;
            this.kare.Location = new System.Drawing.Point(161, 41);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(50, 48);
            this.kare.TabIndex = 2;
            this.kare.UseVisualStyleBackColor = true;
            this.kare.Click += new System.EventHandler(this.kare_Click);
            // 
            // yuvarlak
            // 
            this.yuvarlak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yuvarlak.ImageKey = "yuvarlak.png";
            this.yuvarlak.ImageList = this.ımageList1;
            this.yuvarlak.Location = new System.Drawing.Point(28, 41);
            this.yuvarlak.Name = "yuvarlak";
            this.yuvarlak.Size = new System.Drawing.Size(47, 48);
            this.yuvarlak.TabIndex = 3;
            this.yuvarlak.UseVisualStyleBackColor = true;
            this.yuvarlak.Click += new System.EventHandler(this.yuvarlak_Click);
            // 
            // silgi
            // 
            this.silgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silgi.ImageKey = "silgi.png";
            this.silgi.ImageList = this.ımageList1;
            this.silgi.Location = new System.Drawing.Point(299, 41);
            this.silgi.Name = "silgi";
            this.silgi.Size = new System.Drawing.Size(56, 48);
            this.silgi.TabIndex = 4;
            this.silgi.UseVisualStyleBackColor = true;
            this.silgi.Click += new System.EventHandler(this.silgi_Click);
            // 
            // renkler
            // 
            this.renkler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renkler.ImageKey = "renkler.png";
            this.renkler.ImageList = this.ımageList1;
            this.renkler.Location = new System.Drawing.Point(46, 41);
            this.renkler.Name = "renkler";
            this.renkler.Size = new System.Drawing.Size(51, 48);
            this.renkler.TabIndex = 5;
            this.renkler.UseVisualStyleBackColor = true;
            this.renkler.Click += new System.EventHandler(this.renkler_Click);
            // 
            // temizle
            // 
            this.temizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temizle.ImageKey = "temizle.png";
            this.temizle.ImageList = this.ımageList1;
            this.temizle.Location = new System.Drawing.Point(158, 41);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(48, 48);
            this.temizle.TabIndex = 6;
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // kalem
            // 
            this.kalem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kalem.ImageKey = "kalem.png";
            this.kalem.ImageList = this.ımageList1;
            this.kalem.Location = new System.Drawing.Point(237, 41);
            this.kalem.Name = "kalem";
            this.kalem.Size = new System.Drawing.Size(56, 48);
            this.kalem.TabIndex = 7;
            this.kalem.UseVisualStyleBackColor = true;
            this.kalem.Click += new System.EventHandler(this.kalem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimEkleToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resimEkleToolStripMenuItem
            // 
            this.resimEkleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resimEkleToolStripMenuItem.Name = "resimEkleToolStripMenuItem";
            this.resimEkleToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.resimEkleToolStripMenuItem.Text = "Resim Ekle";
            this.resimEkleToolStripMenuItem.Click += new System.EventHandler(this.resimEkleToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // arkaplanrenk
            // 
            this.arkaplanrenk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.arkaplanrenk.ImageKey = "arkaplanrenk.jpg";
            this.arkaplanrenk.ImageList = this.ımageList1;
            this.arkaplanrenk.Location = new System.Drawing.Point(103, 41);
            this.arkaplanrenk.Name = "arkaplanrenk";
            this.arkaplanrenk.Size = new System.Drawing.Size(49, 48);
            this.arkaplanrenk.TabIndex = 9;
            this.arkaplanrenk.UseVisualStyleBackColor = true;
            this.arkaplanrenk.Click += new System.EventHandler(this.arkaplanrenk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.comboBox1.Location = new System.Drawing.Point(57, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Boyut:";
            // 
            // Çizim
            // 
            this.Çizim.Controls.Add(this.renkler);
            this.Çizim.Controls.Add(this.label1);
            this.Çizim.Controls.Add(this.arkaplanrenk);
            this.Çizim.Controls.Add(this.silgi);
            this.Çizim.Controls.Add(this.comboBox1);
            this.Çizim.Controls.Add(this.kalem);
            this.Çizim.Controls.Add(this.temizle);
            this.Çizim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Çizim.Location = new System.Drawing.Point(12, 27);
            this.Çizim.Name = "Çizim";
            this.Çizim.Size = new System.Drawing.Size(391, 102);
            this.Çizim.TabIndex = 12;
            this.Çizim.TabStop = false;
            this.Çizim.Text = "Çizim";
            // 
            // sekiller
            // 
            this.sekiller.Controls.Add(this.yuvarlak);
            this.sekiller.Controls.Add(this.cizgi);
            this.sekiller.Controls.Add(this.kare);
            this.sekiller.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sekiller.Location = new System.Drawing.Point(419, 27);
            this.sekiller.Name = "sekiller";
            this.sekiller.Size = new System.Drawing.Size(231, 102);
            this.sekiller.TabIndex = 13;
            this.sekiller.TabStop = false;
            this.sekiller.Text = "Şekiller";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.sekiller);
            this.Controls.Add(this.Çizim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Çizim.ResumeLayout(false);
            this.Çizim.PerformLayout();
            this.sekiller.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cizgi;
        private System.Windows.Forms.Button kare;
        private System.Windows.Forms.Button yuvarlak;
        private System.Windows.Forms.Button silgi;
        private System.Windows.Forms.Button renkler;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button kalem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button arkaplanrenk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Çizim;
        private System.Windows.Forms.GroupBox sekiller;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

