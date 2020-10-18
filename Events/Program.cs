using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events.Program;

namespace Events
{
    class Program
    {
        public delegate void UrunEventHandler(double eskiFiyat, double yeniFiyat, Urun urun);
        static void Main(string[] args)
        {
            //EventDemo();



            Console.ReadLine();
        }

        private static void EventDemo()
        {
            Urun urun = new Urun(1, "Avize", 200);

            urun.fiyatdegisti += new UrunEventHandler(FiyatDegisti);
            urun.Fiyat = 350;
            urun.Fiyat = 230;
        }

        static void FiyatDegisti(double eskiFiyat, double yeniFiyat, Urun urun)
        {
            if (eskiFiyat > yeniFiyat)
            {
                Console.WriteLine("'{0}' adlı ürün indirime girdi. Eski fiyat: {1} => Yeni fiyat:{2}", urun.Ad, eskiFiyat, yeniFiyat);

            }

            if (eskiFiyat < yeniFiyat)
            {
                Console.WriteLine("'{0}' adlı ürün zamlandı. Eski fiyat: {1} => Yeni fiyat:{2}", urun.Ad, eskiFiyat, yeniFiyat);
            }
        }
    }
}