namespace EditorApp
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
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            miyeni = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            mikaydet = new ToolStripMenuItem();
            farklıToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            mikes = new ToolStripMenuItem();
            mikopyala = new ToolStripMenuItem();
            miyapıştır = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            bulToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            temalarToolStripMenuItem = new ToolStripMenuItem();
            mikoyutema = new ToolStripMenuItem();
            miaciktema = new ToolStripMenuItem();
            miyazıtipi = new ToolStripMenuItem();
            miyazırengi = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbyeni = new ToolStripButton();
            tsbac = new ToolStripButton();
            tsbkaydet = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbkes = new ToolStripButton();
            tsbkopyala = new ToolStripButton();
            tsbyapıştır = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbbul = new ToolStripButton();
            tsbhakkinda = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtbelge = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.BlanchedAlmond;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, görünümToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miyeni, açToolStripMenuItem, mikaydet, farklıToolStripMenuItem, toolStripMenuItem2, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // miyeni
            // 
            miyeni.Name = "miyeni";
            miyeni.Size = new Size(141, 22);
            miyeni.Text = "Yeni ";
            miyeni.Click += miyeni_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(141, 22);
            açToolStripMenuItem.Text = "Aç";
            açToolStripMenuItem.Click += toolStripButton2_Click;
            // 
            // mikaydet
            // 
            mikaydet.Name = "mikaydet";
            mikaydet.Size = new Size(141, 22);
            mikaydet.Text = "Kaydet";
            mikaydet.Click += tsbkaydet_Click;
            // 
            // farklıToolStripMenuItem
            // 
            farklıToolStripMenuItem.Name = "farklıToolStripMenuItem";
            farklıToolStripMenuItem.Size = new Size(141, 22);
            farklıToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(138, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(141, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mikes, mikopyala, miyapıştır, toolStripMenuItem1, bulToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // mikes
            // 
            mikes.Name = "mikes";
            mikes.Size = new Size(116, 22);
            mikes.Text = "Kes";
            mikes.Click += mikes_Click;
            // 
            // mikopyala
            // 
            mikopyala.Name = "mikopyala";
            mikopyala.Size = new Size(116, 22);
            mikopyala.Text = "Kopyala";
            mikopyala.Click += mikopyala_Click;
            // 
            // miyapıştır
            // 
            miyapıştır.Name = "miyapıştır";
            miyapıştır.Size = new Size(116, 22);
            miyapıştır.Text = "Yapıştır";
            miyapıştır.Click += miyapıştır_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(113, 6);
            // 
            // bulToolStripMenuItem
            // 
            bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            bulToolStripMenuItem.Size = new Size(116, 22);
            bulToolStripMenuItem.Text = "Bul";
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temalarToolStripMenuItem, miyazıtipi, miyazırengi });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(70, 20);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // temalarToolStripMenuItem
            // 
            temalarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mikoyutema, miaciktema });
            temalarToolStripMenuItem.Name = "temalarToolStripMenuItem";
            temalarToolStripMenuItem.Size = new Size(133, 22);
            temalarToolStripMenuItem.Text = "Temalar";
            // 
            // mikoyutema
            // 
            mikoyutema.Name = "mikoyutema";
            mikoyutema.Size = new Size(132, 22);
            mikoyutema.Text = "Koyu Tema";
            mikoyutema.Click += mikoyutema_Click;
            // 
            // miaciktema
            // 
            miaciktema.Name = "miaciktema";
            miaciktema.Size = new Size(132, 22);
            miaciktema.Text = "Açık Tema";
            miaciktema.Click += miaciktema_Click;
            // 
            // miyazıtipi
            // 
            miyazıtipi.Name = "miyazıtipi";
            miyazıtipi.Size = new Size(133, 22);
            miyazıtipi.Text = "Yazı Tipi ";
            miyazıtipi.Click += miyazıtipi_Click;
            // 
            // miyazırengi
            // 
            miyazırengi.Name = "miyazırengi";
            miyazırengi.Size = new Size(133, 22);
            miyazırengi.Text = "Yazaı Rengi";
            miyazırengi.Click += miyazırengi_Click;
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkındaToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(56, 20);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(124, 22);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(192, 255, 192);
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbyeni, tsbac, tsbkaydet, toolStripSeparator1, tsbkes, tsbkopyala, tsbyapıştır, toolStripSeparator2, tsbbul, tsbhakkinda });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbyeni
            // 
            tsbyeni.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_New_file_32;
            tsbyeni.ImageTransparentColor = Color.Magenta;
            tsbyeni.Name = "tsbyeni";
            tsbyeni.Size = new Size(36, 51);
            tsbyeni.Text = "Yeni";
            tsbyeni.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbyeni.Click += tsbyeni_Click;
            // 
            // tsbac
            // 
            tsbac.Image = Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file_32;
            tsbac.ImageTransparentColor = Color.Magenta;
            tsbac.Name = "tsbac";
            tsbac.Size = new Size(36, 51);
            tsbac.Text = "Aç";
            tsbac.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbac.Click += toolStripButton2_Click;
            // 
            // tsbkaydet
            // 
            tsbkaydet.Image = Properties.Resources.Custom_Icon_Design_Flatastic_9_Save_32__1_;
            tsbkaydet.ImageTransparentColor = Color.Magenta;
            tsbkaydet.Name = "tsbkaydet";
            tsbkaydet.Size = new Size(47, 51);
            tsbkaydet.Text = "Kaydet";
            tsbkaydet.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbkaydet.Click += tsbkaydet_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tsbkes
            // 
            tsbkes.Image = Properties.Resources.Custom_Icon_Design_Flatastic_1_Cut_32;
            tsbkes.ImageTransparentColor = Color.Magenta;
            tsbkes.Name = "tsbkes";
            tsbkes.Size = new Size(36, 51);
            tsbkes.Text = "Kes";
            tsbkes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbkes.Click += mikes_Click;
            // 
            // tsbkopyala
            // 
            tsbkopyala.Image = Properties.Resources.Ampeross_Qetto_2_Copy_32;
            tsbkopyala.ImageTransparentColor = Color.Magenta;
            tsbkopyala.Name = "tsbkopyala";
            tsbkopyala.Size = new Size(53, 51);
            tsbkopyala.Text = "Kopyala";
            tsbkopyala.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbkopyala.Click += mikopyala_Click;
            // 
            // tsbyapıştır
            // 
            tsbyapıştır.Image = Properties.Resources.Franksouza183_Fs_Actions_paste_32;
            tsbyapıştır.ImageTransparentColor = Color.Magenta;
            tsbyapıştır.Name = "tsbyapıştır";
            tsbyapıştır.Size = new Size(49, 51);
            tsbyapıştır.Text = "Yapıştır";
            tsbyapıştır.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbyapıştır.Click += miyapıştır_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tsbbul
            // 
            tsbbul.Image = Properties.Resources.Google_Noto_Emoji_Objects_62851_magnifying_glass_tilted_right_32;
            tsbbul.ImageTransparentColor = Color.Magenta;
            tsbbul.Name = "tsbbul";
            tsbbul.Size = new Size(36, 51);
            tsbbul.Text = "Bul";
            tsbbul.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbbul.Click += tsbbul_Click;
            // 
            // tsbhakkinda
            // 
            tsbhakkinda.Image = Properties.Resources.Aha_Soft_People_User_info_32;
            tsbhakkinda.ImageTransparentColor = Color.Magenta;
            tsbhakkinda.Name = "tsbhakkinda";
            tsbhakkinda.Size = new Size(61, 51);
            tsbhakkinda.Text = "Hakkında";
            tsbhakkinda.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbhakkinda.Click += tsbhakkinda_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.DeepSkyBlue;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(34, 17);
            toolStripStatusLabel1.Text = "Hazır";
            // 
            // txtbelge
            // 
            txtbelge.BackColor = Color.Aquamarine;
            txtbelge.Dock = DockStyle.Fill;
            txtbelge.Location = new Point(0, 78);
            txtbelge.Multiline = true;
            txtbelge.Name = "txtbelge";
            txtbelge.Size = new Size(800, 350);
            txtbelge.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Dosya Kaydet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbelge);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem temalarToolStripMenuItem;
        private ToolStripMenuItem mikoyutema;
        private ToolStripMenuItem miaciktema;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem miyeni;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem mikaydet;
        private ToolStripMenuItem mikes;
        private ToolStripMenuItem mikopyala;
        private ToolStripMenuItem miyapıştır;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem bulToolStripMenuItem;
        private ToolStripMenuItem miyazıtipi;
        private ToolStripMenuItem miyazırengi;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem farklıToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripButton tsbyeni;
        private ToolStripButton tsbac;
        private ToolStripButton tsbkaydet;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbkes;
        private ToolStripButton tsbkopyala;
        private ToolStripButton tsbyapıştır;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbbul;
        private ToolStripButton tsbhakkinda;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtbelge;
        private SaveFileDialog saveFileDialog1;
    }
}
