using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            int number3 = 2;

            //ref key metodu
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(number1, number2));
            Console.WriteLine(Multiply(number1, number2, number3));

            Console.ReadLine();

        }

        //var keyword ile çalışmak
        //static int Add2(int number1 = 20, int number2 = 30)
        //{
        //    var result = number1 + number2;
        //    return result;
        //}



        //********ref keyword ile çalışmak****************
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            Console.WriteLine(number1);
            return number1 + number2;
        }
        /*********************************/

        //*********METHODLARIN AŞIRI YÜKLENMESİ************

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number2 * number1 * number3;
        }
        /***************************************/
    }
}
