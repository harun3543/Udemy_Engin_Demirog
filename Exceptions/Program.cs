using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            #region tryCatch
            /*****Bu kısım hatayı kontol etmek için kullanılır.Amacı programcıyı doğru yönlendirmektir.*****/
            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            #endregion


            #region ActionDelagete 
            /*Bu kısımda yukarıda oluşturulan try catch bloğu kod büyüdükçe okunuş bakımından çirkin görünmyeye başlar. O yüzden 
             Action delegasyonlarını kullanabilriz.Oluştuduğumuz HandleException methodu bizi try catch blok kalabalığından kurtaracaktır.
             Bu methoda parametresiz "()" içerisine ise "=>" bir kod kümesi "{}" göndericez.Yani Find() methodunu çalıştıracak.
             Kısacası Find() methodumuzu merkezi bir try catch sistemine göndermiş olduk.
             Genelde bu methodu merkezi bir class ın içine koyarız ve oradan çalıştırırız. OLdukça kullanışlı bir delegasyondur.*/
            HandleException(() =>
            {
                Find();
            });
            #endregion


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                /**/
                action.Invoke(); 
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Harun", "Mehmet", "Salih" };

            /*Aşağıdaki kısım genelde backend yani arka tarafta yazılır.Bu kısım  bir hata olduğunda hata fırlatır.*/

            if (!students.Contains("Ahmet"))
            {
                /*Bir hata fırlat. Burada kendi oluştuduğumuz hata class ından gelecek olan message tanımını değiştirebiliriz. Bunu da 
                 * kendi oluşturduğumuz hata class ına constructor method yazarak yaparız. */
                throw new RecordNotFoundException("Record Not Found!");  
                                
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Ahmet", "Mehmet", "Salih" };
                students[3] = "Hüseyin";
            }
            /*Hata mesajı aşağıdaki catch lerden bir tanesi çalışır. İlk hatada index taşması olursa oluşur. Eğer bu oluşmaz ise
             Genel hata olan "Exception" catch bloğu çalışır.*/
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
