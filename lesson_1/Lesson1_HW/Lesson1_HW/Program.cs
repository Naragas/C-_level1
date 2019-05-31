using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Сахаров Иван.

Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
*/


namespace HW1
{
    class Program
    {
        
        static double gettingInput(String dataName, ref double data)
        {
            do
            {
                Console.WriteLine($"Введите свой {dataName.ToLower()}");
                String s = Console.ReadLine();

                if (double.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                }
                else
                {
                    if (data == 0 || data < 0)
                    {
                        Console.WriteLine($"{dataName} не может быть меньше или равен нулю.");
                    }
                }

            } while (data == 0 || data < 0);

            return data;
        }
        static int gettingInput(String dataName, ref int data)
        {
            do
            {
                Console.WriteLine($"Введите свой {dataName.ToLower()}");
                String s = Console.ReadLine();

                if (int.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                }
                else
                {
                    if (data == 0 || data < 0)
                    {
                        Console.WriteLine($"{dataName} не может быть меньше или равен нулю.");
                    }
                }

            } while (data == 0 || data < 0);

            return data;
        }

        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age = 0;
            double growth = 0;
            double weight = 0;


            Console.WriteLine("Введите ваше Имя");
            firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу Фамилию");
            lastName = Console.ReadLine();

            gettingInput("Возраст", ref age);
            gettingInput("Рост", ref growth);
            gettingInput("Вес", ref weight);




            Console.WriteLine("\nАнкета сотрудника");
            Console.WriteLine("Имя: " + firstName + ", Фамилия: " + lastName + ", Возраст: " + age + ", Рост: " + growth + " см, Вес: " + weight + " кг.");
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3} см, Вес: {4} кг.", firstName, lastName, age, growth, weight);
            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Возраст: {age}, Рост: {growth} см, Вес: {weight} кг.");
            Console.ReadLine();

        }
    }
}
