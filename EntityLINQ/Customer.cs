using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    /*Bu class SQL den çekilen verilerin bir listeye kaydedilmesi için oluşturulmuştur. */
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
    }
}
