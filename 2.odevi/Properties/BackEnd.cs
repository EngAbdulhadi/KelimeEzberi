using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2.odevi.Resources
{
    public class Word
    {
        public string English { get; set; }
        public string Turkish { get; set; }
    }

    public class Soru
    {
        public string English { get; set; }
        public string CorrectTurkish { get; set; }
        public List<string> Options { get; set; }
    }

     internal class BackEnd
    {
        public List<Word> TxtdenOku(string txtPath)
        {
            var words = new List<Word>();
            string[] lines = File.ReadAllLines(txtPath);
            char Arasi = '\t';

            foreach (var line in lines)
            {
                var parts = line.Split(Arasi);
                if (parts.Length != 2) continue;

                string english = parts[0].Trim();
                string turkish = parts[1].Trim();

                words.Add(new Word
                {
                    English = english,
                    Turkish = turkish
                });
            }

            return words;
        }

        public class KelimeYonetici : Soru
        {
            private List<Word> kelimeler;
            private int aktifIndex = 0;
            private Random rnd = new Random();

            public KelimeYonetici(List<Word> kelimeListesi)
            {
                kelimeler = kelimeListesi.OrderBy(x => Guid.NewGuid()).ToList(); 
            }

            public bool BittiMi()
            {
                return aktifIndex >= kelimeler.Count;
            }

            public Soru YeniSoru()
            {
                if (BittiMi()) return null;

                var aktifKelime = kelimeler[aktifIndex];
                aktifIndex++;

                var secenekler = kelimeler
                    .Where(k => k != aktifKelime)
                    .OrderBy(x => rnd.Next())
                    .Take(3)
                    .Select(x => x.Turkish)
                    .ToList();

                secenekler.Add(aktifKelime.Turkish);
                secenekler = secenekler.OrderBy(x => rnd.Next()).ToList();

                return new Soru
                {
                    English = aktifKelime.English,
                    CorrectTurkish = aktifKelime.Turkish,
                    Options = secenekler
                };
            }
        }
    }
}
