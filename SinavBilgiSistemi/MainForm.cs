
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOgretmen_Click_1(object sender, EventArgs e)
        {
            Kullanici ogretmen = new Ogretmen("",textBox1.Text,textBox2.Text,new List<Sinav>());
            OgretmenForm ogretmenForm = new OgretmenForm(ogretmen as Ogretmen);
            ogretmenForm.Show();
        }

        private void btnOgrenci_Click_1(object sender, EventArgs e)
        {
            Kullanici ogrenci = new Ogrenci("",textBox1.Text,textBox2.Text,new List<Sinav>());
            OgrenciForm ogrenciForm = new OgrenciForm(ogrenci as Ogrenci);
            ogrenciForm.Show();
            this.Hide();
        }

      
    }

}
