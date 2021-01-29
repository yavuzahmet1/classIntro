using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 36;
            string adi = "Ahmet";


            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ahmet YAVUZ";
            kurs1.IzlenmeOrani = 55;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Phyton";
            kurs2.Egitmen = "Esma YAVUZ";
            kurs2.IzlenmeOrani = 59;


            kurs kurs3 = new kurs();
            kurs3.KursAdi = "JAVA";
            kurs3.Egitmen = "Osman YAVUZ";
            kurs3.IzlenmeOrani = 51;

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "Pascal";
            kurs4.Egitmen = "Emre DİNÇ";
            kurs4.IzlenmeOrani = 71;



            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.Egitmen+" "+kurs1.IzlenmeOrani);
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var a in kurslar)
            {
                Console.WriteLine(a.KursAdi+": "+a.Egitmen);
            }
        }
    }
 
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
