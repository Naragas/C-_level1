using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
 * Написать метод подсчета количества цифр числа.
 */ 

namespace HW2_2
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
        static void gettingInput(String dataName, ref int data)
        {
            while (true)
            {
                Console.WriteLine($"Введите {dataName}");
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

        static int digitsInNumber(int n)
        {
            int k = 0;
            while (n != 0)
            {
                n = n / 10;
                k++;
            }
            return k;
        }


        static int digitsInNumber(double number)
        {
            var d = number.ToString();
            d = d.Replace(".", "");
            return d.Length;
        }



        static void Main(string[] args)
        {
            double a = 0;
            int b = 0;
           
            gettingInput("любое число", ref a);
            Console.WriteLine("В введеннном вами числе {0} цифр.", digitsInNumber(a));

            gettingInput("целое число", ref b);
            Console.WriteLine("В введеннном вами числе {0} цифр.", digitsInNumber(b));

            Console.ReadKey();



        }
    }
}
