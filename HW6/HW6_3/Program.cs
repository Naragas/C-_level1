using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сахаров Иван
Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный
массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
*/

namespace HW6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> AllStudents = new List<Students>();
            int bakalavr = 0;
            int magistr = 0;
            int[] courses = { 0, 0, 0, 0, 0, 0 };
            // Создадим необобщенный список
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(@"C:\students.csv");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                AllStudents.Add(new Students(s[0], s[1], int.Parse(s[2]), int.Parse(s[3])));


            }
            foreach (Students student in AllStudents)
            {
                if (student.Course < 5) bakalavr++; else magistr++;
                if (student.Age >= 18 && student.Age <= 20)
                {
                    int course = student.Course;
                    switch (course)
                    {
                        case 1:
                            courses[course - 1] += 1;
                            break;
                        case 2:
                            courses[course - 1] += 1;
                            break;
                        case 3:
                            courses[course - 1] += 1;
                            break;
                        case 4:
                            courses[course - 1] += 1;
                            break;
                        case 5:
                            courses[course - 1] += 1;
                            break;
                        case 6:
                            courses[course - 1] += 1;
                            break;
                    }
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов:{0}", AllStudents.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine("Студентов учащихся на 5 и 6 курсах:{0}", magistr);
            Console.WriteLine("Количество студентов в ворзарсте от 18 до 20 по курсам:");
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != 0)
                {
                    Console.WriteLine($"Куср {i + 1}: {courses[i]}");
                }

            }

            var sortedStudentsList = AllStudents.OrderBy(Students => Students.Course).ThenBy(Students => Students.Age).ToList();
            foreach (Students item in sortedStudentsList)
            {
                Console.WriteLine(item.showStudent());
            }

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}

