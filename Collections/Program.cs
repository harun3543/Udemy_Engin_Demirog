using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrnekString();
            //arrayList();
            //List();

            /*Dictionary collection nunu bir anahtar ile değere ulaştığımız yerlerde kullnıyoruz.dictionary bir koleksiyondur.*/

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine( dictionary["table"]);

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            /***Dictionary iiçnde bu şekilde gezebilriz.***/
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }

        private static void List()
        {
            /*"<>" işlemi bunun generic olduğunu gösterir."<>"işlemi içindeki tip ile değer ekleyebilriz.Başka tipteki 
             değerleri kabul etmez.*/
            List<string> Cities = new List<string>();
            Cities.Add("Ankara");

            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id = 1, FirstName = "Harun" });
            customer.Add(new Customer { Id = 2, FirstName = "Mehmet" });

            /*Üstteki yazım şeklinin başka versiyonu*/
            //List<Customer> customer = new List<Customer>()
            //{
            //    new Customer {Id=1,FirstName="Harun" },
            //    new Customer {Id=2,FirstName="Mehmet" }

            //};


            /*****Listedeki eleman sayısını verir.********/
            var count = customer.Count;


            /*Yeni bir eleman ekleme*/
            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Hasan"
            };

            customer.Add(customer1);

            /*Listeye Array bazlı eleman ekleme*/
            customer.AddRange(new Customer[2]
            {
                new Customer { Id = 4, FirstName = "Hamide" },
                new Customer { Id = 5, FirstName = "Ramazan" }
            });

            /*Listedeki elemanları temizler. Temizledikten sonra count ile listedki eleman sayısını da sıfırlar.*/
            //customer.Clear();

            /*Liste içinde arama yapar ve değer var ise geriye true döner.*/
            var contains = Cities.Contains("Ankara");
            Console.WriteLine(contains);

            /*ÖNEMLİ = Class için contains ile arama bu şekilde yapılır. Daha önce customer1 isimli bir Customer türünden veri oluşturduğumuz
             için customer1 şeklinde arama yaparsak bize "true" dönecektir.*************/
            Console.WriteLine(customer.Contains(customer1));

            foreach (var item in customer)
            {
                Console.WriteLine(item.FirstName);
            }
            /*****customer1 değişkeninin index numarasını verir.İlk bulduğu customer1 in inedksini verir.*****/
            var index = customer.IndexOf(customer1);
            Console.WriteLine(index);

            /*****customer 1 değişkenini sondan aramaya başlar. bulduğu ilk customer1 in indeksini verir. ******/
            var index2 = customer.LastIndexOf(customer1);


            /*İnsert belirli bir sıraya depişken eklemede kullanılır.*/
            customer.Insert(0, customer1);


            /*customer2 yi siler. Bulduğu ilk customer1 i siler. Başka customer1 değişkeni varsa dokunmaz.*/
            //customer.Remove(customer1);

            /*RemoveAll komutu listedeki aynı isimdeki değişkenleri siler.*/
            //customer.RemoveAll(x => x.FirstName == "Hasan");
        }

        private static void arrayList()
        {
            /*Arraylist "object" türünden veri türlerini kabul eder. Yani int,string veya long türlerinin hepsini birden 
             kabul eder. Bütün collection lar Array bazlıdır.Biz ""ArrayList ile çalışmak isteersek değişkenlerin türleri
             önemli değils ise ArrayList tercih edilebilir. Eğer değişken türleri önemli ise tip güvenli(Type safe) çalışmalıyız.*/
            ArrayList cities = new ArrayList();
            cities.Add("Adana");
            cities.Add("Ankara");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }

        private static void OrnekString()
        {
            string[] cities = new string[2] { "Ankara", "İzmir" };
            /*Sonradan cities array ına bir şehir eklemek istenirse ve bu şekilde yeni bir
             *  new yapıldığında yeni bir referans alındığı için cities içindeki şehirler silinir.
             bu yüzden collection kullanılır.*/
            cities = new string[3];
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
