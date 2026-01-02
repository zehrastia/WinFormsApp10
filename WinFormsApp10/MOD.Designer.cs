namespace WinFormsApp10
{
    partial class MOD
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
            BTNSAYITAHMİN = new Button();
            BTNRENKTAHMİN = new Button();
            SuspendLayout();
            // 
            // BTNSAYITAHMİN
            // 
            BTNSAYITAHMİN.Location = new Point(208, 107);
            BTNSAYITAHMİN.Name = "BTNSAYITAHMİN";
            BTNSAYITAHMİN.Size = new Size(124, 55);
            BTNSAYITAHMİN.TabIndex = 0;
            BTNSAYITAHMİN.Text = "SAYI TAHMİN";
            BTNSAYITAHMİN.UseVisualStyleBackColor = true;
            BTNSAYITAHMİN.Click += BTNSAYITAHMİN_Click;
            // 
            // BTNRENKTAHMİN
            // 
            BTNRENKTAHMİN.Location = new Point(414, 107);
            BTNRENKTAHMİN.Name = "BTNRENKTAHMİN";
            BTNRENKTAHMİN.Size = new Size(147, 55);
            BTNRENKTAHMİN.TabIndex = 1;
            BTNRENKTAHMİN.Text = "RENK TAHMİN";
            BTNRENKTAHMİN.UseVisualStyleBackColor = true;
            BTNRENKTAHMİN.Click += BTNRENKTAHMİN_Click;
            // 
            // MOD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNRENKTAHMİN);
            Controls.Add(BTNSAYITAHMİN);
            Name = "MOD";
            Text = "MOD";
            ResumeLayout(false);
        }

        #endregion

        private Button BTNSAYITAHMİN;
        private Button BTNRENKTAHMİN;
    }
}