namespace DövizAlSatDemo
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veriGetir = new System.Windows.Forms.Button();
            this.veriKyt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // veriGetir
            // 
            this.veriGetir.Location = new System.Drawing.Point(12, 315);
            this.veriGetir.Name = "veriGetir";
            this.veriGetir.Size = new System.Drawing.Size(231, 23);
            this.veriGetir.TabIndex = 1;
            this.veriGetir.Text = "Verileri Getir";
            this.veriGetir.UseVisualStyleBackColor = true;
            this.veriGetir.Click += new System.EventHandler(this.veriGetir_Click);
            // 
            // veriKyt
            // 
            this.veriKyt.Location = new System.Drawing.Point(12, 344);
            this.veriKyt.Name = "veriKyt";
            this.veriKyt.Size = new System.Drawing.Size(231, 23);
            this.veriKyt.TabIndex = 1;
            this.veriKyt.Text = "Değişiklikleri Kaydet";
            this.veriKyt.UseVisualStyleBackColor = true;
            this.veriKyt.Click += new System.EventHandler(this.veriKyt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.veriKyt);
            this.Controls.Add(this.veriGetir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button veriGetir;
        private System.Windows.Forms.Button veriKyt;
    }
}