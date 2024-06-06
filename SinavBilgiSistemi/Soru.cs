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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavBilgiSistemi
{
    public class Soru
    {
        public string SoruID { get; set; }
        public string SinavID { get; set; }
        public string SoruMetni { get; set; }
        public List<string> Secenekler { get; set; }
        public string DogruCevap { get; set; }



        public Soru(string soruID, string soruMetni, List<string> secenekler, string dogruCevap)
        {
            SoruID = soruID;
            SoruMetni = soruMetni;
            Secenekler = secenekler;
            DogruCevap = dogruCevap;
        }

        public string toJSON()
        {
            return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static Soru fromJSON(string jsonString)
        {
            return JsonConvert.DeserializeObject<Soru>(jsonString);
        }
    }

}
