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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BTNKAYITOL_Click(object sender, EventArgs e)
        {
            Form1 frm1= new Form1();
            frm1.ShowDialog();
            this.Hide();
        }
    }
}
