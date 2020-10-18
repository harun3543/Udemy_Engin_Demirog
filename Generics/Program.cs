using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Generic leri class lar için kullabildiğimz gibi methodlar için de kullanabiliriz.Örnek olarak*/
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            /*Bu şekilde bir sınfı üzerindende örnek verilebilir.*/
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Harun" }, new Customer { FirstName = "Mehmet" });

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
                
                
           Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params  T[] items)
        {
            return new List<T> (items);
        }
    }

    class Product:IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {
     
    }

    class Customer: IEntity
    {
        public string  FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {
   
    }
    /*Bu method ile "T" ile gelen nesne bilgisine göre bir interface oluşturur. Böylece hem IProductDal hem de IcustomerDal için aynı fonksiyonları
     * ( List<T> GetAll();
       T Get(int id);
       void Add(T entity);
       void Delete(T entity);
       void Update(T entity);) 
       
        yazmamıza gerek kalmadı.*/

        /*Burada genericlere bir kısıtlama getirebiliriz. Bunu da "where" komutu kullanılır. Burada sadece referans tip istediğimiz için yazılımcı string türünü de burada 
         kullanabilir. Ama biz sadece class olmasını istiyoruz. Bunun için ise  "new()" ifadesi eklenir.*/

        /*"where T:class" ifadesi T nin bir referans tipi olması gerektiğini belirtir.
         "T" new()  edilebilir  olmalı.
         "T" IEntity den implemente edilmeli veya class için inheritance edilmeli 
         IEnyity içerisinde veritabanı ile ilgili nesne olduğunu varsayalım.*/
    interface IRepository<T> where T:class,IEntity, new()  //değer tipleri için "T:struct"  yazılır.
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

interface IEntity  //Bunu bir veritabanı nesnesi olarak algılarsak 
{
        
}

