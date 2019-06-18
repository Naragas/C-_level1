using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Func[] functions = { Task2.F1, Task2.F2, Task2.F3 };
            
            //Вывод результата работы функции a*x^2
            Console.WriteLine("Вывести результат работы a*x^2");
            Task1.Table(Task1.MyFunc, 4, 6);


            //Вывод результата работы a*sin(x) через лямбда функцию
            Console.WriteLine("Вывести результат работы a*sin(x) через лямбда функцию");
            Task1.Table((a, x) => a * Math.Sin(Math.PI * x / 180), 30, 60, 15);

            Console.ReadLine();
            Console.WriteLine("Список функций:");
            Console.WriteLine("1) x * x - 50 * x + 10");
            Console.WriteLine("2) x * x - 30 * x + 20");
            Console.WriteLine("3) x / (x - 4) * (34 - x)");
            Console.WriteLine("Выберите каккую функцию вы хотите использовать(1, 2, 3)");
            int number = int.Parse(Console.ReadLine());
            Task2.SaveFunc(functions[number-1], "data.bin", 22, 66, 2);
            Console.WriteLine(Task2.Load("data.bin"));


            Console.ReadLine();
        }
    }
}
