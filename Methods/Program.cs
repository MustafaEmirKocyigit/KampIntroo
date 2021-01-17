using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urunss urun1 = new Urunss();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urunss urun2 = new Urunss();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urunss[] urunler = new Urunss[] { urun1, urun2 };

            //Type-safe -- Tip Güvenli

            foreach (Urunss urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }


            Console.WriteLine("---------METOTLAR----------------");

            //instance - örnek
            //encapsulation
            SepetManagerr sepetManager = new SepetManagerr();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 12, 8);



        }
    }
}




//Dont repeat yourself - DRY -Clean Code - Best Practice 