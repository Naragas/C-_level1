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

        static void Main(string[] args)
        {
            Fractions fr1 = new Fractions(16, 30);
            Fractions fr2 = new Fractions();
            fr2.NumenatorSet(23);
            fr2.DenominatorSet(59);

            Console.WriteLine(fr1.Show());
            Console.WriteLine(fr2.Show());

            fr1 = fr1.Simplification(fr1);
            fr2 = fr2.Simplification(fr2);
            Console.WriteLine(fr1.Show());
            Console.WriteLine(fr2.Show());
            Console.ReadLine();
            
        }

    }
}
