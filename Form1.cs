namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//editördeki dosyanın adı
        public Form1()
        {
            InitializeComponent();
            YeniBelge();//uygulama ilk çalıştığında yeni belge oluştursun
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

        void YeniBelge()
        {
            txtbelge.Text = "";//metin kutusunu temizler
            dosyaAdi = "";
            Text = "[Yeni Belge] ";
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
        }
}
