namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//edit�rdeki dosyan�n ad�
        public Form1()
        {
            InitializeComponent();
            YeniBelge();//uygulama ilk �al��t���nda yeni belge olu�tursun
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
            if (cevap == DialogResult.OK)////kullan�c� tammam dediyse
            {
                saveFileDialog1.Filter = "Metin Dosyalar�|*.txt|T�m Dosyalar|*.*";
                saveFileDialog1.DefaultExt = "*.txt";
                string secilenDosya = saveFileDialog1.FileName;
                // File s�n�f� dosya i�lemleri i�in kullan�l�r
                File.WriteAllText(secilenDosya, txtbelge.Text);
                dosyaAdi = secilenDosya;
                Text =$"[{dosyaAdi}]";
            }
        }
    }
}
