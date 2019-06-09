using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сахаров Иван
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 * 
 * Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
 */
namespace HW4_4
{
    struct Account
    {
        string login;
        string password;

        public string Password { get => password; set => password = value; }
        public string Login { get => login; set => login = value; }


    }

    class Program
    {
        private static void userTryEnter(Account[] SystemAccounts, Account[] UserAuthentication)
        {
            try
            {
                if (SystemAccounts[0].Login.Equals(UserAuthentication[0].Login))
                {
                    if (SystemAccounts[0].Password.Equals(UserAuthentication[0].Password))
                    {
                        Console.WriteLine("Вы ввели корректные данные. Доступ разрешен");
                    }
                    else
                    {
                        Console.WriteLine("Пароль неверный. Доступ запрещен");
                    }
                }
                else if (UserAuthentication[0].Login.Equals(null))
                {

                }
                else
                {
                    Console.WriteLine("Данная учетная запись в системе не найдена.");
                }
            }
            catch (NullReferenceException)
            {
                                
            }

        }

        private static void readAuthenticationFile(string filePath, Account[] UserAuthentication)
        {
            try
            {
                StreamReader streamReader = new StreamReader(filePath);
                while (!streamReader.EndOfStream)
                {
                    UserAuthentication[0].Login = streamReader.ReadLine();
                    UserAuthentication[0].Password = streamReader.ReadLine();
                }

                streamReader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл по пути {filePath} не найден. Считать данные для входа не удалось");
                                
            }

        }

        static void Main(string[] args)
        {


            string filePath = @"c:\authentication.txt";
            Account[] SystemAccounts = new Account[1];
            SystemAccounts[0].Login = "root";
            SystemAccounts[0].Password = "GeekBrains";

            Account[] UserAuthentication = new Account[1];

            Console.WriteLine($"Для входа в систему требуется разместить файл с логином и паролем в дирректории {filePath}.\nПосле этого нажмите Enter");
            Console.ReadKey();

            readAuthenticationFile(filePath, UserAuthentication);

            userTryEnter(SystemAccounts, UserAuthentication);

            Console.ReadLine();


        }


    }
}
