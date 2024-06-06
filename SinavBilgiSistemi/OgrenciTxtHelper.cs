
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
    public static class OgrenciTxtHelper
    {
        private static string filePath = "ogrenciler.txt";

        // Tüm öğrencileri oku
        public static List<Ogrenci> OgrencileriOku()
        {
            if (!File.Exists(filePath))
            {
                return new List<Ogrenci>();
            }

            var lines = File.ReadAllLines(filePath);
            var ogrenciler = lines.Select(line => JsonConvert.DeserializeObject<Ogrenci>(line)).ToList();
            return ogrenciler;
        }

        // Yeni OgrenciID oluştur
        private static string YeniOgrenciID()
        {
            var ogrenciler = OgrencileriOku();
            if (ogrenciler.Count == 0)
            {
                return "1";
            }
            return (ogrenciler.Max(o => int.Parse(o.Id)) + 1).ToString();
        }

        // Öğrenci ekle
        public static void OgrenciEkle(Ogrenci ogrenci)
        {
            var ogrenciler = OgrencileriOku();
            ogrenci.Id = YeniOgrenciID();
            ogrenciler.Add(ogrenci);
            OgrencileriDosyayaYaz(ogrenciler);
        }

        // Öğrenci güncelle
        public static void OgrenciGuncelle(Ogrenci guncelOgrenci)
        {
            var ogrenciler = OgrencileriOku();
            var index = ogrenciler.FindIndex(o => o.Id == guncelOgrenci.Id);

            if (index >= 0)
            {
                ogrenciler[index] = guncelOgrenci;
                OgrencileriDosyayaYaz(ogrenciler);
            }
        }

        // Öğrenci sil
        public static void OgrenciSil(string ogrenciID)
        {
            var ogrenciler = OgrencileriOku();
            var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == ogrenciID);

            if (ogrenci != null)
            {
                ogrenciler.Remove(ogrenci);
                OgrencileriDosyayaYaz(ogrenciler);
            }
        }

        // Dosyaya yaz
        private static void OgrencileriDosyayaYaz(List<Ogrenci> ogrenciler)
        {
            var lines = ogrenciler.Select(o => JsonConvert.SerializeObject(o, Formatting.Indented)).ToArray();
            File.WriteAllLines(filePath, lines);
        }
    }
}
