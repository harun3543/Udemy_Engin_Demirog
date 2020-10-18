using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/***    REFLECTION
 * Bir nesneyi çalışma anında yani uygulama çalışırken çalıştığımız herhangi bir nesne hakkında bilgi toplayabilir ve hatta toplamadığımız bilgiye göre örneğin bir methodunu
 * çalıştırabiliriz.
 * bu yönetmi kullanmamızın bir nedeni ise çalışma anında hangi nesne ile çalışacağımızı bilmememizden kaynaklıdır. Kullanıcının girdiği değerlere göre hangi methodun 
 * çalıştırılacağına uygulamanın gidişatına göre karar verebiliyoruz.
 * 2. kullanım senaryosu ise bir nesne hakkında bilgi almak için kullanılır.
 * 
 * Reflection tamamen ihtiyaçlar doğdoğunda yapılması gereken bir şeydir. Reflection performans kayıplarına yol açabilir.
 * ***/

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DortIslem dortIslem = new DortIslem(2,3);
            // Console.WriteLine(dortIslem.Carp(3,5));        //Bu methodda, method kullanıcıdan değer istemektedir.
            // Console.WriteLine(dortIslem.Carp2());          //Bu methodda ise, method kullanıcının constructor methodda verdiği değerleri kullandığı için 
            //kullanıcıdan tekrar değer istemez.
            /*** Bu işlemleri Reflection ile yapıcaz. ***/

            var type = typeof(DortIslem);           //DortIslem için bunu yapmamız zorunludur.     

            /*** Bu yapının karşılığı aslında "DortIslem dortIslem = new DortIslem(2,3);" ile aynıdır.Sadece alt satırdaki kod çalışma anında çalışmasını istediğimiz class ı 
             * belirtmemizi sağladı. Gelen tipe göre bu işlemi gerçekleştirmiş oluruz. " Activator.CreateInstance" bir obje döndürür.
             * ***/

            /*** Kısacası reflectionda Bir Instance oluşturduğumuzda onun methodlarını da çalıştırabiliyoruz. ***/

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,4,5);
            //Console.WriteLine(dortIslem.Carp(2, 5));
            //Console.WriteLine(dortIslem.Carp2());

            /*********************************DAHA PROFESYONEL YAZILIRSA************************************************************/
            /***
             * "GetMethod()" ile methoda ulaşabiliyoruz, Invoke ile Methodu çalıştırabiliyoruz.
             * ***/
            var instance = Activator.CreateInstance(type,6,5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Toplam2");     //Bu satırda methodla ilgili bilgi toplanır.
            Console.WriteLine(methodInfo.Invoke(instance,null));                //Bu satırda tekrar instance yazmamız gerekli. Burada hangi toplam2 yi çalıştırması 
                                                                                //gerektiğini bildiririz.


            /**************************************2. KULLANIM ALANI İSE CLASSLARIN METHODLARINA ULAŞMA******************************/
            /*** 
             * Bu kullanımda bir class içindeki methodları, methodların istediği değerleri görebiliyoruz.
             * ***/
            var methodlar = type.GetMethods();      //Bir liste döndürür.
            Console.WriteLine("************************");
            foreach (var info in methodlar)
            {
                Console.WriteLine("Method adı : {0}", info.Name);  //DortIslem class ındaki methodların isimlerini döndürecektir.
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre :{0}",parameterInfo.Name);
                }

                foreach (var attributesInfo in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name :{0}", attributesInfo.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Toplam(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        //Diğer bir senaryoda ise 

        public int Toplam2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carp2")]
        public int Carp2() 
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
                
        }
    }
}
