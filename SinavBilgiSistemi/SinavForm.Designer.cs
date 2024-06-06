

/****************************************************************************
 **                              DÜZCE ÜNİVERSİTESİ
 **                          LİSANSÜSTÜ EĞİTİM ENSTİTÜSÜ
 **                       BİLGİSAYAR MÜHENDİLİĞİ ANABİLİM DALI
 **                       ÖĞRENCİ ADI :          ARDA ÖZYAMAN
 **                       ÖĞRENCİ NUMARASI :     2345007016
 **
 ****************************************************************************/

namespace SinavBilgiSistemi
{
    partial class SinavForm
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
            this.lblSoru = new System.Windows.Forms.Label();
            this.rbSecenek1 = new System.Windows.Forms.RadioButton();
            this.rbSecenek2 = new System.Windows.Forms.RadioButton();
            this.rbSecenek3 = new System.Windows.Forms.RadioButton();
            this.rbSecenek4 = new System.Windows.Forms.RadioButton();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(370, 98);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(44, 16);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "label1";
            // 
            // rbSecenek1
            // 
            this.rbSecenek1.AutoSize = true;
            this.rbSecenek1.Location = new System.Drawing.Point(60, 271);
            this.rbSecenek1.Name = "rbSecenek1";
            this.rbSecenek1.Size = new System.Drawing.Size(103, 20);
            this.rbSecenek1.TabIndex = 1;
            this.rbSecenek1.TabStop = true;
            this.rbSecenek1.Text = "radioButton1";
            this.rbSecenek1.UseVisualStyleBackColor = true;
            // 
            // rbSecenek2
            // 
            this.rbSecenek2.AutoSize = true;
            this.rbSecenek2.Location = new System.Drawing.Point(256, 271);
            this.rbSecenek2.Name = "rbSecenek2";
            this.rbSecenek2.Size = new System.Drawing.Size(103, 20);
            this.rbSecenek2.TabIndex = 2;
            this.rbSecenek2.TabStop = true;
            this.rbSecenek2.Text = "radioButton2";
            this.rbSecenek2.UseVisualStyleBackColor = true;
            // 
            // rbSecenek3
            // 
            this.rbSecenek3.AutoSize = true;
            this.rbSecenek3.Location = new System.Drawing.Point(453, 271);
            this.rbSecenek3.Name = "rbSecenek3";
            this.rbSecenek3.Size = new System.Drawing.Size(103, 20);
            this.rbSecenek3.TabIndex = 3;
            this.rbSecenek3.TabStop = true;
            this.rbSecenek3.Text = "radioButton3";
            this.rbSecenek3.UseVisualStyleBackColor = true;
            // 
            // rbSecenek4
            // 
            this.rbSecenek4.AutoSize = true;
            this.rbSecenek4.Location = new System.Drawing.Point(635, 271);
            this.rbSecenek4.Name = "rbSecenek4";
            this.rbSecenek4.Size = new System.Drawing.Size(103, 20);
            this.rbSecenek4.TabIndex = 4;
            this.rbSecenek4.TabStop = true;
            this.rbSecenek4.Text = "radioButton4";
            this.rbSecenek4.UseVisualStyleBackColor = true;
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(360, 346);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(75, 23);
            this.btnBitir.TabIndex = 5;
            this.btnBitir.Text = "bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // button1
            // 
            this.btnSonraki.Location = new System.Drawing.Point(663, 346);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(75, 23);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // button2
            // 
            this.btnOnceki.Location = new System.Drawing.Point(71, 346);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(75, 23);
            this.btnOnceki.TabIndex = 7;
            this.btnOnceki.Text = "önceki";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);

            // 
            // SinavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 381);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.rbSecenek4);
            this.Controls.Add(this.rbSecenek3);
            this.Controls.Add(this.rbSecenek2);
            this.Controls.Add(this.rbSecenek1);
            this.Controls.Add(this.lblSoru);
            this.Name = "SinavForm";
            this.Text = "SinavForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.RadioButton rbSecenek1;
        private System.Windows.Forms.RadioButton rbSecenek2;
        private System.Windows.Forms.RadioButton rbSecenek3;
        private System.Windows.Forms.RadioButton rbSecenek4;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnSonraki;
    }
}