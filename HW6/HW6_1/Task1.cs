using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сахаров Иван
Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
функцией a*sin(x).
*/

namespace HW6_1
{

    public delegate double Fun(double a, double b);
    class Task1
    {
        public static void Table(Fun F, double x, double a, int step = 1)
        {
            Console.WriteLine("----- X ----- A ----- Fun ----- ");
            while (x <= a)
            {
                Console.WriteLine("| {0,7:0.000} | {1,7:0.000} | {2,8:0.000} |",x,a,F(a,x));
                x += step;
            }
            Console.WriteLine("-------------------------------");

        }

        public static double MyFunc(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }
        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(Math.PI * x / 180);
        }
    }
}
