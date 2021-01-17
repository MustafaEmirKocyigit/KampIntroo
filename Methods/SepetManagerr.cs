using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManagerr
    {
        //naming convention
        //syntax
        public void Ekle(Urunss urun)
        {
            Console.WriteLine(" Tebrikler Sepete eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunaAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunaAdi);
        }


    }

}
