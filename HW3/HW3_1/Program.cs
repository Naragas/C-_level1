using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Сахаров Иван
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
*/

namespace HW3_1
{
    struct Complex
    {
        public double im;
        public double re;
        
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        
        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex result;

            Complex complex1;
            complex1.re = 2;
            complex1.im = 3;

            Complex complex2;
            complex2.re = -1;
            complex2.im = 1;
            Console.WriteLine("Введите знак *, - или + для выполнения соответствующего действия над комплексными числами");
            String caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "+":
                    result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "-":
                    result = complex1.Minus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "*":
                    result = complex1.Multi(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }                    
            
            Console.ReadLine();
        }
    }


}
