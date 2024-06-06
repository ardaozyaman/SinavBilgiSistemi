
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
using System.Linq;

namespace SinavBilgiSistemi
{
    public static class OgretmenTxtHelper
    {
        private static string filePath = "ogretmenler.txt";

        // Tüm öğretmenleri oku
        public static List<Ogretmen> OgretmenleriOku()
        {
            if (!File.Exists(filePath))
            {
                return new List<Ogretmen>();
            }

            var lines = File.ReadAllLines(filePath);
            var ogretmenler = lines.Select(line => JsonConvert.DeserializeObject<Ogretmen>(line)).ToList();
            return ogretmenler;
        }

        // Yeni OgretmenID oluştur
        private static string YeniOgretmenID()
        {
            var ogretmenler = OgretmenleriOku();
            if (ogretmenler.Count == 0)
            {
                return "1";
            }
            return (ogretmenler.Max(o => int.Parse(o.Id)) + 1).ToString();
        }

        // Öğretmen ekle
        public static void OgretmenEkle(Ogretmen ogretmen)
        {
            var ogretmenler = OgretmenleriOku();
            ogretmen.Id = YeniOgretmenID();
            ogretmenler.Add(ogretmen);
            OgretmenleriDosyayaYaz(ogretmenler);
        }

        // Öğretmen güncelle
        public static void OgretmenGuncelle(Ogretmen guncelOgretmen)
        {
            var ogretmenler = OgretmenleriOku();
            var index = ogretmenler.FindIndex(o => o.Id == guncelOgretmen.Id);

            if (index >= 0)
            {
                ogretmenler[index] = guncelOgretmen;
                OgretmenleriDosyayaYaz(ogretmenler);
            }
        }

        // Öğretmen sil
        public static void OgretmenSil(string ogretmenID)
        {
            var ogretmenler = OgretmenleriOku();
            var ogretmen = ogretmenler.FirstOrDefault(o => o.Id == ogretmenID);

            if (ogretmen != null)
            {
                ogretmenler.Remove(ogretmen);
                OgretmenleriDosyayaYaz(ogretmenler);
            }
        }

        // Dosyaya yaz
        private static void OgretmenleriDosyayaYaz(List<Ogretmen> ogretmenler)
        {
            var lines = ogretmenler.Select(o => JsonConvert.SerializeObject(o, Formatting.Indented)).ToArray();
            File.WriteAllLines(filePath, lines);
        }
    }
}
