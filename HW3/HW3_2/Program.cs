using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
 *а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
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

        static int oddSumm(ref String result)
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
                    result += n + ", ";
                    summ = summ + n;
                }
            }
            
            return summ;
        }
        static void Main(string[] args)
        {
            string result = "";
            int summ = 0;
            Console.WriteLine("Программа подсчитает сумму всех нечетных чисел которые будут введены!\nДля завершения ввода чисел нужно ввести 0");

            summ = oddSumm(ref result);
            Console.WriteLine("Вами были введены следующие подходящие для задачи числа:\n{0}", result);

            Console.WriteLine("Сумма всех нечетных положительных чисел, которые вы ввели равен: {0}", summ);

            Console.ReadLine();

        }
    }
}
