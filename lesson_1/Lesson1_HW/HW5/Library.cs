using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Library
    {
        public static void Pause()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();

        }

        public static void PrintOnConsoleCenter(String ms, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(Console.CursorLeft + x, Console.CursorTop + y);
                Console.WriteLine(ms);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

        }

        public static void PrintOnLineCenter(String ms)
        {
            try
            {
                Console.SetCursorPosition((Console.WindowWidth - ms.Length) / 2, Console.CursorTop);
                Console.WriteLine(ms);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
            
        }


    }
}
