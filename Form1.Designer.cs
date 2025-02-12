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
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            bulToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            temalarToolStripMenuItem = new ToolStripMenuItem();
            koyuTemaToolStripMenuItem = new ToolStripMenuItem();
            açıkTemaToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            yazaıRengiToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbyeni = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tsbkaydet = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
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
            menuStrip1.BackColor = Color.LightSteelBlue;
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
            miyeni.Size = new Size(180, 22);
            miyeni.Text = "Yeni ";
            miyeni.Click += miyeni_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(180, 22);
            açToolStripMenuItem.Text = "Aç";
            // 
            // mikaydet
            // 
            mikaydet.Name = "mikaydet";
            mikaydet.Size = new Size(180, 22);
            mikaydet.Text = "Kaydet";
            mikaydet.Click += tsbkaydet_Click;
            // 
            // farklıToolStripMenuItem
            // 
            farklıToolStripMenuItem.Name = "farklıToolStripMenuItem";
            farklıToolStripMenuItem.Size = new Size(180, 22);
            farklıToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(180, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem, toolStripMenuItem1, bulToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(116, 22);
            kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(116, 22);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(116, 22);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
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
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temalarToolStripMenuItem, yazıTipiToolStripMenuItem, yazaıRengiToolStripMenuItem });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(70, 20);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // temalarToolStripMenuItem
            // 
            temalarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { koyuTemaToolStripMenuItem, açıkTemaToolStripMenuItem });
            temalarToolStripMenuItem.Name = "temalarToolStripMenuItem";
            temalarToolStripMenuItem.Size = new Size(133, 22);
            temalarToolStripMenuItem.Text = "Temalar";
            // 
            // koyuTemaToolStripMenuItem
            // 
            koyuTemaToolStripMenuItem.Name = "koyuTemaToolStripMenuItem";
            koyuTemaToolStripMenuItem.Size = new Size(132, 22);
            koyuTemaToolStripMenuItem.Text = "Koyu Tema";
            // 
            // açıkTemaToolStripMenuItem
            // 
            açıkTemaToolStripMenuItem.Name = "açıkTemaToolStripMenuItem";
            açıkTemaToolStripMenuItem.Size = new Size(132, 22);
            açıkTemaToolStripMenuItem.Text = "Açık Tema";
            // 
            // yazıTipiToolStripMenuItem
            // 
            yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            yazıTipiToolStripMenuItem.Size = new Size(133, 22);
            yazıTipiToolStripMenuItem.Text = "Yazı Tipi ";
            // 
            // yazaıRengiToolStripMenuItem
            // 
            yazaıRengiToolStripMenuItem.Name = "yazaıRengiToolStripMenuItem";
            yazaıRengiToolStripMenuItem.Size = new Size(133, 22);
            yazaıRengiToolStripMenuItem.Text = "Yazaı Rengi";
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
            toolStrip1.BackColor = Color.SandyBrown;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbyeni, toolStripButton2, tsbkaydet, toolStripSeparator1, toolStripButton4, toolStripButton5, toolStripButton6, toolStripSeparator2, toolStripButton7, toolStripButton8 });
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
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file_32;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 51);
            toolStripButton2.Text = "Aç";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
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
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.Custom_Icon_Design_Flatastic_1_Cut_32;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(36, 51);
            toolStripButton4.Text = "Kes";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.Ampeross_Qetto_2_Copy_32;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(53, 51);
            toolStripButton5.Text = "Kopyala";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.Franksouza183_Fs_Actions_paste_32;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(49, 51);
            toolStripButton6.Text = "Yapıştır";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // toolStripButton7
            // 
            toolStripButton7.Image = Properties.Resources.Google_Noto_Emoji_Objects_62851_magnifying_glass_tilted_right_32;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(36, 51);
            toolStripButton7.Text = "Bul";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton8
            // 
            toolStripButton8.Image = Properties.Resources.Aha_Soft_People_User_info_32;
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(61, 51);
            toolStripButton8.Text = "Hakkında";
            toolStripButton8.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Bisque;
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
        private ToolStripMenuItem koyuTemaToolStripMenuItem;
        private ToolStripMenuItem açıkTemaToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem miyeni;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem mikaydet;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem bulToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem yazaıRengiToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem farklıToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripButton tsbyeni;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tsbkaydet;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtbelge;
        private SaveFileDialog saveFileDialog1;
    }
}
