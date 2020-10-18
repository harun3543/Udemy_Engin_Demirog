using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    public class CustomerDal
    {
        /**********"Inconsistent Accessibility" error durumu oluştu. Bu error Customer class ının public olmamasından kaynaklandı. 
         * Customer class ına gidip başına public eklendi.*****************/
        public List<Customer> GetAll()
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                /*Database deki verileri Context yardımı ile çekmiş olduk.*/
                return context.Customer.ToList(); 
            }
        }

        /*LINQ sayesinde direkt veritabanından istediğimiz isimdeki nesneleri getirebiliriz.*/
        public List<Customer> GetByName(string key)
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                /*Bu satır direk veritabanından Where koşulu atar.*/
                return context.Customer.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        /*"Number" değişkeni bir sayıdan byük olan nesneleri getirir.*/
        public List<Customer> GetByNumber(int key)
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                /*Bu satır direk veritabanından Where koşulu atar.*/
                return context.Customer.Where(p => p.Number >= key).ToList();
            }
        }

        /*Bu method "Number" değişkeni belirli bir aralıkta olan nesneleri liste olarak geri döndürür.*/
        public List<Customer> GetByNumberArea(int min,int max)
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                var result = context.Customer.Where(p => p.Number >= min && p.Number <= max).ToList();
                return result;
            }
        }

        /*Sadece bir nesnenin bilgisini getirir.*/
        public Customer GetById(int key)
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                /*Burada Where kullanmamamızın sebebi where bir koleksiyon tipinde yani liste gibi bir değer döndürür. Bizim istediğimiz tek bir değer döndürmesi. 
                 Bunun için FirstOrDefault kullanılır. Bulduğu ilk değeri döndürür. Bulamazsa geriye null değer döndürür.*/
                // var result = context.Customer.FirstOrDefault(p => p.ID == key);

                /*SingleOrDefault database içinde birden fazla aynı değeri bulursa bir hata fırlatır. Tabi burada ID ye bakıldığı için aynı olan yoktur.*/
                 var result = context.Customer.SingleOrDefault(p => p.ID == key);
                 return result;
            }
        }

        public void Add(Customer customer)
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                /*Ekleme yaparken önce Add çağrılır sonra SaveChanges çağrılır. Birkaç veri birden save yapılabilir.*/
                context.Customer.Add(customer);

                /*Yukarıdaki satırın yerine şu şekilde de yazılır.*/
                var entity = context.Entry(customer);
                entity.State = EntityState.Added; //Ben yeni bir ürün ekledim.

                context.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {

            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                /*Entry bizim gönderdiğimiz customer ı veritabanındaki customer nesnesi ile eşitliyor.
                 Önce entry ile giriş yapılır ve customer ile bizim gönderdğimiz nesneyi database arar. Var ise değiştime ekleme veya silme 
                 işlemlerini gerçekleştirebiliriz.*/
                var entity = context.Entry(customer); //Database gir ve customer nesnesini ara.
                entity.State = EntityState.Modified; //Ben yeni bir ürün değiştirdim.
                context.SaveChanges();
            }
        }

        /*Silme işlemi*/
        public void Delete(Customer customer)
        {
            using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            {
                var entity = context.Entry(customer);  
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
