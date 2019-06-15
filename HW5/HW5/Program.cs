using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Сахаров И.С.
//2. Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
//него передается массив слов и текст, в качестве результата метод возвращает сколько раз
//каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.




namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "На вход программе о о о подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. " +
                "В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходи 100, каждая из следующих N строк имеет следующий формат не не не";
            int n = 1;
            string[] words = { "не", "из", "о", "вход" };

            Console.WriteLine($"Слово(слова) с наибольшей длинной:");
            Message.longestWords(s);
            Console.WriteLine();

            Message.showWordsDuplication(words, s);
            Console.WriteLine();

            Console.WriteLine($"Слова длина которых менее чем {n}");
            Message.onlyDefiniteWordLength(s, n);
            Console.WriteLine();

            Message.deletingWordFromText(ref s, 'я');
            Console.WriteLine(s);
            Console.WriteLine();

            Message.deletingWordFromText(ref s, 'е');
            Console.WriteLine(s);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
