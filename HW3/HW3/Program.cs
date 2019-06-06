﻿using System;
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
        class Fractions
        {
            private int numenator;
            private int denominator;

            public int NumenatorGet()
            {
                return numenator;
            }
            public void NumenatorSet(int value)
            {
                numenator = value;
            }

            public int DemonatorGet()
            {
                return denominator;
            }
            public void DenominatorSet(int value)
            {
                denominator = value;
            }

            public int Denominator { get => denominator; set => denominator = value; }
            
            public Fractions()
            {

            }

            public Fractions(int numenator, int denominator)
            {
                this.numenator = numenator;
                this.denominator = denominator;
            }

            static int NOD(Fractions f2)
            {
                int a = f2.numenator;
                int b = f2.denominator;
                
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                return a;
            }

            public double decimalFraction()
            {
                return (double)numenator / (double)denominator;

            }

            public Fractions Simplification(Fractions f2)
            {
                Fractions f3 = new Fractions();
                f3.numenator = f2.numenator / NOD(f2);
                f3.denominator = f2.denominator / NOD(f2);
                
                return f3;

            }

            public Fractions Summ(Fractions f2)
            {
                Fractions f3 = new Fractions();
                f3.numenator = numenator * f2.denominator + f2.numenator * denominator;
                f3.denominator = denominator * f2.denominator;

                return f3.Simplification(f3);
            }

            public Fractions Diff(Fractions f2)
            {
                Fractions f3 = new Fractions();
                f3.numenator = numenator * f2.denominator - f2.numenator * denominator;
                f3.denominator = denominator * f2.denominator;

                return f3.Simplification(f3);
            }

            public Fractions Mult(Fractions f2)
            {
                Fractions f3 = new Fractions();
                f3.numenator = numenator * f2.numenator;
                f3.denominator = denominator * f2.denominator;

                return f3.Simplification(f3);
            }

            public Fractions Divi(Fractions f2)
            {
                Fractions f3 = new Fractions();
                f3.numenator = numenator * f2.denominator;
                f3.denominator = denominator * f2.numenator;

                return f3.Simplification(f3);
            }

            public String Show()
            {
                return numenator + "/" + denominator;
            }

        }

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
