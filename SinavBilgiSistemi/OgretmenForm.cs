
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
    public partial class OgretmenForm : Form
    {
        private Sinav sinav;
        private List<Soru> sorular= new List<Soru>();
        private List<Sinav> sinavlar;

        private void sinavlariYenile()
        {
            sinavlar = SinavTxtHelper.SinavlariOku();
            if (sinavlar.Count > 0)
            {
                sinavlarListBox.ValueMember = "SinavID";
                sinavlarListBox.DisplayMember = "DersAdi";
                foreach (var item in sinavlar)
                {
                    sinavlarListBox.Items.Add(item);
                }
                
            }
        }
        public OgretmenForm(Ogretmen ogretmen)
        {

            
            InitializeComponent();
            sinavlariYenile();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Sinav sinav = new Sinav(textBox1.Text, int.Parse(textBox2.Text),dateTimePicker2.Value, dateTimePicker2.Value);
            sinav.Sorular = sorular;
            SinavTxtHelper.SinavEkle(sinav);
            sinavlarListBox.Items.Clear();
            sinavlariYenile();
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dogruCvpIndex = 0;
            List<string> senekler = new List<string>();
            senekler.Add(cvp1Box.Text);
            senekler.Add(cvp2Box.Text);
            senekler.Add(cvp3Box.Text);
            senekler.Add(cvp4Box.Text);
            if (radioButton1.Checked)
            {
                dogruCvpIndex = 0;
            }else if (radioButton2.Checked)
            {
                dogruCvpIndex= 1;
            }
            else if (radioButton3.Checked)
            {
                dogruCvpIndex = 2;
            }
            else if (radioButton4.Checked)
            {
                dogruCvpIndex = 3;
            }
            Soru soru = new Soru("1", soruMetni.Text, senekler, senekler[dogruCvpIndex]);
            sorular.Add(soru);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SinavTxtHelper.SinavSil((sinavlarListBox.SelectedItem as Sinav).SinavID);
        }

        private void sinavlarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
