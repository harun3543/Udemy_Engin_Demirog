using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*** 
 * Delegate bir elçi görevi üstlenmektedir.
 * ***/
namespace Delegates
{
    class Program
    {
        public delegate void myDelegate();      //Değer döndürmeyen delegate türü. Bu delegate sadece kendisi gibi değer almayan ve değer döndürmeyen methodlarda 
                                                //kullanılabilir.
        public delegate int myToplaDelegate(int sayi1, int sayi2);  //Hem parametre alan hem de parametre döndüren delegate türü.
            
        static void Main(string[] args)
        {
            //DelegateDemo();       //DElegate örneği

            // FuncDemo();          //Func<> örneği. Action gibi çalışır tek farkı geri değer döndüren bir methodu nitelemesi gerekir. 

            ActionDemo();           //Action örneği

            Console.ReadLine();
        }
        /********************ACTION********************/
        private static void ActionDemo()
        {
            Matematik matematik = new Matematik();
            var action = new Action<int, int>(matematik.Topla);
            action(34, 12);
        }
        /*******************FUNC*************************/
        private static void FuncDemo()
        {
            Matematik matematik = new Matematik();

            var func = new Func<int, int, int>(matematik.Topla2);
            var result = func.Invoke(13, 55);

            Console.WriteLine(result);

        }
        /*********************DELEGATE**********************/
        private static void DelegateDemo()
        {
            Matematik matematik = new Matematik();

            myDelegate delegate1 = matematik.Topla; //değer döndürmeyen methodları bu delegate den çağırabiliriz.
            delegate1();

            myToplaDelegate delegate2 = matematik.Topla2;  //Hem parametre alan hem de parametre döndüren bir method ve delegate.
            var result = delegate2(5, 3);
            Console.WriteLine(result);
        }
    }
    /*******************CLASS*********************/
    class Matematik
    {
        public void Topla()
        {
            int sayi1 = 45;
            int sayi2 = 23;
            Console.WriteLine(sayi2 + sayi1);
        }
        public void Topla(int sayi1, int sayi2)
        {
 
            var result = sayi1 + sayi2;
            Console.WriteLine(result);
        }

        public int Topla2(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
