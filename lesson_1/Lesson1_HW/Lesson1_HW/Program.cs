using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1_HW;

/* Сахаров Иван.

Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
*/


namespace Lesson1_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше Имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу Фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            double growth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nАнкета сотрудника");
            Console.WriteLine("Имя: " + firstName + ", Фамилия: " + lastName + ", Возраст: " + age + ", Рост: " + growth + " см, Вес: " + weight + " кг.");
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3} см, Вес: {4} кг.", firstName, lastName, age, growth, weight);
            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Возраст: {age}, Рост: {growth} см, Вес: {weight} кг.");
            Console.ReadLine();

        }
    }
}
