using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            if (PrimeNumber(7))
            {
                Console.WriteLine("Sayi asal sayidir.");
            }
            else
            {
                Console.WriteLine("Sayi asal sayi değildir.");
            }
        }

        private static bool PrimeNumber(int number)
        {
            bool IsPrimeNumber = true;
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    IsPrimeNumber = false;
                    i = number - 1;
                }
            }
            return IsPrimeNumber;
        }
    }
}
