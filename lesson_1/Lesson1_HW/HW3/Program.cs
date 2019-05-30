using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Сахаров Иван.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/



namespace HW3
{
    class Program
    {
        public static void showDistance(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между двумя точками равно: {0:F2}", r);
        }
        static void gettingInput(String dataName, ref double data)
        {
            while (true)
            {
                Console.WriteLine($"Введите {dataName}");
                String s = Console.ReadLine();

                if (double.TryParse(s, out data) == false)
                {
                        Console.WriteLine("Введен не верный формат данных");
                }else
                {
                    break;
                }
            }             
        }

        static void Main(string[] args)
        {

            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            double r;

            gettingInput("Х координату первой точки", ref x1);
            gettingInput("Y координату первой точки", ref y1);
            gettingInput("Х координату второй точки", ref x2);
            gettingInput("Y координату второй точки", ref y2);
            showDistance(x1, x2, y1, y2);
            Console.ReadKey();
        }
    }
}
