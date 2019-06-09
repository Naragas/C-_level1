using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    class MyArray
    {
        private int[] a;
        Random rnd = new Random();

        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 15);
        }
        /// <summary>
        /// конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="start">начальное значение</param>
        /// <param name="step">шаг</param>
        public MyArray(int n, int start, byte step)
        {
            a = new int[n];
            a[0] = start;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        public MyArray(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл 
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }

        internal bool Multi()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Свойство возращающее количество элементов с максимальным значением.
        /// </summary>
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
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }


        /// <summary>
        /// Метод возвращающий новый массив элоементы которого сменили знак.
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            int[] invArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                invArr[i] = a[i] * -1;
            }
            return invArr;
        }

        public int GetLength
        {
            get
            {
                return a.Length;
            }
        }

        /// <summary>
        /// Свойство возвращающее суммму значений всех элементов массива.
        /// </summary>
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
        /// <summary>
        /// Метод Multi, умножающий каждый элемент массива на определённое число
        /// </summary>
        /// <param name="number">множитель</param>
        public void Multi(int number)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= number;
            }
        }



        /// <summary>
        /// Свойство возращающее максимальное значение элемента массива.
        /// </summary>
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


        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
        }
    }

}
