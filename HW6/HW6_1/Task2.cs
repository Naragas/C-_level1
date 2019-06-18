using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сахаров Иван
Модифицировать программу нахождения минимума функции так, чтобы можно было
передавать функцию в виде делегата.
а) Сделать меню с различными функциями и представить пользователю выбор, для какой
функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,
в котором хранятся различные функции.
*/
namespace HW6_1
{
    public delegate double Func(double a);
    class Task2
    {
             
        
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * x - 30 * x + 20;
        }
        public static double F3(double x)
        {
            return x / (x - 4) * (34 - x);
        }
        public static void SaveFunc(Func F,string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

    }
}
