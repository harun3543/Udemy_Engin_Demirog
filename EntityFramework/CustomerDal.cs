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
