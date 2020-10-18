using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Engin_Demirog
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }
        public int StockProp { get; set; }      //Kullanucının girdiği stock miktarı 
        public event StockControl StockControlEvent;
        public string StockControl { get; set; }
        //public int Stock
        //{
        //    get { return _stock; }
        //    set { _stock = value;
        //        if (value <= 15 && StockControlEvent!=null)
        //        {
        //            StockControlEvent();
        //        }
        //    }
        //}

        public int Stock
        {
            get { return StockProp; }
            set
            {
                StockProp = value;
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public string ProductName { get; set; }
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount : {0}", Stock,ProductName); 
        }
    }
}
