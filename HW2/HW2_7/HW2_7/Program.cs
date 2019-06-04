using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_7
{
    class Program
    {
        static void recMetod(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b)
            {
                a++;
                recMetod(a, b);
            }
        }
        static void Main(string[] args)
        {
            int a = 23;
            int b = 123;

            recMetod(a, b);
            Console.ReadLine();


        }
    }
}
