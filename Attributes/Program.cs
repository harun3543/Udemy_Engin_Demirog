using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***Attribute(öznitelikler) bir C# yapılarına uyguılayabileceğimiz yapılardır. Bu yapıların amacı bir değerin girilmesi gerekmesi gibi durumularda 
 * kullanabiliriz. Örneğin burada kullanıcının FirstName değerini girmesinin zorunlu olmasını sağladık. Yani Attribute ler is merkezi bir yerde iş kurallarını 
 * koyabiliriz.
 * 
 * İlgili bir nesne kural oluşturuyoruz.
 * Attribute ler Reflection larla daha anlamlı olan yapılardır.
 * 
 * Örneğin "[RequiredProperty]" attribute nin zorunlu olduğunu okuyabileceğimiz bunun için bir lojik oluşturabileceğimiz yapı Reflection yapısıdır. 
 * 
 * Reflection lar ile Bir methodun bir class ın üzerinde bir attribute var mı, ne tür bir attribute var, şu attribute varsa o zaman FirstName i kontrol et.
  
    ***/
namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1,LastName="Durmuş",Age=30};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }

    [Totable("Customers" )]     //bu class için bir attribute yani iş kuralı koyduk. Bu sınıfa Customer tablosu gibi veri gönderilebilir.Burada daha çok veritabanına  
                                //sorgular eklemek için kullanırız.Burada Customers isimli bir parametre gönderdiğimiz için "TotableAttribute" class ına constructor 
                                //method ekleyerek bir parametre göndermemiz gerekir.   
    [Totable("TblCustomer")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]                      //***Burada kullnıcı FirstName i girmesi zorunlu hale getirmek istersek
        public string FirstName { get; set; }
        [RequiredProperty]
        public String LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]  //Hazır bir attribute dir. Obselete = eski
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        /*** Örneğin yeni bir method oluşturup yukarıdaki methodu yenilemek istiyoruz. Ama yukarıdaki methodu silemiyoruz bazı kullanım yerleri var. 
         * O zaman attribute ler ile yeni yazılacak olan methodlarda aşağıdaki kodu kullanıma zorlayabiliriz veya bilgi verebiliriz.
         ***/
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    //[AttributeUsage(AttributeTargets.All)]        /*** Bu attribute ü her yerde kullanabilmemizi sağlar ***/
    //[AttributeUsage(AttributeTargets.Class)]      /*** Bu attribute ü sadece class larda kullanabiliriz.***/

    /*** AllowMultiple açık olduğunda bu attribute yi iki veya daha fazla kez kullanabiliriz. ***/
    [AttributeUsage(AttributeTargets.Property, AllowMultiple =true)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
    class TotableAttribute : Attribute
    {
        private string _tableName;

        public TotableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    /*Hazır attribute lerde var*/


}
