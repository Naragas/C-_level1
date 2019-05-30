using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
*/



namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Иван";
            String lastName = "Сахаров";
            String city = "Москва";

            String result = ($"Меня зовут {lastName} {firstName}, я живу в городе {city}.");

            Console.WriteLine(result);

            Console.SetCursorPosition((Console.WindowWidth - result.Length) / 2, Console.CursorTop);
            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}
