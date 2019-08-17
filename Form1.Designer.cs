namespace KimlikEntegrasyonu
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
            this.btnonay = new System.Windows.Forms.Button();
            this.txtboxtckimlik = new System.Windows.Forms.TextBox();
            this.txtboxad = new System.Windows.Forms.TextBox();
            this.txtboxdogumyılı = new System.Windows.Forms.TextBox();
            this.txtboxsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnonay
            // 
            this.btnonay.Location = new System.Drawing.Point(78, 170);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(75, 23);
            this.btnonay.TabIndex = 0;
            this.btnonay.Text = "Onay";
            this.btnonay.UseVisualStyleBackColor = true;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // txtboxtckimlik
            // 
            this.txtboxtckimlik.Location = new System.Drawing.Point(78, 54);
            this.txtboxtckimlik.Name = "txtboxtckimlik";
            this.txtboxtckimlik.Size = new System.Drawing.Size(207, 20);
            this.txtboxtckimlik.TabIndex = 1;
            // 
            // txtboxad
            // 
            this.txtboxad.Location = new System.Drawing.Point(78, 83);
            this.txtboxad.Name = "txtboxad";
            this.txtboxad.Size = new System.Drawing.Size(207, 20);
            this.txtboxad.TabIndex = 2;
            // 
            // txtboxdogumyılı
            // 
            this.txtboxdogumyılı.Location = new System.Drawing.Point(78, 135);
            this.txtboxdogumyılı.Name = "txtboxdogumyılı";
            this.txtboxdogumyılı.Size = new System.Drawing.Size(100, 20);
            this.txtboxdogumyılı.TabIndex = 3;
            // 
            // txtboxsoyad
            // 
            this.txtboxsoyad.Location = new System.Drawing.Point(78, 109);
            this.txtboxsoyad.Name = "txtboxsoyad";
            this.txtboxsoyad.Size = new System.Drawing.Size(207, 20);
            this.txtboxsoyad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "tc kimlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "dogum yılı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kimlik Doğrulama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxsoyad);
            this.Controls.Add(this.txtboxdogumyılı);
            this.Controls.Add(this.txtboxad);
            this.Controls.Add(this.txtboxtckimlik);
            this.Controls.Add(this.btnonay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.TextBox txtboxtckimlik;
        private System.Windows.Forms.TextBox txtboxad;
        private System.Windows.Forms.TextBox txtboxdogumyılı;
        private System.Windows.Forms.TextBox txtboxsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

