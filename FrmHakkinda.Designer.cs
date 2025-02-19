namespace EditorApp
{
    partial class FrmHakkinda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(103, 3);
            label1.Name = "label1";
            label1.Size = new Size(213, 94);
            label1.TabIndex = 1;
            label1.Text = "EditorApp";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(272, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "v.1.0";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Aha_Soft_People_User_info_32;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(295, 169);
            label3.TabIndex = 2;
            label3.Text = "Bu uygulama Torbalı Şehit Uzman Çavuş Harun Şenözülar MTALBilişim Bölümü Nesne Tabanlı Proglamlama dersinde tasarlanmıştır";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(75, 339);
            button1.Name = "button1";
            button1.Size = new Size(165, 60);
            button1.TabIndex = 3;
            button1.Text = "Tamam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmHakkinda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Name = "FrmHakkinda";
            Text = "FrmHakkinda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
    }
}