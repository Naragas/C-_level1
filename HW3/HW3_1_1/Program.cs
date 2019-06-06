using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
 б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 */

namespace HW3_1_1
{
    class Complex
    {
        
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }
        public Complex Mult(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = x2.re * this.re - x2.im * this.im;
            x3.im = this.re * x2.im + this.im * x2.re;
            return x3;
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
            Complex complex1 = new Complex();
            complex1.re = 2;
            complex1.im = 3;

            Complex complex2 = new Complex();
            complex2.re = -1;
            complex2.im = 1;

            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Mult(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());

            Console.ReadLine();

        }
    }

}
