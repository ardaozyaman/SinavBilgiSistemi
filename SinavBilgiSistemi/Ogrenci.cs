
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
    public class Ogrenci : Kullanici
    {
        public Ogrenci(string id, string ad, string soyad, List<Sinav> sinavlar) : base(id, ad, soyad, sinavlar)
        {
        }

        public string toJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static Ogrenci fromJSON(string jsonString)
        {
            return JsonConvert.DeserializeObject<Ogrenci>(jsonString);
        }
    }
}
