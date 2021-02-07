using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir sitede verilen kursların bilgilerini ekrana yazdırma */
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C";
            kurs1.Egitmen = "Irem";
            kurs1.IzlenmeOrani = 68;
            kurs1.KursPuanı = 5;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Fatma";
            kurs2.IzlenmeOrani = 64;
            kurs2.KursPuanı = 4.7;
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kursun Adı:"+kurs.KursAdi+ " -Kursun Eğitmeni:"+kurs.Egitmen + " -Kursun İzlenme Oranı:" + kurs.IzlenmeOrani+" -Kursun Puanı:"+kurs.KursPuanı);
            }

                
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        public double KursPuanı { get; set; }

    }
}
