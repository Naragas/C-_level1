﻿using System;
using System.Linq;
using System.IO;


// Сахаров Иван.
// а) Дописать класс для работы с одномерным массивом. 
//     Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
//     Создать свойство Sum, которое возвращает сумму элементов массива, 
//     метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
//     метод Multi, умножающий каждый элемент массива на определённое число, 
//     свойство MaxCount, возвращающее количество максимальных элементов. 
// б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
// в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr1 = new MyArray(15, 5, 4);
            int[] arr2 = arr1.Inverse();
            MyArray arr3 = new MyArray(30);

            Console.WriteLine("Первый массив:");
            arr1.Print();
            Console.WriteLine("\n\nИнверсированный массив:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            Console.WriteLine();


            Console.WriteLine("\nТретий массив:");

            arr3.Print();

            Console.WriteLine("\n\nРабота метода Multi умножающего каждый элемент массива на желаемое число(В нашем случае 3):\n");

            arr1.Multi(3);
            Console.WriteLine("Первый массив после метода Multi\n");
            arr1.Print();

            Console.WriteLine($"\n\nСумма всех элементов массива номер 3 равна {arr3.Sum}");

            Console.WriteLine($"\n\nКоличество повторений максимального значения {arr3.Max} в массиве номер 3: {arr3.MaxCount}");


            Console.ReadLine();
        }
    }
}

