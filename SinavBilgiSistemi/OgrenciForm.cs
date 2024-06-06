
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavBilgiSistemi
{
    public partial class OgrenciForm : Form
    {
        private List<Sinav> sinavlar;
        private Ogrenci ogrenci;

        public OgrenciForm(Ogrenci ogrenci)
        {
            sinavlar = SinavTxtHelper.SinavlariOku();

            this.ogrenci = ogrenci; 
            InitializeComponent();
            if (sinavlar.Count > 0)
            {
                listBox1.ValueMember = "SinavID";
                listBox1.DisplayMember = "listboxGorunumu";
                foreach (var item in sinavlar)
                {
                    listBox1.Items.Add(item);
                }
            }

        }

        private void btnSinavaGir_Click_1(object sender, EventArgs e)
        {
            SinavForm sinavForm = new SinavForm((listBox1.SelectedItem as Sinav));
            sinavForm.Show();
        }
    }

}
