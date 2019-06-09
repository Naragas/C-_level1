using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван.
 * Урок номер 4, задания 1 и 2.
Дан  целочисленный  массив  из 20 элементов.  
Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
*/

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"c:\file.txt";
            int minValue = -10000;
            int maxValue = 10000;

            Console.WriteLine(
                $"Приветствую!\nДанная программа создает массив из 20 элементов.\n" +
                $"Заполняет его случайными числами в диапазоне от {minValue} до {maxValue}.\n" +
                $"После чего будет подсчитано количество парных элементов, в которых лишь один делится на 3."
                );                                       
            
            int[] array1 = new int[20];
            int[] array2 = new int[20];

            //Создаем массив случайных чисел из диапазона.
            StaticClass.randomArrayGenerator(minValue, maxValue, ref array1);

            //Создаем массив и заполняем его значениями из файла.
            StaticClass.textToArray(filePath, ref array2);

            Console.WriteLine($"Вот только что сгенерированный массив: ");

            foreach (var a in array1)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine();

            Console.WriteLine($"Удовлетворяющих заданному условию пар в данном массиве - {StaticClass.pairFind(array1)}.");

            foreach (var a in array2)
            {
                Console.Write($"{a} ");
            }

            Console.ReadLine();
        }
    }
}
