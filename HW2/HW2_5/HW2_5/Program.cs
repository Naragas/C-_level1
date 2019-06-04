using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сахаров Иван
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
 * б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */ 

namespace HW2_5
{
    class Program
    {
        static String BMI(double weight, double growth)
        {
            String result = "";
            double bmi = weight / (growth * growth);
           

            if (bmi < 18.5)
            {
                double needWeight = 18.5 * growth * growth -  weight;
                result += "У вас дефицит массы тела, кушайте больше! Вам нужно набрать " + needWeight + " кг.";
            }
            else if (bmi > 25)
            {
                double needWeight = weight - 25 * growth * growth;
                result += "У вас наблюдается ожирение, Вам нужно сбросить " + needWeight + " кг. Займитесь спортом и кушайте меньше углеводов!";
            }
            else
            {
                result += "Ваш индекс массы тела в норме. все хорошо.";
            }


            return result;

        }

        static double gettingInput(String dataName, String dataUnit, ref double data)
        {
            do
            {
                Console.WriteLine($"Введите свой {dataName.ToLower()} в {dataUnit} (например 92,5)");
                String s = Console.ReadLine();

                if (double.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                }
                else
                {
                    if (data == 0 || data < 0)
                    {
                        Console.WriteLine($"{dataName} не может быть меньше или равен нулю.");
                    }
                }

            } while (data == 0 || data < 0);

            return data;
        }


        static void Main(string[] args)
        {
            double weight = 0;
            double growth = 0;

            gettingInput("Вес", "килограммах", ref weight);
            gettingInput("Рост", "метрах", ref growth);

            Console.WriteLine(BMI(weight, growth));
            Console.ReadLine();


        }
    }
}
