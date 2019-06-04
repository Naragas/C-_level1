using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_5
{
    class Program
    {
        static double BMI(double weight, double growth)
        {
            double bmi = weight / (growth * growth);
            return bmi;
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

            double bmi = BMI(weight, growth);
            if (bmi < 18.5)
            {
                Console.WriteLine("У вас дефицит массы тела, кушайте больше!");
            }
            else if(bmi > 25)
            {
                Console.WriteLine("У вас наблюдается ожирение, нужно заняться спортом и кушать меньше углеводов!");
            }
            else
            {
                Console.WriteLine("Ваш индекс массы тела в норме. все хорошо.");
            }

        }
    }
}
