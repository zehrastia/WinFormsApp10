using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNGİRİS = new Button();
            LBLKULLANICIADI = new Label();
            LBLPAROLA = new Label();
            TXTKULLANICIADI = new TextBox();
            TXTPAROLA = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // BTNGİRİS
            // 
            BTNGİRİS.Location = new Point(240, 210);
            BTNGİRİS.Name = "BTNGİRİS";
            BTNGİRİS.Size = new Size(94, 24);
            BTNGİRİS.TabIndex = 0;
            BTNGİRİS.Text = "GİRİŞ ";
            BTNGİRİS.UseVisualStyleBackColor = true;
            BTNGİRİS.Click += BTNGİRİS_Click;
            // 
            // LBLKULLANICIADI
            // 
            LBLKULLANICIADI.AutoSize = true;
            LBLKULLANICIADI.Location = new Point(142, 87);
            LBLKULLANICIADI.Name = "LBLKULLANICIADI";
            LBLKULLANICIADI.Size = new Size(109, 20);
            LBLKULLANICIADI.TabIndex = 1;
            LBLKULLANICIADI.Text = "KULLANICI ADI";
            // 
            // LBLPAROLA
            // 
            LBLPAROLA.AutoSize = true;
            LBLPAROLA.Location = new Point(142, 137);
            LBLPAROLA.Name = "LBLPAROLA";
            LBLPAROLA.Size = new Size(63, 20);
            LBLPAROLA.TabIndex = 2;
            LBLPAROLA.Text = "PAROLA";
            // 
            // TXTKULLANICIADI
            // 
            TXTKULLANICIADI.Location = new Point(310, 87);
            TXTKULLANICIADI.Name = "TXTKULLANICIADI";
            TXTKULLANICIADI.Size = new Size(125, 27);
            TXTKULLANICIADI.TabIndex = 3;
            // 
            // TXTPAROLA
            // 
            TXTPAROLA.Location = new Point(310, 137);
            TXTPAROLA.Name = "TXTPAROLA";
            TXTPAROLA.Size = new Size(125, 27);
            TXTPAROLA.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(425, 214);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "KAYITOLMADINIZMI";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(TXTPAROLA);
            Controls.Add(TXTKULLANICIADI);
            Controls.Add(LBLPAROLA);
            Controls.Add(LBLKULLANICIADI);
            Controls.Add(BTNGİRİS);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNGİRİS;
        private Label LBLKULLANICIADI;
        private Label LBLPAROLA;
        private TextBox TXTKULLANICIADI;
        private TextBox TXTPAROLA;
        private LinkLabel linkLabel1;
    }
}
