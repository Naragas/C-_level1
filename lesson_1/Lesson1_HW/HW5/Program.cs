using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW5.Library;

/*Сахаров Иван
 * 5 и 6 задание
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

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

            Pause();

            PrintOnLineCenter(result);

            Pause();

            PrintOnConsoleCenter(result, 40, 10);

            Pause();

            


        }
    }
}
