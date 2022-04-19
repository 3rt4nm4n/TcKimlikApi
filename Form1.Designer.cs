
namespace TcKimlikApi
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
            this.TextBox_TCNO = new System.Windows.Forms.TextBox();
            this.TextBox_Isim = new System.Windows.Forms.TextBox();
            this.TextBox_Soyisim = new System.Windows.Forms.TextBox();
            this.TextBox_Yil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_TCNO
            // 
            this.TextBox_TCNO.Location = new System.Drawing.Point(222, 37);
            this.TextBox_TCNO.Name = "TextBox_TCNO";
            this.TextBox_TCNO.Size = new System.Drawing.Size(347, 22);
            this.TextBox_TCNO.TabIndex = 0;
            // 
            // TextBox_Isim
            // 
            this.TextBox_Isim.Location = new System.Drawing.Point(222, 91);
            this.TextBox_Isim.Name = "TextBox_Isim";
            this.TextBox_Isim.Size = new System.Drawing.Size(347, 22);
            this.TextBox_Isim.TabIndex = 1;
            // 
            // TextBox_Soyisim
            // 
            this.TextBox_Soyisim.Location = new System.Drawing.Point(222, 155);
            this.TextBox_Soyisim.Name = "TextBox_Soyisim";
            this.TextBox_Soyisim.Size = new System.Drawing.Size(347, 22);
            this.TextBox_Soyisim.TabIndex = 2;
            // 
            // TextBox_Yil
            // 
            this.TextBox_Yil.Location = new System.Drawing.Point(222, 214);
            this.TextBox_Yil.Name = "TextBox_Yil";
            this.TextBox_Yil.Size = new System.Drawing.Size(347, 22);
            this.TextBox_Yil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYISIM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "YIL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kontrol Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Yil);
            this.Controls.Add(this.TextBox_Soyisim);
            this.Controls.Add(this.TextBox_Isim);
            this.Controls.Add(this.TextBox_TCNO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_TCNO;
        private System.Windows.Forms.TextBox TextBox_Isim;
        private System.Windows.Forms.TextBox TextBox_Soyisim;
        private System.Windows.Forms.TextBox TextBox_Yil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

