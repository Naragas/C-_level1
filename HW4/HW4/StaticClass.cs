using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class StaticClass
    {
        ///метод поиска пар элементов массива, где только 1 элемент делится на 3
        public static int pairFind(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0)
                {
                    if (array[i + 1] % 3 != 0) result++;
                }
                else
                {
                    if (array[i + 1] % 3 == 0) result++;
                }

            }

            return result;
        }
        /// <summary>
        /// Метод принимающий границы диапазона числе, и заполняет массиы случайными числами из этого диапазона.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] randomArrayGenerator(int minValue, int maxValue,ref int[] array)
        {
            
            Random randomGenerator = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(minValue, maxValue);
            }
            return array;
        }
        /// <summary>
        /// Метод создающий масив из данных в текстовом файле. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] textToArray(String path, ref int[] array)
        {
            try
            {
                StreamReader sr = new StreamReader(path);


                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < array.Length; i++)
                    {

                        string s = sr.ReadLine();
                        int.TryParse(s, out array[i]);
                    }
                }

                sr.Close();
                
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine($"Файл по пути {path} не найден.");
            }
            return array;
        }
    }
}
