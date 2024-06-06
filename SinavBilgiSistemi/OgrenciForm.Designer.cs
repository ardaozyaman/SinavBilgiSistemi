

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
    partial class OgrenciForm
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
            this.btnSinavaGir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSinavaGir
            // 
            this.btnSinavaGir.Location = new System.Drawing.Point(209, 133);
            this.btnSinavaGir.Name = "btnSinavaGir";
            this.btnSinavaGir.Size = new System.Drawing.Size(131, 42);
            this.btnSinavaGir.TabIndex = 0;
            this.btnSinavaGir.Text = "Sinava Gir";
            this.btnSinavaGir.UseVisualStyleBackColor = true;
            this.btnSinavaGir.Click += new System.EventHandler(this.btnSinavaGir_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(63, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 84);
            this.listBox1.TabIndex = 1;
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 206);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSinavaGir);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinavaGir;
        private System.Windows.Forms.ListBox listBox1;
    }
}