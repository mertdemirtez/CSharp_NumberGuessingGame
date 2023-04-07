using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        int rastgeleSayi;
        int tahminSayisi = 0;
        int kalanHak = 10;
        List<int> gecmisTahminler = new List<int>();

        public Form1()
        {
            InitializeComponent();
            rastgeleSayi = new Random().Next(1, 101); // 1-100 arası rastgele sayı seçilir
        }

        private void tahminButton_Click(object sender, EventArgs e)
        {
            int tahmin;
            if (!int.TryParse(tahminTextBox.Text, out tahmin))
            {
                MessageBox.Show("Lütfen bir sayı girin.");
                return;
            }

            tahminSayisi++;
            gecmisTahminler.Add(tahmin);

            if (tahmin == rastgeleSayi)
            {
                MessageBox.Show("Tebrikler, " + tahminSayisi + " tahminde doğru cevabı buldunuz!");
                tahminSayisi = 0;
                kalanHak = 10;
                gecmisTahminler.Clear();
                rastgeleSayi = new Random().Next(1, 101); // yeni rastgele sayı seçilir
            }
            else if (tahmin < rastgeleSayi)
            {
                kalanHak--;
                if (kalanHak == 0)
                {
                    MessageBox.Show("Maalesef, hakkınız bitti. Doğru cevap: " + rastgeleSayi);
                    tahminSayisi = 0;
                    kalanHak = 10;
                    gecmisTahminler.Clear();
                    rastgeleSayi = new Random().Next(1, 101); // yeni rastgele sayı seçilir
                }
                else
                {
                    MessageBox.Show("Daha yüksek bir sayı seçin. Kalan hak: " + kalanHak);
                }
            }
            else
            {
                kalanHak--;
                if (kalanHak == 0)
                {
                    MessageBox.Show("Maalesef, hakkınız bitti. Doğru cevap: " + rastgeleSayi);
                    tahminSayisi = 0;
                    kalanHak = 10;
                    gecmisTahminler.Clear();
                    rastgeleSayi = new Random().Next(1, 101); // yeni rastgele sayı seçilir
                }
                else
                {
                    MessageBox.Show("Daha düşük bir sayı seçin. Kalan hak: " + kalanHak);
                }
            }

            gecmisTahminlerListBox.Items.Clear();
            foreach (int t in gecmisTahminler)
            {
                gecmisTahminlerListBox.Items.Add(t);
            }
        }
    }
}
