namespace WinFormsApp10
{
    partial class Form2
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
            BTNKAYITOL = new Button();
            LBLKULLANICIADI = new Label();
            LBLKULLANICISOYADI = new Label();
            LBLEPOSTA = new Label();
            LBLTELEFON = new Label();
            LBLPAROLA = new Label();
            TXTKULLANICIADIFORM2 = new TextBox();
            TXTKULLANICISOYAD = new TextBox();
            TXTEPOSTA = new TextBox();
            TXTTELEFON = new TextBox();
            TXTKULLANICIPAROLAFORM2 = new TextBox();
            SuspendLayout();
            // 
            // BTNKAYITOL
            // 
            BTNKAYITOL.Location = new Point(332, 308);
            BTNKAYITOL.Name = "BTNKAYITOL";
            BTNKAYITOL.Size = new Size(94, 29);
            BTNKAYITOL.TabIndex = 0;
            BTNKAYITOL.Text = "KAYIT OL";
            BTNKAYITOL.UseVisualStyleBackColor = true;
            BTNKAYITOL.Click += BTNKAYITOL_Click;
            // 
            // LBLKULLANICIADI
            // 
            LBLKULLANICIADI.AutoSize = true;
            LBLKULLANICIADI.Location = new Point(128, 52);
            LBLKULLANICIADI.Name = "LBLKULLANICIADI";
            LBLKULLANICIADI.Size = new Size(109, 20);
            LBLKULLANICIADI.TabIndex = 1;
            LBLKULLANICIADI.Text = "KULLANICI ADI";
            // 
            // LBLKULLANICISOYADI
            // 
            LBLKULLANICISOYADI.AutoSize = true;
            LBLKULLANICISOYADI.Location = new Point(128, 105);
            LBLKULLANICISOYADI.Name = "LBLKULLANICISOYADI";
            LBLKULLANICISOYADI.Size = new Size(135, 20);
            LBLKULLANICISOYADI.TabIndex = 2;
            LBLKULLANICISOYADI.Text = "KULLANICI SOYADI";
            // 
            // LBLEPOSTA
            // 
            LBLEPOSTA.AutoSize = true;
            LBLEPOSTA.Location = new Point(128, 148);
            LBLEPOSTA.Name = "LBLEPOSTA";
            LBLEPOSTA.Size = new Size(65, 20);
            LBLEPOSTA.TabIndex = 3;
            LBLEPOSTA.Text = "E POSTA";
            // 
            // LBLTELEFON
            // 
            LBLTELEFON.AutoSize = true;
            LBLTELEFON.Location = new Point(128, 186);
            LBLTELEFON.Name = "LBLTELEFON";
            LBLTELEFON.Size = new Size(69, 20);
            LBLTELEFON.TabIndex = 4;
            LBLTELEFON.Text = "TELEFON";
            // 
            // LBLPAROLA
            // 
            LBLPAROLA.AutoSize = true;
            LBLPAROLA.Location = new Point(128, 229);
            LBLPAROLA.Name = "LBLPAROLA";
            LBLPAROLA.Size = new Size(63, 20);
            LBLPAROLA.TabIndex = 5;
            LBLPAROLA.Text = "PAROLA";
            // 
            // TXTKULLANICIADIFORM2
            // 
            TXTKULLANICIADIFORM2.Location = new Point(311, 45);
            TXTKULLANICIADIFORM2.Name = "TXTKULLANICIADIFORM2";
            TXTKULLANICIADIFORM2.Size = new Size(125, 27);
            TXTKULLANICIADIFORM2.TabIndex = 6;
            // 
            // TXTKULLANICISOYAD
            // 
            TXTKULLANICISOYAD.Location = new Point(311, 98);
            TXTKULLANICISOYAD.Name = "TXTKULLANICISOYAD";
            TXTKULLANICISOYAD.Size = new Size(125, 27);
            TXTKULLANICISOYAD.TabIndex = 7;
            // 
            // TXTEPOSTA
            // 
            TXTEPOSTA.Location = new Point(311, 141);
            TXTEPOSTA.Name = "TXTEPOSTA";
            TXTEPOSTA.Size = new Size(125, 27);
            TXTEPOSTA.TabIndex = 8;
            // 
            // TXTTELEFON
            // 
            TXTTELEFON.Location = new Point(311, 186);
            TXTTELEFON.Name = "TXTTELEFON";
            TXTTELEFON.Size = new Size(125, 27);
            TXTTELEFON.TabIndex = 9;
            // 
            // TXTKULLANICIPAROLAFORM2
            // 
            TXTKULLANICIPAROLAFORM2.Location = new Point(311, 229);
            TXTKULLANICIPAROLAFORM2.Name = "TXTKULLANICIPAROLAFORM2";
            TXTKULLANICIPAROLAFORM2.Size = new Size(125, 27);
            TXTKULLANICIPAROLAFORM2.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TXTKULLANICIPAROLAFORM2);
            Controls.Add(TXTTELEFON);
            Controls.Add(TXTEPOSTA);
            Controls.Add(TXTKULLANICISOYAD);
            Controls.Add(TXTKULLANICIADIFORM2);
            Controls.Add(LBLPAROLA);
            Controls.Add(LBLTELEFON);
            Controls.Add(LBLEPOSTA);
            Controls.Add(LBLKULLANICISOYADI);
            Controls.Add(LBLKULLANICIADI);
            Controls.Add(BTNKAYITOL);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNKAYITOL;
        private Label LBLKULLANICIADI;
        private Label LBLKULLANICISOYADI;
        private Label LBLEPOSTA;
        private Label LBLTELEFON;
        private Label LBLPAROLA;
        private TextBox TXTKULLANICIADIFORM2;
        private TextBox TXTKULLANICISOYAD;
        private TextBox TXTEPOSTA;
        private TextBox TXTTELEFON;
        private TextBox TXTKULLANICIPAROLAFORM2;
    }
}