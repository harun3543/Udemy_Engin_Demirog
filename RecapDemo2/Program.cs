using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();  //Bu sekme olmasaydı loggerın kim olduğu belli olmadığı için hata verecekti.
            customerManager.Add();
            Console.ReadLine();
        }
    }

    //CustomerManager class'ı bizim ana yönetim classımız.
    class CustomerManager
    {
        /*ILogger cinsinden bir property oluşturduk. Normalde aşağıdaki Logger tanımlama işlemini property injection ile değil
         * constuction method ile yapmamız gerekir.*/

        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();       //Bu sekmede .Log, interface içindeki log methodunu çalıştırır.
            Console.WriteLine("Customer Added");
        }

    }
    /*Bir üstteki Add() methodu çalıştırıldığında Logger.Log()  sekmesinde interface içindeki Log methoduna gider. Bizim iki adet 
     * loglama classımız bulunur. Bu classlarda ILogger interfaceni implement etmiştir. Bu yüzden interface içindeki Log çalıştırıldığında 
     * aslında bu iki loglama clasının içindeki Log() methodu çalışmış olur. "customerManager.Logger = new DatabaseLogger();" bu komut ile 
     * Log için çalışacak class DatabaseLogger olarak tanımlanmıştır. Dolayısıyla DatabaseLogger içindeki Log() methodu çalışacaktır.
     * Burada interface ortak bir dil olmuş olur. İnterface üzerinden iki loglama classına basit bir şekilde ulaşmış olduk. 
     * Loglama yöntemini değiştirmek istediğimizde "customerManager.Logger = new DatabaseLogger();" buradaki "new" kısmını değiştirmemiz 
     * yeterli olacaktır.*/

    /*Burada interface kullanmamızın sebebi Database de loglamak farklıdır Sms e loglamak farklıdır. Bu yüzden zamanı geldiğinde 
     loglama yöntemini hızlı bir şekilde değiştirmek için interface kullandık.*/

    /*Burada DatabaseLogger ve SmsLogger ın loglama kodları aynı olsaydı Log methodunu virtual olarak tanımlamak daha mantıklı idi.*/
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
