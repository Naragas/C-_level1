using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел. 
 */

namespace HW2_3
{
    class Program
    {

        static void gettingInput(ref int data)
        {
            while (true)
            {
                Console.WriteLine("Введите число.");
                String s = Console.ReadLine();

                if (int.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                }
                else
                {
                    break;
                }
            }
        }

        static int oddSumm()
        {
            int summ = 0;

            while (true)
            {
                int n = 0;
                gettingInput(ref n);
                if (n == 0)
                {
                    break;
                }
                else if (n > 0 && n % 2 != 0)
                {
                    summ = summ + n;
                }
            }
            return summ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитает сумму всех нечетных чисел которые будут введены!\nДля завершения ввода чисел нужно ввести 0");

            Console.WriteLine("Сумма всех нечетных положительных чисел, которые вы ввели равен: {0}", oddSumm());
            Console.ReadLine();

        }
    }
}
