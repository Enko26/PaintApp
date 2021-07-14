using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        /* Nesne çizmemizi sağlayan sınıfımıza değişken tanımladık.
         * baslaX, baslaY, yönx ve yöny mouse un o anki pixturebox üzerinde bulunduğu konumun koordinatlarını tutacak değişkenler. 
         * a değişkenine direkt çizime başlamak için 5 değerini verdik. */
       
        public Graphics paint; 
        bool ciz, sil, sekilciz; 
        int baslaX, baslaY, yönx, yöny;
        int a = 5;
        int kalınlık = 1;
        ColorDialog renkseç = new ColorDialog();
        /// <summary>
        /// /Picturebox üzerinde çizim yapmamızı sağlayan kodu form1 e kodladık.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            paint = pictureBox1.CreateGraphics();
        }
        /// <summary>
        /// Renk seçimi sağlayan buton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renkler_Click(object sender, EventArgs e)
        {
            renkseç.ShowDialog();
        }
        /// <summary> 
        /// Ekranda çizilen her şeyi temizlememizi sağlayan buton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void temizle_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.White; 
        }
        /// <summary>
        /// Çizim yapılırken istenilen kalınlığın ayarlandığı seçim kutusu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalınlık = int.Parse(comboBox1.SelectedItem.ToString());
        }
        /// <summary>
        /// Basılı halde olan mouse tuşunun bırakıldığı anda gerçekleşecek olaylar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
            sekilciz = false; 
            sil = false; 
        }
        /// <summary>
        /// Mouse basılı iken mouse hareketlerini gerçekleştiren event.
        /// Buton seçimlerinde 1 2 veya 3 seçildiyse şekil çizme aktif hale gelecek.
        /// 4 Seçilirse detaylı silme işlemi yapabilmesi için silgi oluşturduk.
        /// Oluşturulan silgi yumuşak çizim yaparak pixel kaybını önleyen kodlara sahip aynı zamanda sil ifadesi aktif olduğunda
        /// drawline kullanılarak başlangıç bitiş noktaları olan bir çizim aracı haline getirdik.
        /// Eğer 5 seçilirse çizim yapabilmemiz için gereken kalemi oluşturduk.
        /// Kalem aracı silgiyle aynı mantığa sahip tek farkı rengi seçilebilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (a == 1 || a == 2 || a == 3)
            {
                sekilciz = true;
                ciz = false;
                sil = false;
            }
            else if (a == 4)
            {
                Pen p = new Pen(Color.White, kalınlık); 
                paint.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 
                p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round; 
                if (sil == true) 
                {
                    paint.DrawLine(p, baslaX, baslaY, e.X, e.Y); 
                    baslaX = e.X; 
                    baslaY = e.Y; 
                }
            }
            else if (a == 5)
            {
                Pen p = new Pen(renkseç.Color, kalınlık); 
                paint.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round; 
                if (ciz == true) 
                {
                    paint.DrawLine(p, baslaX, baslaY, e.X, e.Y); 
                    baslaX = e.X; 
                    baslaY = e.Y; 
                }
            }
        }
        /// <summary>
        /// Mouse un herhangi bir tuşuna basıldığı anda çalışacak kodların bulunduğu event.
        /// 1 2 veya 3 seçilirse şekil çizme butonlarına tıklandığını, 4 seçilirse silgi butonu, 5 seçilirse çizme aracı butonuna tıklandığını gösterir.
        /// baslaX = e.X;
        /// baslaY = e.Y; 
        /// Bu iki satırda ki kodlar tıklandıktan sonra hemen çizime başlamamızı sağlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (a == 1 || a == 2 || a == 3)
            {
                if (e.Button == MouseButtons.Left)
                {
                    sekilciz = true;
                }
                baslaX = e.X; 
                baslaY = e.Y; 
            }
            else if (a == 4)
            {
                if (e.Button == MouseButtons.Left) 
                {
                    sil = true;
                }
                baslaX = e.X; 
                baslaY = e.Y; 
            }
            else if (a == 5)
            {
                if (e.Button == MouseButtons.Left) 
                {
                    ciz = true;
                }
                baslaX = e.X; 
                baslaY = e.Y; 
            }
        }
        /// <summary>
        ///  Pictureboxın arka plan renginin değişimini sağlayan buton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arkaplanrenk_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog(); 
            if (c.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.BackColor = c.Color; 
            }
        }
        /// <summary>
        /// picturebox ın üzerinde iken mouse a tıklandığında gerçekleşecek kodların bulunduğu event.
        /// yönx ve yöny çizilen şeklin genişlik ve yüksekliğini belirtmemizi sağlar.
        /// DrawLine, DrawRectangle, DrawEllipse sırasıyla düz çizgi, kare, ve yuvarlak çizimine yarayan 
        /// başlangıç, bitiş, yükseklik, genişlik parametreleri olan, rengi ve kalınlığı seçilebilen şekil araçları oluşturduk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sekilciz == true)
            {
                yönx = e.X - baslaX; 
                yöny = baslaY - e.Y; 
                if (a == 1)
                {
                    paint.DrawLine(new Pen(renkseç.Color, kalınlık), baslaX, baslaY, e.X, e.Y);  
                }
                else if (a == 2)
                {
                    paint.DrawRectangle(new Pen(renkseç.Color, kalınlık), baslaX, baslaY, yönx, -yöny);
                }
                else if (a == 3)
                {
                    paint.DrawEllipse(new Pen(renkseç.Color, kalınlık), baslaX, baslaY, yönx, -yöny); 
                }
            }
        }
        /// <summary>
        /// Silgi butonuna tıklandığını gösteren event.
        /// Seçim yapabilmemizi sağlayan kod.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void silgi_Click(object sender, EventArgs e)
        {
            a = 4;
        }
        /// <summary>
        /// Kare şekli çizme butonuna tıklandığını gösteren event.
        /// Seçim yapabilmemizi sağlayan kod.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kare_Click(object sender, EventArgs e)
        {
            a = 2; 
        }
        /// <summary>
        /// Yuvarlak şekli çizme butonuna tıklandığını gösteren event.
        /// Seçim yapabilmemizi sağlayan kod.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yuvarlak_Click(object sender, EventArgs e)
        {
            a = 3;
        }
        /// <summary>
        /// Düz çizgi çizme butonuna tıklandığını gösteren event.
        /// Seçim yapabilmemizi sağlayan kod.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cizgi_Click(object sender, EventArgs e)
        {
            a = 1;
        }
        /// <summary>
        /// Kalem butonuna tıklandığını gösteren event.
        /// Seçim yapabilmemizi sağlayan kod.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kalem_Click(object sender, EventArgs e)
        {
            a = 5;
        }
        /// <summary>
        /// Menüde hakkımızda itemine tıklandığını gösteren event.
        /// Bir dialog kutusu açtık ve yazımızı gösterdik.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult(); 
            dialog = MessageBox.Show("Design By EnesDiken & SezerLimanlar", "PaintApp", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Menüde kaydet itemine tıklandığını gösteren event.
        /// Bitmap sınıfında yükseklik ve genişlik parametreleri alan bitmap değişkeni tanımladık.
        /// Tanımlanan değişkeni ekran görüntüsü alınabilcek hale getirdik.
        /// Ardından pictureboxın tüm yüzeyindeki pixele karşılık gelen veriyi kaydettik.
        /// SaveFiledialog kullanarak resimi png jpg yada bitmap formatı halinde kaydedilmesini sağladık.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics cizimler = Graphics.FromImage(bitmap); 
                Rectangle ekranikaydet = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
                cizimler.CopyFromScreen(ekranikaydet.Location, Point.Empty, pictureBox1.Size); 
                SaveFileDialog save = new SaveFileDialog(); 
                save.Filter = "Png Dosyası|.png|jpeg Dosyası|.jpg|bitmaps|*.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (save.FileName.Contains(".jpg"))
                    {
                        bitmap.Save(save.FileName, ImageFormat.Jpeg); 
                    }
                    else if (save.FileName.Contains(".png"))  
                    {
                        bitmap.Save(save.FileName, ImageFormat.Png); 
                    }
                    else if (save.FileName.Contains("bmp")) 
                    {
                        bitmap.Save(save.FileName, ImageFormat.Bmp);
                    }
                }
            }
        }
        /// <summary>
        /// Menüde resim ekle itemine tıklandığını gösteren event.
        /// Çizimlerimizin kaybolmaması için uyarı penceresi açtık evet butonu tıklanırsa resmi ekler ve önceden çizilenleri yokeder.
        /// Hayır butonuna tıklanırsa kaldığı yerden devam eder.
        /// Dosya seçimi için openFileDialog kullandık.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult(); 
            dialog = MessageBox.Show("Devam ederseniz çizdikleriniz kaybolucaktır.", "Uyarı!", MessageBoxButtons.YesNo); 
            {
                if (dialog == DialogResult.Yes)
                {
                    openFileDialog1.ShowDialog();
                    pictureBox1.ImageLocation = openFileDialog1.FileName; 
                }
                else { }                                          
            }
        }
        /// <summary>
        /// Menüde Çıkış itemine tıklandığını gösteren event.
        /// Kaydetmeden çıkış yapılmaması için uyarı penceresi konuldu evet butonuna basılırsa kaydet menüsü açıır hayıra basılırsa direkt uygulama kapanır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult(); 
            dialog = MessageBox.Show("Çıkmadan önce yapılan değişiklikleri kaydetmek istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo); 
            {
                if (dialog == DialogResult.Yes)
                {
                    kaydetToolStripMenuItem.PerformClick();
                }
                else
                {
                    Application.Exit(); 
                }
            }

        }
    }
}
