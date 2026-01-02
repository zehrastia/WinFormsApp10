using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace WinFormsApp10
{
   
    public partial class RENK_TAHMİN_FORM : Form
    {
        // Değişken Tanımlamaları
        private DateTime oyunBaslangic;
        private Stopwatch oyunSuresi;
        private string GizliRenkKodu = "";
        private int KalanHak = 10;
        private const int ToplamHak = 10;
        private const int HaneSayisi = 4;

        // Renk harfleri: K=Kırmızı, M=Mavi, Y=Yeşil, S=Sarı
        private readonly string[] MevcutRenkler = { "K", "M", "Y", "S" };

        // Veritabanı Bağlantı Cümlesi
        private readonly string connStr = @"Server=ZD15\SQLEXPRESS;Database=SAYI TAHMİN DATABASE;Trusted_Connection=True;";

        public RENK_TAHMİN_FORM()
        {
            InitializeComponent();
        }

        private void RENK_TAHMİN_FORM_Load(object sender, EventArgs e)
        {
            // Buton isimleriniz farklıysa burayı güncelleyin (btnKirmizi, btnSari vb.)
            BTNKIRMIZI.Click += RenkButonu_Click;
            BTNMAVİ.Click += RenkButonu_Click;
            BTNYEŞİL.Click += RenkButonu_Click;
            BTNSARI.Click += RenkButonu_Click;
            SkorlariGuncelle();
            YeniOyunBaslat();
        }

        private void YeniOyunBaslat()
        {
            oyunBaslangic = DateTime.Now;
            oyunSuresi = new Stopwatch();
            oyunSuresi.Start();

            // Rastgele 4 farklı renk seç (Benzersiz olması için)
            Random rnd = new Random();
            List<string> seciliRenkler = new List<string>();

            while (seciliRenkler.Count < HaneSayisi)
            {
                string rastgeleRenk = MevcutRenkler[rnd.Next(MevcutRenkler.Length)];
                if (!seciliRenkler.Contains(rastgeleRenk))
                {
                    seciliRenkler.Add(rastgeleRenk);
                }
            }

            GizliRenkKodu = string.Join("", seciliRenkler);
            KalanHak = ToplamHak;

            // UI Temizleme
            TXTTAHMİNRENK.Clear();
            TXTTAHMİNRENK.MaxLength = HaneSayisi;
            lblKalanHak.Text = $"Kalan Hak: {KalanHak}";
            lblKalanHak.ForeColor = Color.Black;
            LISTBOXSONUC.Items.Clear();

            LISTBOXSONUC.Items.Add("🎮 RENK TAHMİN OYUNU");
            LISTBOXSONUC.Items.Add("━━━━━━━━━━━━━━━━━━━━");
            LISTBOXSONUC.Items.Add(" K=Kırmızı, M=Mavi, Y=Yeşil, S=Sarı");
            LISTBOXSONUC.Items.Add("+: Doğru Yer | -: Yanlış Yer");
            LISTBOXSONUC.Items.Add("━━━━━━━━━━━━━━━━━━━━");

            TXTTAHMİNRENK.Focus();
        }

        private void RenkButonu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // btn.Text'in "K", "M", "Y" veya "S" olduğundan emin olun
            if (btn != null && TXTTAHMİNRENK.Text.Length < HaneSayisi)
            {
                TXTTAHMİNRENK.Text += btn.Text;
                Button basilanButon = sender as Button;
    if (basilanButon == null) return;

    // Metin kutusunda 4 karakterden az yer varsa ekleme yap
    if (TXTTAHMİNRENK.Text.Length < HaneSayisi)
    {
        string eklenecekHarf = "";
        string butonAdi = basilanButon.Name.ToUpper();

        // Buton ismine göre hangi harfin ekleneceğini belirle
        if (butonAdi.Contains("KIRMIZI")) eklenecekHarf = "K";
        else if (butonAdi.Contains("MAVI") || butonAdi.Contains("MAVİ")) eklenecekHarf = "M";
        else if (butonAdi.Contains("YESIL") || butonAdi.Contains("YEŞİL")) eklenecekHarf = "Y";
        else if (butonAdi.Contains("SARI")) eklenecekHarf = "S";

        TXTTAHMİNRENK.Text += eklenecekHarf;
    }
            }
        }

        private void BTNTAHMİNET_Click(object sender, EventArgs e)
        {
            Button basilanButon = sender as Button;
            if (basilanButon == null) return;

            // Metin kutusunda 4 karakterden az yer varsa ekleme yap
            if (TXTTAHMİNRENK.Text.Length < HaneSayisi)
            {
                string eklenecekHarf = "";
                string butonAdi = basilanButon.Name.ToUpper();

                // Buton ismine göre hangi harfin ekleneceğini belirle
                if (butonAdi.Contains("KIRMIZI")) eklenecekHarf = "K";
                else if (butonAdi.Contains("MAVI") || butonAdi.Contains("MAVİ")) eklenecekHarf = "M";
                else if (butonAdi.Contains("YESIL") || butonAdi.Contains("YEŞİL")) eklenecekHarf = "Y";
                else if (butonAdi.Contains("SARI")) eklenecekHarf = "S";

                TXTTAHMİNRENK.Text += eklenecekHarf;
            }
            string tahmin = TXTTAHMİNRENK.Text.ToUpper().Trim();

            if (tahmin.Length != HaneSayisi)
            {
                MessageBox.Show($"Lütfen {HaneSayisi} renk seçin!", "Eksik Seçim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Skor hesaplama mantığı
            int artiSayisi = 0;
            int eksiSayisi = 0;
            bool[] gizliKullanildi = new bool[HaneSayisi];
            bool[] tahminKullanildi = new bool[HaneSayisi];

            // 1. Adım: Tam eşleşmeler (+)
            for (int i = 0; i < HaneSayisi; i++)
            {
                if (tahmin[i] == GizliRenkKodu[i])
                {
                    artiSayisi++;
                    gizliKullanildi[i] = true;
                    tahminKullanildi[i] = true;
                }
            }

            // 2. Adım: Renk var ama yeri yanlış (-)
            for (int i = 0; i < HaneSayisi; i++)
            {
                if (!tahminKullanildi[i])
                {
                    for (int j = 0; j < HaneSayisi; j++)
                    {
                        if (!gizliKullanildi[j] && tahmin[i] == GizliRenkKodu[j])
                        {
                            eksiSayisi++;
                            gizliKullanildi[j] = true;
                            break;
                        }
                    }
                }
            }

            string sonucSatiri = $"{tahmin} → " + new string('+', artiSayisi) + new string('-', eksiSayisi);
            if (artiSayisi == 0 && eksiSayisi == 0) sonucSatiri += " ✗";

            LISTBOXSONUC.Items.Add(sonucSatiri);

            // Kazanma Kontrolü
            if (artiSayisi == HaneSayisi)
            {
                oyunSuresi.Stop();
                int gecenSure = (int)oyunSuresi.Elapsed.TotalSeconds;

                string oyuncuAdi = Interaction.InputBox("Tebrikler Kazandınız! Adınızı girin:", "Oyun Bitti", "Oyuncu");
                if (!string.IsNullOrEmpty(oyuncuAdi))
                {
                    SkorKaydet(oyuncuAdi, gecenSure);
                    SkorlariGuncelle();
                }

                YeniOyunBaslat();
                return;
            }

            KalanHak--;
            lblKalanHak.Text = $"Kalan Hak: {KalanHak}";

            if (KalanHak <= 2) lblKalanHak.ForeColor = Color.Red;
            else if (KalanHak <= 5) lblKalanHak.ForeColor = Color.Orange;

            // Kaybetme Kontrolü
            if (KalanHak <= 0)
            {
                MessageBox.Show($"Maalesef bitti! Doğru kod: {GizliRenkKodu}", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YeniOyunBaslat();
            }

            TXTTAHMİNRENK.Clear();
            TXTTAHMİNRENK.Focus();
        }

        private void BTNTEMİZLE_Click(object sender, EventArgs e)
        {
            TXTTAHMİNRENK.Clear();
        }

        private void SkorKaydet(string oyuncuAdi, int sureSaniye)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "INSERT INTO Skorlar (OyuncuAdi, SureSaniye, TarihSaat) VALUES (@ad, @sure, @tarih)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ad", oyuncuAdi);
                    cmd.Parameters.AddWithValue("@sure", sureSaniye);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }

        private void SkorlariGuncelle()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT OyuncuAdi, SureSaniye, TarihSaat FROM Skorlar ORDER BY SureSaniye ASC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                dgv_Skorlar.DataSource = dt;
            }
            catch { /* Tablo henüz yoksa hata vermemesi için */ }
        }
    }
}