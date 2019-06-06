using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 *Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
* Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
* Добавить упрощение дробей.
*/
namespace HW3
       
{
    class Program
    {

        static void gettingInput(String dataName, ref int data)
        {
            while (true)
            {
                Console.WriteLine($"Введите {dataName}");
                String s = Console.ReadLine();

                if (int.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                }
                else
                {
                    break;
                }
            }
        }




        static void Main(string[] args)
        {
            int numberA = 0;
            int numberB = 0;
            int numberC = 0;
            int numberD = 0;



            Console.WriteLine("Вас приветствует программа демонтсрируящая матемотические действия с дробями!");
            Console.WriteLine("Далее нужно будет ввести данные для создания дробей в виде A/B, (3/4)");
            gettingInput("числитель первой дроби", ref numberA);
            gettingInput("знаменатель первой дроби", ref numberB);

            Fractions fr1 = new Fractions(numberA, numberB);
            Console.WriteLine($"Спасибо, первая дробь {numberA}/{numberB} упрощена и это : {fr1.ToString()}");


            gettingInput("числитель второй дроби", ref numberC);
            gettingInput("знаменатель первой дроби", ref numberD);

            Fractions fr2 = new Fractions(numberC, numberD);
            Console.WriteLine($"Спасибо, вторая дробь {numberC}/{numberD} упрощена и это : {fr2.ToString()}");


            Console.WriteLine();

            Console.WriteLine("Математические операции между двумя дробями:");

            Console.WriteLine();

            Console.WriteLine($"{fr1.ToString()} + {fr2.ToString()} = {fr1.Summ(fr2)}");
            Console.WriteLine($"{fr1.ToString()} - {fr2.ToString()} = {fr1.Diff(fr2)}");
            Console.WriteLine($"{fr1.ToString()} * {fr2.ToString()} = {fr1.Mult(fr2)}");
            Console.WriteLine($"{fr1.ToString()} / {fr2.ToString()} = {fr1.Divi(fr2)}");

            Console.WriteLine();

            Console.WriteLine("Вывод дроби в деситичном виде:",ConsoleColor.Red);

            Console.WriteLine();

            Console.WriteLine($"{fr1.ToString()} в деситичном виде будет  - {fr1.decimalFraction()}");
            Console.WriteLine($"{fr2.ToString()} в деситичном виде будет  - {fr2.decimalFraction()}");

            Console.WriteLine();

            Console.WriteLine("Вывод знаменателей через метод Get:");

            Console.WriteLine($"Знаменатель первой дроби {fr1.DemonatorGet()}");
            Console.WriteLine($"Знаменатель второй дроби {fr2.DemonatorGet()}");


            Console.ReadLine();
        }
    }
}
