using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/* Сахаров Иван.
 * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 */

namespace HW2
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

                if(double.TryParse(s, out data) == false)
                {
                    Console.WriteLine("Введен не верный формат данных");
                } else
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
             
            Console.WriteLine("Индекс массы тела равен - {0:F2}\nНажмите любую клавишу для выхода.", BMI(weight, growth));
            Console.ReadKey();

        }
    }
}
