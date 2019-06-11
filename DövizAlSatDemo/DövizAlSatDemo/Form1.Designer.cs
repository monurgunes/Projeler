namespace DövizAlSatDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textGrsAd = new System.Windows.Forms.TextBox();
            this.textGrsSfr = new System.Windows.Forms.TextBox();
            this.textKytAd = new System.Windows.Forms.TextBox();
            this.textKytSfr = new System.Windows.Forms.TextBox();
            this.textKytsfrT = new System.Windows.Forms.TextBox();
            this.btnGrs = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dovizBox = new System.Windows.Forms.ComboBox();
            this.bakiyeBox = new System.Windows.Forms.ComboBox();
            this.btnKyt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre Tekrar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Döviz Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Miktar :";
            // 
            // textGrsAd
            // 
            this.textGrsAd.Location = new System.Drawing.Point(107, 27);
            this.textGrsAd.Name = "textGrsAd";
            this.textGrsAd.Size = new System.Drawing.Size(100, 20);
            this.textGrsAd.TabIndex = 3;
            // 
            // textGrsSfr
            // 
            this.textGrsSfr.Location = new System.Drawing.Point(107, 51);
            this.textGrsSfr.Name = "textGrsSfr";
            this.textGrsSfr.Size = new System.Drawing.Size(100, 20);
            this.textGrsSfr.TabIndex = 3;
            // 
            // textKytAd
            // 
            this.textKytAd.Location = new System.Drawing.Point(107, 152);
            this.textKytAd.Name = "textKytAd";
            this.textKytAd.Size = new System.Drawing.Size(100, 20);
            this.textKytAd.TabIndex = 3;
            // 
            // textKytSfr
            // 
            this.textKytSfr.Location = new System.Drawing.Point(107, 176);
            this.textKytSfr.Name = "textKytSfr";
            this.textKytSfr.Size = new System.Drawing.Size(100, 20);
            this.textKytSfr.TabIndex = 3;
            // 
            // textKytsfrT
            // 
            this.textKytsfrT.Location = new System.Drawing.Point(107, 200);
            this.textKytsfrT.Name = "textKytsfrT";
            this.textKytsfrT.Size = new System.Drawing.Size(100, 20);
            this.textKytsfrT.TabIndex = 3;
            // 
            // btnGrs
            // 
            this.btnGrs.Location = new System.Drawing.Point(107, 77);
            this.btnGrs.Name = "btnGrs";
            this.btnGrs.Size = new System.Drawing.Size(100, 23);
            this.btnGrs.TabIndex = 4;
            this.btnGrs.Text = "Giriş Yap";
            this.btnGrs.UseVisualStyleBackColor = true;
            this.btnGrs.Click += new System.EventHandler(this.btnGrs_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hesabını Yok Mu ?";
            // 
            // dovizBox
            // 
            this.dovizBox.FormattingEnabled = true;
            this.dovizBox.Location = new System.Drawing.Point(107, 226);
            this.dovizBox.Name = "dovizBox";
            this.dovizBox.Size = new System.Drawing.Size(100, 21);
            this.dovizBox.TabIndex = 6;
            // 
            // bakiyeBox
            // 
            this.bakiyeBox.FormattingEnabled = true;
            this.bakiyeBox.Location = new System.Drawing.Point(107, 250);
            this.bakiyeBox.Name = "bakiyeBox";
            this.bakiyeBox.Size = new System.Drawing.Size(100, 21);
            this.bakiyeBox.TabIndex = 7;
            // 
            // btnKyt
            // 
            this.btnKyt.Location = new System.Drawing.Point(107, 277);
            this.btnKyt.Name = "btnKyt";
            this.btnKyt.Size = new System.Drawing.Size(100, 23);
            this.btnKyt.TabIndex = 8;
            this.btnKyt.Text = "Kayıt Ol";
            this.btnKyt.UseVisualStyleBackColor = true;
            this.btnKyt.Click += new System.EventHandler(this.btnKyt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 17);
            this.button1.TabIndex = 9;
            this.button1.Text = "doldur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKyt);
            this.Controls.Add(this.bakiyeBox);
            this.Controls.Add(this.dovizBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGrs);
            this.Controls.Add(this.textKytsfrT);
            this.Controls.Add(this.textKytSfr);
            this.Controls.Add(this.textKytAd);
            this.Controls.Add(this.textGrsSfr);
            this.Controls.Add(this.textGrsAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textGrsAd;
        private System.Windows.Forms.TextBox textGrsSfr;
        private System.Windows.Forms.TextBox textKytAd;
        private System.Windows.Forms.TextBox textKytSfr;
        private System.Windows.Forms.TextBox textKytsfrT;
        private System.Windows.Forms.Button btnGrs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dovizBox;
        private System.Windows.Forms.ComboBox bakiyeBox;
        private System.Windows.Forms.Button btnKyt;
        private System.Windows.Forms.Button button1;
    }
}

