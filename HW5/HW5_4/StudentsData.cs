using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_4
{
    class StudentsData
    {
        public static void studentsData(string path)
        {
            Dictionary<string, double> Totals = new Dictionary<string, double>();
            var data = File.ReadAllLines(path);

            int numberOfStudents = Convert.ToInt32(data[0]);
            double[] averageGrades = new double[numberOfStudents];

            for (int i = 1; i <= numberOfStudents; i++)
            {
                string name = data[i].Substring(0, data[i].Length - 5);
                string grade = data[i].Substring(data[i].Length - 5);
                double result = 0;
                for (int j = 0; j < 3; j++)
                {
                    result += Convert.ToDouble(grade.Split(' ')[j]);
                }
                result = result / 3;
                averageGrades[i - 1] = result;
                try
                {
                    Totals.Add(name, result);
                }
                catch (Exception)
                {

                    Console.WriteLine($"В списке присутствуют однофамильцы {name}");
                    name += $"строка №{i}";
                    Console.WriteLine($"Одному из учеников был добавлен номер строки из списка: {name}\n");

                    Totals.Add(name, result);

                }

            }
            Array.Sort(averageGrades);
            double worstScore = averageGrades[0];

            ShowWorstStudents(Totals, averageGrades);
        }

        private static void ShowWorstStudents(Dictionary<string, double> Totals, double[] averageGrades)
        {
            double worstScore = averageGrades[0];
            int count = 0;
            Console.WriteLine("\nУченики с худшими результатами:");

            do
            {
                foreach (KeyValuePair<string, double> item in Totals)
                {
                    if (item.Value == worstScore)
                    {
                        Console.WriteLine($"{item.Key}, средний балл: {item.Value:F2}");
                        count++;
                    }

                }
                if (count < 3) worstScore = averageGrades[count];

            } while (count < 3);



        }
    }
}
