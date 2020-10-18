using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteString();
            //SumString();

            string sentence = "My name is Harun Durmuş";

            //sentence stringinin karakter sayısını döndürür.
            var result = sentence.Length;

            // sentence değişkeninden bir klon oluşruduk.
            var result2 = sentence.Clone();

            //sentence değişkeninin son harfi 'ş' harfi ile bitiyor mu diye kontrol eder. 
            //Eğer 'ş' harfi ile biterse true değeri döner.
            bool result3 = sentence.EndsWith("ş");

            // buda my name ile başlıyor mu diye kontrol eder.
            bool result4 = sentence.StartsWith("My name");

            //Bir string içinde belli bir ifadeyi aramak için kullanılır. 
            //Eğer stringi bulursa o stinge kadar olan kısmın int değerini geri döndürür.
            //Yoksa -1 değerini döndürür. Bulduğu ilk ifadede durur.
            var result5 = sentence.IndexOf("Harun");

            //Buda IndexOf işlemi ile aynı görevi yapar. Sadece bu method sondan başlar.
            var result7 = sentence.LastIndexOf("Harun");

            //Bu method string in herhangi bir yerine bi şeyler eklemek için kullanılır.
            var result8 = sentence.Insert(0, "Hello, ");

            //String değişkeni istenilen kısmından bölmeye yarar. 11 ve 17 arasında kalan stringi verir.
            var result9 = sentence.Substring(11, 17);


            var result10 = sentence.ToLower();       // Bütün karakterleri küçük harfe çevirir.
            var result11 = sentence.ToUpper();       // Bütün karakterleri büyük harfe çevirir.

            //String içerisinden istenilen karakteri yeni bir karakter ile değiştirmek için kullanılır.
            var result12 = sentence.Replace(" ", "-");

            var result13 = sentence.Remove(2, 4);       //My ifadesinden sonraki 4 karakteri siler.
        }

        private static void SumString()
        {
            string city = "Ankara";
            string city2 = "İstanbul";

            //String.Format("{0}{1}", city, city2); //bu formatı bir değişkeni atarken kullanabilriz.

            string result = city + city2;
            Console.WriteLine(result);
        }

        private static void WriteString()
        {
            string city = "Ankara";
            Console.WriteLine("********************");
            Console.WriteLine(city[0]);
            Console.WriteLine("********************");

            foreach (var item in city)
            {
                Console.WriteLine(item);
                Console.WriteLine("********************");
            }
        }
    }
}
