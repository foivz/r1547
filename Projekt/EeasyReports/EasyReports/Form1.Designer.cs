namespace EasyReports
{
    partial class EasyReports_ulaznaForma
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
            this.korisnik = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.textKorisnik = new System.Windows.Forms.TextBox();
            this.textLozinka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.Location = new System.Drawing.Point(81, 30);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(44, 13);
            this.korisnik.TabIndex = 1;
            this.korisnik.Text = "Korisnik";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Location = new System.Drawing.Point(232, 30);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(44, 13);
            this.lozinka.TabIndex = 2;
            this.lozinka.Text = "Lozinka";
            // 
            // textKorisnik
            // 
            this.textKorisnik.Location = new System.Drawing.Point(58, 60);
            this.textKorisnik.Name = "textKorisnik";
            this.textKorisnik.Size = new System.Drawing.Size(100, 20);
            this.textKorisnik.TabIndex = 3;
            // 
            // textLozinka
            // 
            this.textLozinka.Location = new System.Drawing.Point(208, 60);
            this.textLozinka.Name = "textLozinka";
            this.textLozinka.Size = new System.Drawing.Size(100, 20);
            this.textLozinka.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EasyReports_ulaznaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textLozinka);
            this.Controls.Add(this.textKorisnik);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnik);
            this.Name = "EasyReports_ulaznaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyReports - ulazna forma";
            this.Load += new System.EventHandler(this.EasyReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.TextBox textKorisnik;
        private System.Windows.Forms.TextBox textLozinka;
        private System.Windows.Forms.Button button1;
    }
}

