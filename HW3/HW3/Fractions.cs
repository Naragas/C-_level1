using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
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
            if (denominator == 0)
            {
                throw new ArgumentNullException("Fraction denominator can't be zero");
            }
        }

        public Fractions()
        {

        }

        public Fractions(int numenator, int denominator)
        {
            if(denominator == 0)
            {
                throw new ArgumentException("Fraction denominator can't be zero");
            }

            Simplification(ref numenator, ref denominator);
            
            this.numenator = numenator;
            this.denominator = denominator;


        }

        static int NOD(int numenator , int denominator)
        {
            int a = Math.Abs(numenator);
            int b = Math.Abs(denominator);

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
        static int NOD(Fractions f2)
        {
            int a = Math.Abs(f2.numenator);
            int b = Math.Abs(f2.denominator);

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
        public void Simplification(ref int numenator, ref int denominator)
        {
            int a = NOD(numenator, denominator);
            numenator = numenator / a;
            denominator = denominator / a;                

        }


        public Fractions Summ(Fractions f2)
        {
            Fractions f3 = new Fractions();
            f3.numenator = numenator * f2.denominator + f2.numenator * denominator;
            f3.denominator = denominator * f2.denominator;

            return Simplification(f3);
        }

        public Fractions Diff(Fractions f2)
        {
            Fractions f3 = new Fractions();
            f3.numenator = numenator * f2.denominator - f2.numenator * denominator;
            f3.denominator = denominator * f2.denominator;

            return Simplification(f3);
        }

        public Fractions Mult(Fractions f2)
        {
            Fractions f3 = new Fractions();
            f3.numenator = numenator * f2.numenator;
            f3.denominator = denominator * f2.denominator;

            return Simplification(f3);
        }

        public Fractions Divi(Fractions f2)
        {
            Fractions f3 = new Fractions();
            f3.numenator = numenator * f2.denominator;
            f3.denominator = denominator * f2.numenator;

            return Simplification(f3);
        }

        public override string ToString()
        {
            return numenator + "/" + denominator;
        }

    }
}
