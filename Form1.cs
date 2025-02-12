namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//editördeki dosyanýn adý
        public Form1()
        {
            InitializeComponent();
            YeniBelge();//uygulama ilk çalýþtýðýnda yeni belge oluþtursun
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
            DialogResult  cevap= saveFileDialog1.ShowDialog();
            if (cevap == DialogResult.OK)////kullanýcý tammam dediyse
            {
                saveFileDialog1.Filter = "Metin Dosyalarý|*.txt|Tüm Dosyalar|*.*";
                saveFileDialog1.DefaultExt = "*.txt";
                string secilenDosya = saveFileDialog1.FileName;
                // File sýnýfý dosya iþlemleri için kullanýlýr
                File.WriteAllText(secilenDosya, txtbelge.Text);
                dosyaAdi = secilenDosya;
                Text =$"[{dosyaAdi}]";
            }
        }
    }
}
