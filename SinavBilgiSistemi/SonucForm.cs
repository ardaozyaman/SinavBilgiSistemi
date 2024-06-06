

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
    public partial class SonucForm : Form
    {
        private Ogrenci ogrenci;

        public SonucForm(Ogrenci ogrenci)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            GosterSonuclar();
        }

        private void GosterSonuclar()
        {
         

        }
    }

}
