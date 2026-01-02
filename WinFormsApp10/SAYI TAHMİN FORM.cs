using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class SAYI_TAHMİN_FORM : Form
    {
        // --- OYUN DEĞİŞKENLERİ ---
        private string gizliSayi = "";
        private int haneSayisi = 3; // Mod seçimine göre bu değer 3, 4 veya 5 olur
        private int kalanHak = 10;
       

        public SAYI_TAHMİN_FORM(int secilenHane)
        {
            InitializeComponent();
            this.haneSayisi = secilenHane;
            YeniOyunBaslat();

        }
        // --- 1. RASTGELE SAYI ÜRETME (Tekrarsız Rakamlar) ---
        private void YeniOyunBaslat()
        {
            Random rnd = new Random();
            List<int> rakamlar = new List<int>();

            // İlk rakam 0 olmasın
            rakamlar.Add(rnd.Next(1, 10));

            while (rakamlar.Count < haneSayisi)
            {
                int yeniRakam = rnd.Next(0, 10);
                if (!rakamlar.Contains(yeniRakam)) // Tekrarsız olması için kontrol
                {
                    rakamlar.Add(yeniRakam);
                }
            }

            gizliSayi = string.Join("", rakamlar);
            tbxtahmin.Clear();
            lblsonuc.Text = "Tahmininizi yapın...";
            lblkalanhak.Text = "Kalan Hak: 10";
            kalanHak = 10;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SAYI_TAHMİN_FORM_Load(object sender, EventArgs e)
        {

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            tbxtahmin.Clear();
        }

        private void btntahminet_Click(object sender, EventArgs e)
        {
            string tahmin = tbxtahmin.Text;

            if (tahmin.Length != haneSayisi)
            {
                MessageBox.Show($"Lütfen {haneSayisi} haneli bir sayı girin!");
                return;
            }

            int arti = 0; // Hem rakam hem yer doğru
            int eksi = 0; // Rakam var ama yer yanlış

            for (int i = 0; i < haneSayisi; i++)
            {
                if (tahmin[i] == gizliSayi[i])
                {
                    arti++;
                }
                else if (gizliSayi.Contains(tahmin[i].ToString()))
                {
                    eksi++;
                }
            }

            // Sonucu label'da göster (Örn: +2 -1)
            lblsonuc.Text = $"Sonuç: +{arti} | -{eksi}";

            // Listeye geçmişi ekle
            lbxgecmis.Items.Insert(0, $"{tahmin} -> +{arti} | -{eksi}");

            // Kazanma veya Kaybetme Kontrolü
            if (arti == haneSayisi)
            {
                MessageBox.Show("TEBRİKLER! Sayıyı buldunuz.");
                // Burada veritabanına skor kaydetme metodunu çağıracağız
                this.Close();
            }
            else
            {
                kalanHak--;
                lblkalanhak.Text = "Kalan Hak: " + kalanHak;
                if (kalanHak <= 0)
                {
                    MessageBox.Show("Maalesef haklarınız bitti! Sayı: " + gizliSayi);
                    this.Close();
                }
            }

            tbxtahmin.Clear();

        }

        private void sayibutonu_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Basılan butonu yakala

            // Eğer textbox dolmadıysa butondaki yazıyı ekle
            if (tbxtahmin.Text.Length < haneSayisi)
            {
                tbxtahmin.Text += btn.Text;
            }
        }
    }
}
