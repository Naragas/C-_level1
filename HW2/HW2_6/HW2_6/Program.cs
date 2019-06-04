using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
 * *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
*/


namespace HW2_6
{
    class Program
    {

        static int addingDigits(int i)
        {
            int result = 0;
                do
                {
                    result += i % 10;
                    i = i / 10;
                } while (i >= 1);
                return result;
        }

        static void Main(string[] args)
        {                        
            int start = 1;
            int finish = 1000000000;
            int result = 0;

            DateTime startTime = DateTime.Now;

            for (int i = start; i <= finish; i++)
            {
                int digitSumm = addingDigits(i);
                if(i%digitSumm == 0)
                {
                    result++;
                }
            }

            DateTime finishTime = DateTime.Now;            

            Console.WriteLine("Количество хороших чисел в диапазоне от " + start + " до " + finish +" - " + result + " На поиск результата было застрачено " + (finishTime - startTime) + " секунд");
            Console.ReadLine();

        }
    }
}
