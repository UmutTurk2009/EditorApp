﻿using System.Text.Json;

namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//editördeki dosyanın adı
        Ayarlar ayarlar = new Ayarlar();
        public Form1()
        {
            InitializeComponent();
            AyarlariYukle();//kayýtlý ayar var ise yükler
            YeniBelge(); ;//uygulama ilk çalıştığında yeni belge oluştursun
        }
        void AyarlariYukle()
        {
            if (File.Exists("ayarlar.txt"))
            {
                string jsonMetni = File.ReadAllText("ayarlar.txt");
                //tam tersine serileþtirme yap
                //metni sýnýfa dönüþtür

                ayarlar = JsonSerializer.Deserialize<Ayarlar>(jsonMetni);
                Color yaziRengi = Color.FromArgb(ayarlar.YaziRengi);
                yaziRengi = Color.FromArgb(255, yaziRengi);

                Color arkaRengi = Color.FromArgb(ayarlar.ArkaPlanRengi);
                arkaRengi = Color.FromArgb(255, arkaRengi);

                txtbelge.ForeColor = yaziRengi;
                txtbelge.BackColor = arkaRengi;

                toolStrip1.BackColor = txtbelge.BackColor;
                toolStrip1.ForeColor = txtbelge.ForeColor;
                menuStrip1.BackColor = txtbelge.BackColor;
                menuStrip1.ForeColor = txtbelge.ForeColor;
            }
        }

        void AyarlariKaydet()
        {
            //Serileþtirme sýnýfýn verisini metne dönüþtürmektir
            //Json serileþtirmeyi kullan
            string jsonMetni = JsonSerializer.Serialize(ayarlar);

            File.WriteAllText("ayarlar.txt", jsonMetni);
        }

        void YeniBelge()
        {
            txtbelge.Text = "";//metin kutusunu temizler
            dosyaAdi = "";
            Text = "[Yeni Belge]";
        }
        void Kaydet()
        {

            //eðer dosya zaten kayýtlý ise diyalog gösterme
            //
            if (!string.IsNullOrEmpty(dosyaAdi))//dosyaAdi!=""
            {
                File.WriteAllText(dosyaAdi, txtbelge.Text);
                return;
            }

            saveFileDialog1.Filter = "Metin Dosyalarý|*.txt|Tüm Dosyalar|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            DialogResult cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)//kullanýcý tamam dediyse
            {
                string secilenDosya = saveFileDialog1.FileName;

                //File sýnýfý dosya iþlemleri için kullanýlýr
                File.WriteAllText(secilenDosya, txtbelge.Text);
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }
        }
        private void miyeni_Click(object sender, EventArgs e)
        {
            YeniBelge();
        }

        private void tsbyeni_Click(object sender, EventArgs e)
        {
            YeniBelge();
        }

        private void tsbkaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            dialog.DefaultExt = "*.txt";
            DialogResult cevap = dialog.ShowDialog();//göster ve bekle
            if (cevap == DialogResult.OK)//gelen cevap ne?
            {
                string secilenDosya = dialog.FileName;
                string icerik = File.ReadAllText(secilenDosya);
                txtbelge.Text = icerik;
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox diayalog penceresi
            //MessageBox.Show("Form kapanýyor.....");
            //MessageBox.Show("Form Kapanýyor....", "Dikkat");
            //MessageBox.Show("Form Kapanýyor....", "Dikkat", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Form Kapanýyor....", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            var cevap = MessageBox.Show("Kayýt edilmemiþ deðiþiklikleri kayýt etmek ister misiniz?",
                "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Kaydet();
            }
            else if (cevap == DialogResult.Cancel)
            {
                e.Cancel = true;//kapatma iþlemini iptal et
            }
            //Hayýr seçeneðini yazmaya gerek yok!!!!
        }

        private void mikes_Click(object sender, EventArgs e)
        {
            txtbelge.Cut();
        }

        private void mikopyala_Click(object sender, EventArgs e)
        {
            txtbelge.Copy();
        }

        private void miyapıştır_Click(object sender, EventArgs e)
        {
            txtbelge.Paste();
        }

        private void tsbbul_Click(object sender, EventArgs e)
        {
            Frmbul form = new Frmbul(txtbelge);//form nesnesini oluştur
            form.Show();//formu göster
            //form.ShowDialog();//formu diyalog yapma
        }

        private void miyazıtipi_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            DialogResult cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtbelge.Font = dialog.Font;
            }

        }

        private void miyazırengi_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            DialogResult cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtbelge.ForeColor = dialog.Color;
            }
        }

        private void mikoyutema_Click(object sender, EventArgs e)
        {
            txtbelge.BackColor = Color.Black;
            txtbelge.ForeColor = Color.Orange;
            toolStrip1.BackColor = Color.Black;
            toolStrip1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.ForeColor = Color.White;
            ayarlar.ArkaPlanRengi = Color.Black.ToArgb();
            ayarlar.YaziRengi = Color.Orange.ToArgb();
            AyarlariKaydet();

        }

        private void miaciktema_Click(object sender, EventArgs e)
        {
            txtbelge.BackColor = Color.White;
            txtbelge.ForeColor = Color.Black;
            toolStrip1.BackColor = SystemColors.ButtonFace;
            toolStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.ForeColor = Color.Black;
            ayarlar.ArkaPlanRengi = Color.White.ToArgb();
            ayarlar.YaziRengi = Color.Black.ToArgb();
            AyarlariKaydet();

        }

        private void tsbhakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda form = new();
            form.ShowDialog();


        }
    }
}
