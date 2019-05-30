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

            Console.WriteLine($" Мое имя {firstName}, моя фамилия {lastName} я живу в городе {city}");



        }
    }
}
