
/****************************************************************************
 **                              DÜZCE ÜNİVERSİTESİ
 **                          LİSANSÜSTÜ EĞİTİM ENSTİTÜSÜ
 **                       BİLGİSAYAR MÜHENDİLİĞİ ANABİLİM DALI
 **                       ÖĞRENCİ ADI :          ARDA ÖZYAMAN
 **                       ÖĞRENCİ NUMARASI :     2345007016
 **
 ****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavBilgiSistemi
{
    public partial class SinavForm : Form
    {
        private Sinav aktifSinav;
        private int soruIndex;
        private int kalanSure;
        private Timer timer;

        public SinavForm(Sinav sinav)
        {
            
            aktifSinav = sinav;
            InitializeComponent();
             // yüklenen sınav
            soruIndex = 0;
            kalanSure = aktifSinav.Sure * 60; // saniye cinsinden
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += Timer_Tick;
            timer.Start();
            GosterSoru();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            if (kalanSure <= 300)
            {
                // 5 dakika uyarısı
            }
            if (kalanSure <= 0)
            {
                timer.Stop();
                SinaviBitir();
            }
        }

        private void GosterSoru()
        {
            var soru = aktifSinav.Sorular[soruIndex];
            lblSoru.Text = soru.SoruMetni;
            rbSecenek1.Text = soru.Secenekler[0];
            rbSecenek2.Text = soru.Secenekler[1];
            rbSecenek3.Text = soru.Secenekler[2];
            rbSecenek4.Text = soru.Secenekler[3];
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruIndex++;
            if (soruIndex >= aktifSinav.Sorular.Count)
            {
                soruIndex = 0;
            }
            GosterSoru();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            soruIndex--;
            if (soruIndex < 0)
            {
                soruIndex = aktifSinav.Sorular.Count - 1;
            }
            GosterSoru();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            SinaviBitir();
        }

        private void SinaviBitir()
        {
            // Sınavı bitirme ve sonuçları kaydetme
            this.Close();
        }

        private void btnBitir_Click_1(object sender, EventArgs e)
        {

        }
    }

}
