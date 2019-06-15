using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*Сахаров Иван
Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) ** с использованием регулярных выражений.
*/
namespace HW5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Логин должен состоять из букв латинского алфавита и цифр.\nПервый симв не должен быть цифрой.\nДлина пароля должна быть от 2 до 10 символов.\nВведите ваш логин: ");
            string userLogin = Console.ReadLine();

            // loginChaeck(userLogin);

            regulLoginCheck(userLogin);
        }

        private static void regulLoginCheck(string userLogin)
        {
            Regex myLoginCheck = new Regex(@"^[a-zA-Z]{1}[a-zA-Z1-9]{1,9}");
            if (myLoginCheck.IsMatch(userLogin))
            {
                Console.WriteLine("Формат ввода логина корректен.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Длина пароля должа быть от 2 до 10 символов и первый символ пароля не должен быть цифрой.");
                Console.ReadKey();
            }
        }

        private static void loginChaeck(string userLogin)
        {
            char[] login = userLogin.ToArray();

            if (login.Length >= 2 && login.Length <= 10 && !char.IsDigit(login[0]))
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z' || char.IsDigit(login[i])) ;

                }
                Console.WriteLine("Формат ввода логина корректен.");
                Console.WriteLine("Пароль должен состоять только из цифр и латинских букв.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Длина пароля должа быть от 2 до 10 символов и первый символ пароля не должен быть цифрой.");
                Console.ReadKey();
            }
        }
    }
}
