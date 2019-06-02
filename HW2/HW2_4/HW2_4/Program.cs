using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_4
{
    class Program
    {

        static bool Verification()
        {
            int tryCount = 3;
            String login = "root";
            String password = "GeekBrains";

            Console.WriteLine("Для доступа в систему укажите ваши данные, с учетом регистра.");
            
            do
            {
                Console.Write("Login: ");
                String userLogin = Console.ReadLine();
                if (login.Equals(userLogin))
                {
                    tryCount = 3;
                    do
                    {
                        Console.Write("Password: ");
                        String userPassword = Console.ReadLine();
                        if (userPassword.Equals(password))
                        {
                            return true;
                        }
                        else
                        {
                            tryCount--;
                            Console.WriteLine("Пароль неверный, введите правильный пароль! осталось {0} попыток", tryCount);
                            
                        }
                    } while (tryCount > 0);
                    return false;

                }
                else
                {
                    tryCount--;
                    Console.WriteLine("Данной учетной записи нет в системе, осталось {0} попыток", tryCount);
                }
            } while (tryCount > 0);
            return false;

        }
        static void Main(string[] args)
        {
            if(Verification() == true)
            {
                Console.WriteLine("Добро пожаловать!");
            }
            else
            {
                Console.WriteLine("Введены недействительные учетные данные, вход запрещен!");
            }
            
            Console.ReadLine();


        }
    }
}
