using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1_HW;

namespace Lesson1_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Print("Введите ваше имя: ");
            string fName = Console.ReadLine();
            Library.Print("Введите вашу фамилию: ");
            string lName = Console.ReadLine();
            Library.Print("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Library.Print("Введите ваш рост: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Library.Print("Введите ваш вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Library.Print("Имя: " + fName + ", Фамилия: " + lName + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);
            Library.Pause();

        }
    }
}
