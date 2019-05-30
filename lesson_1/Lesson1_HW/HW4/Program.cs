using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Сахаров Иван.
4. Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.
*/


namespace HW4
{
    class Program
    {

        public static void secondValueChange(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void firstValueChange(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }


        static void Main(string[] args)
        {
            int a = 3;
            int b = -5;
            int c = 7;
            int d = -1;

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3} ", a, b, c, d);

            firstValueChange(ref c, ref d);
            secondValueChange(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.ReadKey();
        }
    }
}
