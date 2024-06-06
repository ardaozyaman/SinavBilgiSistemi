
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
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace SinavBilgiSistemi
{
    public static class SinavTxtHelper
    {
        private static string filePath = "D:\\oopTxt\\sinav.txt.txt";

        // Tüm sınavları oku
        public static List<Sinav> SinavlariOku()
        {
            if (!File.Exists(filePath))
            {
                return new List<Sinav>();
            }

            var fileContent = File.ReadAllText(filePath);
            var sinavStrings = fileContent.Split(new[] { "☺" }, StringSplitOptions.RemoveEmptyEntries);
            var sinavlar = sinavStrings.Select(s => JsonConvert.DeserializeObject<Sinav>(s)).ToList();
            return sinavlar;
        }

        // Yeni SinavID oluştur
        private static int YeniSinavID()
        {
            var sinavlar = SinavlariOku();
            if (sinavlar.Count == 0)
            {
                return 1;
            }
            return sinavlar.Max(s => s.SinavID) + 1;
        }

        // Sınav ekle
        public static void SinavEkle(Sinav sinav)
        {
            var sinavlar = SinavlariOku();
            sinav.SinavID = YeniSinavID();
            sinavlar.Add(sinav);
            SinavlariDosyayaYaz(sinavlar);
        }

        // Sınav güncelle
        public static void SinavGuncelle(Sinav guncelSinav)
        {
            var sinavlar = SinavlariOku();
            var index = sinavlar.FindIndex(s => s.SinavID == guncelSinav.SinavID);

            if (index >= 0)
            {
                sinavlar[index] = guncelSinav;
                SinavlariDosyayaYaz(sinavlar);
            }
        }

        // Sınav sil
        public static void SinavSil(int sinavID)
        {
            var sinavlar = SinavlariOku();
            var sinav = sinavlar.FirstOrDefault(s => s.SinavID == sinavID);

            if (sinav != null)
            {
                sinavlar.Remove(sinav);
                SinavlariDosyayaYaz(sinavlar);
            }
        }

        // Dosyaya yaz
        private static void SinavlariDosyayaYaz(List<Sinav> sinavlar)
        {
            var sinavStrings = sinavlar.Select(s => JsonConvert.SerializeObject(s, Formatting.Indented));
            var fileContent = string.Join("☺\n", sinavStrings);
            File.WriteAllText(filePath, fileContent);
        }
    }

}
