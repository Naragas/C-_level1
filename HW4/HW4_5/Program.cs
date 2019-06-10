using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwoDimensionalArrayLibrary;

/*а) Реализовать библиотеку с классом для работы с двумерным массивом. 
 * Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, 
 * сумму всех элементов массива больше заданного, 
 * свойство, возвращающее минимальный элемент массива, 
 * свойство, возвращающее максимальный элемент массива, 
 * метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
*в) Обработать возможные исключительные ситуации при работе с файлами.
*/


namespace HW4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string PathToFile = @"C:\Users\{user}\Downloads\two-dim-3x5.csv";
                      
            string Directory = @"C:\Users\{user}\Downloads\";



            MyTwoDimensionalArray TwoDimArray = new MyTwoDimensionalArray(PathToFile);
            Console.WriteLine(TwoDimArray.ToString());

            Console.WriteLine($"Максимальный элемент: {TwoDimArray.Max}");
            Console.WriteLine($"Минимальный элемент: {TwoDimArray.Min}");

            
            Console.WriteLine($"Сумма всех значений: {TwoDimArray.Summ()}");

            ;
            Console.WriteLine($"Сумма всех значений, начиная с {5}: {TwoDimArray.SummMoreThan(5)}");

            List<int> indexNumber = new List<int>();


            TwoDimArray.MaxElementNumber(ref indexNumber);
            Console.WriteLine($"Индекс максимального элемента: {indexNumber}");

            Console.WriteLine($"Данные выгружены в: [{TwoDimArray.OutputdataToDirectory(Directory)}]");

            Console.ReadKey();
        }
    }
}
