namespace EditorApp
{
    partial class Frmbul
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
            label1 = new Label();
            txtaranan = new TextBox();
            btnbul = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 104);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "aranacak metin";
            // 
            // txtaranan
            // 
            txtaranan.Location = new Point(252, 96);
            txtaranan.Name = "txtaranan";
            txtaranan.Size = new Size(267, 23);
            txtaranan.TabIndex = 1;
            // 
            // btnbul
            // 
            btnbul.Location = new Point(386, 160);
            btnbul.Name = "btnbul";
            btnbul.Size = new Size(133, 43);
            btnbul.TabIndex = 2;
            btnbul.Text = "bul";
            btnbul.UseVisualStyleBackColor = true;
            btnbul.Click += btnbul_Click;
            // 
            // Frmbul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnbul);
            Controls.Add(txtaranan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Frmbul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmbul";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtaranan;
        private Button btnbul;
    }
}