using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun ciklet = new Urun(1,"Falım",25,100);   //Yeni bir nesne oluşturuldu.

            ciklet.StokAzaldiEvent += new StokAzaldiEventHandler(ciklet_StokAzaldi);   //StokAzaldi eventına delegate ile yeni bir methodu abone yapmış oluyoruz.

            for (int i = 0; i < 10; i++)
            {
                ciklet.StokMiktarı -= 10;
                Console.WriteLine("Güncel stok miktarı {0}", ciklet.StokMiktarı);
               
            }

            Console.ReadLine();

        }
        static void ciklet_StokAzaldi()             //Event için olay methodu oluşturduk.
        {
            Console.WriteLine("Stok miktarı 10 nun altına düştü");
            
        }
    }
}
