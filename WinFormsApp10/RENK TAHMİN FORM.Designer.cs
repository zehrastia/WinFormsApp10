
namespace WinFormsApp10
{
    partial class RENK_TAHMİN_FORM
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
            TXTTAHMİNRENK = new TextBox();
            lblKalanHak = new Label();
            label3 = new Label();
            panel1 = new Panel();
            BTNKIRMIZI = new Button();
            BTNYEŞİL = new Button();
            BTNSARI = new Button();
            BTNMAVİ = new Button();
            LISTBOXSONUC = new ListBox();
            panel2 = new Panel();
            BTNTEMİZLE = new Button();
            BTNTAHMİNET = new Button();
            dgv_Skorlar = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Skorlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 27);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Tahmin";
            // 
            // TXTTAHMİNRENK
            // 
            TXTTAHMİNRENK.Location = new Point(267, 20);
            TXTTAHMİNRENK.Name = "TXTTAHMİNRENK";
            TXTTAHMİNRENK.Size = new Size(125, 27);
            TXTTAHMİNRENK.TabIndex = 1;
            // 
            // lblKalanHak
            // 
            lblKalanHak.AutoSize = true;
            lblKalanHak.Location = new Point(63, 77);
            lblKalanHak.Name = "lblKalanHak";
            lblKalanHak.Size = new Size(163, 20);
            lblKalanHak.TabIndex = 2;
            lblKalanHak.Text = "KALAN TAHMİN HAKKI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 77);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // panel1
            // 
            panel1.Controls.Add(BTNKIRMIZI);
            panel1.Controls.Add(BTNYEŞİL);
            panel1.Controls.Add(BTNSARI);
            panel1.Controls.Add(BTNMAVİ);
            panel1.ForeColor = Color.DarkOliveGreen;
            panel1.Location = new Point(134, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 96);
            panel1.TabIndex = 4;
            // 
            // BTNKIRMIZI
            // 
            BTNKIRMIZI.ForeColor = Color.Red;
            BTNKIRMIZI.Location = new Point(407, 42);
            BTNKIRMIZI.Name = "BTNKIRMIZI";
            BTNKIRMIZI.Size = new Size(94, 29);
            BTNKIRMIZI.TabIndex = 3;
            BTNKIRMIZI.Text = "KIRMIZI";
            BTNKIRMIZI.UseVisualStyleBackColor = true;
            BTNKIRMIZI.Click += RENKTAHMİN_CLİCK;
            // 
            // BTNYEŞİL
            // 
            BTNYEŞİL.ForeColor = Color.LimeGreen;
            BTNYEŞİL.Location = new Point(289, 42);
            BTNYEŞİL.Name = "BTNYEŞİL";
            BTNYEŞİL.Size = new Size(94, 29);
            BTNYEŞİL.TabIndex = 2;
            BTNYEŞİL.Text = "YEŞİL";
            BTNYEŞİL.UseVisualStyleBackColor = true;
            BTNYEŞİL.Click += RENKTAHMİN_CLİCK;
            // 
            // BTNSARI
            // 
            BTNSARI.ForeColor = Color.Yellow;
            BTNSARI.Location = new Point(164, 42);
            BTNSARI.Name = "BTNSARI";
            BTNSARI.Size = new Size(94, 29);
            BTNSARI.TabIndex = 1;
            BTNSARI.Text = "SARI";
            BTNSARI.UseVisualStyleBackColor = true;
            BTNSARI.Click += RENKTAHMİN_CLİCK;
            // 
            // BTNMAVİ
            // 
            BTNMAVİ.ForeColor = Color.Blue;
            BTNMAVİ.Location = new Point(39, 42);
            BTNMAVİ.Name = "BTNMAVİ";
            BTNMAVİ.Size = new Size(94, 29);
            BTNMAVİ.TabIndex = 0;
            BTNMAVİ.Text = "MAVİ";
            BTNMAVİ.UseVisualStyleBackColor = true;
            BTNMAVİ.Click += RENKTAHMİN_CLİCK;
            // 
            // LISTBOXSONUC
            // 
            LISTBOXSONUC.FormattingEnabled = true;
            LISTBOXSONUC.Location = new Point(204, 129);
            LISTBOXSONUC.Name = "LISTBOXSONUC";
            LISTBOXSONUC.Size = new Size(150, 104);
            LISTBOXSONUC.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(BTNTEMİZLE);
            panel2.Controls.Add(BTNTAHMİNET);
            panel2.Location = new Point(192, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 84);
            panel2.TabIndex = 6;
            // 
            // BTNTEMİZLE
            // 
            BTNTEMİZLE.Location = new Point(196, 30);
            BTNTEMİZLE.Name = "BTNTEMİZLE";
            BTNTEMİZLE.Size = new Size(94, 29);
            BTNTEMİZLE.TabIndex = 1;
            BTNTEMİZLE.Text = "TEMİZLE";
            BTNTEMİZLE.UseVisualStyleBackColor = true;
            BTNTEMİZLE.Click += BTNTEMİZLE_Click;
            // 
            // BTNTAHMİNET
            // 
            BTNTAHMİNET.Location = new Point(45, 29);
            BTNTAHMİNET.Name = "BTNTAHMİNET";
            BTNTAHMİNET.Size = new Size(94, 29);
            BTNTAHMİNET.TabIndex = 0;
            BTNTAHMİNET.Text = "TAHMİN ET";
            BTNTAHMİNET.UseVisualStyleBackColor = true;
            BTNTAHMİNET.Click += BTNTAHMİNET_Click;
            // 
            // dgv_Skorlar
            // 
            dgv_Skorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Skorlar.Location = new Point(449, 20);
            dgv_Skorlar.Name = "dgv_Skorlar";
            dgv_Skorlar.RowHeadersWidth = 51;
            dgv_Skorlar.Size = new Size(300, 188);
            dgv_Skorlar.TabIndex = 7;
            dgv_Skorlar.CellContentClick += dgv_Skorlar_CellContentClick;
            // 
            // RENK_TAHMİN_FORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Skorlar);
            Controls.Add(panel2);
            Controls.Add(LISTBOXSONUC);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(lblKalanHak);
            Controls.Add(TXTTAHMİNRENK);
            Controls.Add(label1);
            Name = "RENK_TAHMİN_FORM";
            Text = "RENK_TAHMİN_FORM";
            Load += RENK_TAHMİN_FORM_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Skorlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgv_Skorlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox TXTTAHMİNRENK;
        private Label lblKalanHak;
        private Label label3;
        private Panel panel1;
        private Button BTNKIRMIZI;
        private Button BTNYEŞİL;
        private Button BTNSARI;
        private Button BTNMAVİ;
        private ListBox LISTBOXSONUC;
        private Panel panel2;
        private Button BTNTEMİZLE;
        private Button BTNTAHMİNET;
        private DataGridView dgv_Skorlar;

        public EventHandler RENKTAHMİN_CLİCK { get; private set; }
    }
}