using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    //Bunun class ı Entity Framewrok yapmak için "DbContext" implementasyonu yapmamız gerekir. İsimlendirmede database isminin 
    //sonuna Context eklenir.
    /**/
    class MyAdoDatabaseContext : DbContext
    {
        /*Bu işlemde Dbset olarak Customers isimli bir entity deeğişkeni tanımladık. Bunun anlamı tablolarda Customer isimli bir şey arıyor 
         */
        public DbSet<Customer> Customer { get; set; }
    }
}
