using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructions();

            //ConstructionInjection();

            SendValueConstruction();

            Console.ReadLine();
        }

        private static void SendValueConstruction()
        {
            /*Harun ifadesini yazmamızın nedeni BaseClass da bulunan construction methodu bir string türünde değer istiyor. Yazmaz isek 
            hata ile karşılaşırız.*/
            PersonManager personManager = new PersonManager("Harun");
            personManager.Add();
        }

        private static void ConstructionInjection()
        {
            /*Construction method sayesinde EmployedManager dan örnek oluştururken  Logger yöntemini de seçtik.*/
            EmployedManager employedManager = new EmployedManager(new DatabaseLogger());
            employedManager.Add();
        }

        private static void Constructions()
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            //Product classını ister değer göndermeden kullanır, isterse id ve name değerlerini göndererek kullanır.
            //Product product = new Product();
            Product product = new Product(2, "Harun");
        }
    }

    class CustomerManager
    {
        private int _count;  //private bir field alt çizgi ile başlatılır.
        /*Construction bu sınıfın ihtiyaç duyduğu başka değişkenler varsa kullanırız.Construction methodlar birden fazla tanımlanabilir. 
         Dikkat edilmesi gereken nokta istenen değerlerin farklı olması gerekir.*/

        public CustomerManager(int count)
        {
            _count = count;
        }
        /*İkinci bir construction method tanımladık. İstediği herhangi bir değişken yok.*/
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    /*Farklı construction kullanım öerneği*/
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }

    /************Construction Injection  konusu****************/


    /*interface e loglama yöntemlerimizi yazıyoruz.*/
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    /*EmployedManager class ı Logger için yönetim merkezimizdir.*/
    class EmployedManager
    {
        private ILogger _Logger;
        public EmployedManager(ILogger logger)
        {
            _Logger = logger;
        }

        public void Add()
        {
            _Logger.Log();
            Console.WriteLine("Added!");
        }
    }

    /*************Base class a parametre gönderme**************/

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)  //Base classı implement etmiş class a bu şekilde parametre gönderebilriz.
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}

