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
    public partial class MOD : Form
    {
        public MOD()
        {
            InitializeComponent();
        }

        private void BTNSAYITAHMİN_Click(object sender, EventArgs e)
        {
            SAYI_TAHMİN_FORM sAYI_TAHMİN_ = new SAYI_TAHMİN_FORM(3);
            sAYI_TAHMİN_.ShowDialog();
            this.Hide();
        }

        private void BTNRENKTAHMİN_Click(object sender, EventArgs e)
        {
            // 1. Oyun formundan bir kopya oluştur
            RENK_TAHMİN_FORM oyunFormu = new RENK_TAHMİN_FORM();

            // 2. Ana formu gizle (İsteğe bağlı)
            this.Hide();

            // 3. Oyun formunu göster
            // Show() kullanırsan kod hemen alt satıra geçer. 
            // ShowDialog() kullanırsan form kapanana kadar bekler.
            oyunFormu.ShowDialog();

            // 4. Oyun formu kapandığında ana formu tekrar göster (İsteğe bağlı)
            this.Show();
        }
    }
}
