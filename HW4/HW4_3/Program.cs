using System;
using System.Linq;
using System.IO;

namespace HW4_3
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        public MyArray(int[] array)
        {
            a = new int[array.Length];
                        
        }
        ////  Создание массива и заполнение его случайными числами от min до max
        //public MyArray(int n, int min, int max)
        //{
        //    a = new int[n];
        //    Random rnd = new Random();
        //    for (int i = 0; i < n; i++)
        //        a[i] = rnd.Next(min, max);
        //}

        public MyArray(int n, int start, byte step)
        {
            a = new int[n];
            a[0] = start;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        public int[] Inverse()
        {

            int[] inversArray = new int[a.Length];
            for (int i = 0; i < inversArray.Length; i++)
            {
                inversArray[i] = -a[i];
            }
            return inversArray;
        }

        public void Multi(int number)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= number;
            }
        }


        public int Sum
        {
            get
            {
                int summ = 0;
                foreach (int v in a)
                {
                    summ += v;
                }
                return summ;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        public int MaxCount
        {
            
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == Max) count++;

                }
                return count;

            
            }
        }
        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
        }

        internal static void Inverse(MyArray arr1)
        {
            throw new NotImplementedException();
        }

        internal void Multi()
        {
            throw new NotImplementedException();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //MyArray a = new MyArray(10, 0, 100);
            //Console.WriteLine(a.ToString());
            //Console.WriteLine(a.Max);
            //Console.WriteLine(a.Min);
            //Console.WriteLine(a.CountPositive);
            
            MyArray arr1 = new MyArray(30, 4, 5);
            arr1.Print();
            Console.WriteLine();
            Console.WriteLine(arr1.MaxCount);
            Console.WriteLine(arr1.Sum);
            Console.WriteLine(arr1.MaxCount);
            arr1.Multi(5);
            arr1.Print();
                        
            
            
          

            Console.ReadLine();



        }
    }
}

