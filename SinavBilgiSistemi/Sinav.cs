
/****************************************************************************
 **                              DÜZCE ÜNİVERSİTESİ
 **                          LİSANSÜSTÜ EĞİTİM ENSTİTÜSÜ
 **                       BİLGİSAYAR MÜHENDİLİĞİ ANABİLİM DALI
 **                       ÖĞRENCİ ADI :          ARDA ÖZYAMAN
 **                       ÖĞRENCİ NUMARASI :     2345007016
 **
 ****************************************************************************/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SinavBilgiSistemi
{

    public class Sinav
    {
        public int SinavID { get; set; } // Otomatik artan ID
        public string DersAdi { get; set; } = "";
        public int Sure { get; set; } = 0;
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public List<Soru> Sorular { get; set; } = new List<Soru>();
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();

        public int SoruSayisi
        {
            get
            {
                return Sorular.Count;
            }
        }

        public Sinav(string dersAdi, int sure, DateTime baslamaTarihi, DateTime bitisTarihi)
        {
            DersAdi = dersAdi;
            Sure = sure;
            BaslamaTarihi = baslamaTarihi;
            BitisTarihi = bitisTarihi;
        }

        public void SoruEkle(Soru soru)
        {
            Sorular.Add(soru);
        }

        public string toJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static Sinav fromJSON(string jsonString)
        {
            return JsonConvert.DeserializeObject<Sinav>(jsonString);
        }
        
        

        public String listboxGorunumu
        {

            get { return DersAdi + " " + BaslamaTarihi + " " + BitisTarihi + " " + Sure.ToString() + " " + SoruSayisi; }
        }
    }
}
