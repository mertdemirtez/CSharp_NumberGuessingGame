namespace SayiTahminOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tahminTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gecmisTahminlerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(328, 112);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 20);
            this.txtTahmin.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // tahminTextBox
            // 
            this.tahminTextBox.Location = new System.Drawing.Point(40, 389);
            this.tahminTextBox.Name = "tahminTextBox";
            this.tahminTextBox.Size = new System.Drawing.Size(422, 20);
            this.tahminTextBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(529, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "✓";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.tahminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(455, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geçmiş Tahminlerin";
            // 
            // gecmisTahminlerListBox
            // 
            this.gecmisTahminlerListBox.FormattingEnabled = true;
            this.gecmisTahminlerListBox.Location = new System.Drawing.Point(453, 94);
            this.gecmisTahminlerListBox.Name = "gecmisTahminlerListBox";
            this.gecmisTahminlerListBox.Size = new System.Drawing.Size(101, 251);
            this.gecmisTahminlerListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.BackgroundImage = global::SayiTahminOyunu.Properties.Resources.sayi_tahmin_oyunu;
            this.ClientSize = new System.Drawing.Size(592, 444);
            this.Controls.Add(this.gecmisTahminlerListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tahminTextBox);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi - 𝓬𝓻𝓮𝓪𝓽𝓮𝓭 𝓫𝔂 𝓶𝓮𝓻𝓽 𝓭𝓮𝓶𝓲𝓻";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tahminTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox gecmisTahminlerListBox;
    }
}

