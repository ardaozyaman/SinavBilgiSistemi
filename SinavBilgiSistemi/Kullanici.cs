
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavBilgiSistemi
{
    public abstract class Kullanici
    {
        // Private alanlar (fields)
        private string _id;
        private string _ad;
        private string _soyad;
        private List<Sinav> _sinavlar;

        protected Kullanici(string id, string ad, string soyad, List<Sinav> sinavlar)
        {
            _id = id;
            _ad = ad;
            _soyad = soyad;
            _sinavlar = sinavlar ?? new List<Sinav>(); // Null check
        }

        // Özellikler (Properties) ve get/set yöntemleri
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public List<Sinav> Sinavlar
        {
            get { return _sinavlar; }
            set { _sinavlar = value; }
        }


    }
}

