namespace sayi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rasgeleOlustur = new System.Windows.Forms.Button();
            this.hesapla = new System.Windows.Forms.Button();
            this.hedefSayi = new System.Windows.Forms.TextBox();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.sayi3 = new System.Windows.Forms.TextBox();
            this.sayi4 = new System.Windows.Forms.TextBox();
            this.sayi5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Ödevi";
            // 
            // rasgeleOlustur
            // 
            this.rasgeleOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rasgeleOlustur.Location = new System.Drawing.Point(26, 222);
            this.rasgeleOlustur.Name = "rasgeleOlustur";
            this.rasgeleOlustur.Size = new System.Drawing.Size(259, 44);
            this.rasgeleOlustur.TabIndex = 2;
            this.rasgeleOlustur.Text = "Rastgele Sayılar Oluştur";
            this.rasgeleOlustur.UseVisualStyleBackColor = true;
            this.rasgeleOlustur.Click += new System.EventHandler(this.rasgeleOlustur_Click);
            // 
            // hesapla
            // 
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(291, 222);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(271, 44);
            this.hesapla.TabIndex = 2;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // hedefSayi
            // 
            this.hedefSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedefSayi.Location = new System.Drawing.Point(211, 105);
            this.hedefSayi.MaxLength = 3;
            this.hedefSayi.Name = "hedefSayi";
            this.hedefSayi.Size = new System.Drawing.Size(166, 32);
            this.hedefSayi.TabIndex = 3;
            this.hedefSayi.Text = "Hedeflenen Sayı";
            this.hedefSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi1
            // 
            this.sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi1.Location = new System.Drawing.Point(26, 161);
            this.sayi1.MaxLength = 3;
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(98, 26);
            this.sayi1.TabIndex = 3;
            this.sayi1.Text = "Sayı 1";
            this.sayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi2
            // 
            this.sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2.Location = new System.Drawing.Point(130, 161);
            this.sayi2.MaxLength = 3;
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(98, 26);
            this.sayi2.TabIndex = 3;
            this.sayi2.Text = "Sayı 2";
            this.sayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi3
            // 
            this.sayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi3.Location = new System.Drawing.Point(234, 161);
            this.sayi3.MaxLength = 3;
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(98, 26);
            this.sayi3.TabIndex = 3;
            this.sayi3.Text = "Sayı 3";
            this.sayi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi4
            // 
            this.sayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi4.Location = new System.Drawing.Point(338, 161);
            this.sayi4.MaxLength = 3;
            this.sayi4.Name = "sayi4";
            this.sayi4.Size = new System.Drawing.Size(98, 26);
            this.sayi4.TabIndex = 3;
            this.sayi4.Text = "Sayı 4";
            this.sayi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi5
            // 
            this.sayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi5.Location = new System.Drawing.Point(442, 161);
            this.sayi5.MaxLength = 3;
            this.sayi5.Name = "sayi5";
            this.sayi5.Size = new System.Drawing.Size(120, 26);
            this.sayi5.TabIndex = 3;
            this.sayi5.Tag = "";
            this.sayi5.Text = "Sayı 5(çift hane)";
            this.sayi5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 296);
            this.Controls.Add(this.sayi5);
            this.Controls.Add(this.sayi4);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.hedefSayi);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.rasgeleOlustur);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rasgeleOlustur;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox hedefSayi;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.TextBox sayi3;
        private System.Windows.Forms.TextBox sayi4;
        private System.Windows.Forms.TextBox sayi5;
    }
}

