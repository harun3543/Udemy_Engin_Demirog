using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];

            students[0] = "Harun";Array
            students[1] = "mahmut";
            students[2] = "mehmet";

            //Bu şekilde kullanıbilir.
            string[] students2 = { "harun", "mehmet", "mahmut" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
