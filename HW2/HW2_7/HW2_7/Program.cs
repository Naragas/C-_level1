using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
 * б) Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/

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

        static int recSumm(int a,int b)
        {                     
            if (a != b)
            {
                a += recSumm(a + 1, b);
                
            }
           return a;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;

            recMetod(a, b);

            Console.WriteLine(recSumm(a,b));
            Console.ReadLine();


        }
    }
}
