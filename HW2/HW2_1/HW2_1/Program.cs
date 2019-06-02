using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Сахаров Иван
 * Написать метод, возвращающий минимальное из трёх чисел.
*/


namespace HW2_1
{
    class Program
    {
        static void gettingInput(String dataName, ref double data)
        {
            while (true)
            {
                Console.WriteLine($"Введите {dataName}");
                String s = Console.ReadLine();

                if (double.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                }
                else
                {
                    break;
                }
            }
        }

        static double minOfThree(double a, double b, double c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    return a;
                }
                else return c;

            } else if (b < c)
                {
                    return b;
                }
                else return c;
        }

        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            gettingInput("Первое число", ref a);
            gettingInput("Второе число", ref b);
            gettingInput("Третье число", ref c);


            Console.WriteLine("Минимальное из введенных трех чисел: {0}", minOfThree(a, b, c));            
            Console.ReadKey();


        }
    }
}
