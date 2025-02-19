using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorApp
{
    public partial class Frmbul : Form
    {
        TextBox txtbelge;
        public Frmbul(TextBox txtbelge)//Yapıcı metot
        {
            this.txtbelge = txtbelge;
            InitializeComponent();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            int bulunanIndex = txtbelge.Text.IndexOf(txtaranan.Text);
            if(bulunanIndex == -1)
            {
                MessageBox.Show("Aradığınız metin bulunamadı");
                return;
            }
            else
            {
                //Textbox içinde bir yeri seçili hale getirir
                txtbelge.SelectionStart = bulunanIndex;
                txtbelge.SelectionLength = txtaranan.Text.Length;
                txtbelge.Focus();
            }
        }
    }
}
