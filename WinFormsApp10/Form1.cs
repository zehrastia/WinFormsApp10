using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        // Bağlantı string'ini doğrudan burada tanımlayalım
        string connectionString = "Server=ZD15\\SQLEXPRESS;Initial Catalog=SAYI TAHMİN DATABASE;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            this.Hide();
        }

        private void BTNGİRİS_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = TXTKULLANICIADI.Text.Trim();
            string parola = TXTPAROLA.Text.Trim();

            // Boş kontrol
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(parola))  // ← DÜZELTME 1
            {
                MessageBox.Show("Lütfen kullanıcı adı ve parola giriniz!",
                              "Uyarı",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
          
            // Veritabanı kontrolü
            string ConnectionString = "Server=ZD15\\SQLEXPRESS; Database=SAYI TAHMİN DATABASE; Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sorgu = "SELECT COUNT(*) FROM oyuncu_bilgisi WHERE ad = @kullaniciAdi AND ParolaHash = @parola";

                    using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);  // ← DÜZELTME 2
                        cmd.Parameters.AddWithValue("@parola", parola);

                        int sonuc = (int)cmd.ExecuteScalar();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Giriş başarılı!",
                                          "Başarılı",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);

                            // Oyun modu formuna geç
                            MOD frmMod = new MOD();
                            frmMod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya parola hatalı!",
                                          "Hata",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                            // ← DÜZELTME 3: Burada form geçişi OLMAMALI!
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message,
                              "Hata",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message,
                              "Hata",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                MOD mOD = new MOD();
                mOD.ShowDialog();
                this.Hide();

            }
        }
    }
}
        