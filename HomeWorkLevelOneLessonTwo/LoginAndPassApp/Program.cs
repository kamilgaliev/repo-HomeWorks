using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndPassApp
{
    class Program
    {
        /*
         * Галиев Камиль
         * Реализовать метод проверки логина и пароля.
         */
        public static bool LoginAndPass(string MyLogin, string MyPass)
        {
            string login = "root";
            string pass = "GeekBrains";

            if (MyLogin == login && MyPass == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int count = 3;
            do
            {
                Console.WriteLine("Введите логин и пароль!\n");

                Console.WriteLine("Логин");
                string MyLogin = Console.ReadLine();
                Console.WriteLine("Пароль");
                string MyPass = Console.ReadLine();
                
                if (LoginAndPass(MyLogin, MyPass))
                {
                    Console.WriteLine("Правильный логин и пароль!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Неправильный логин или пароль!\nОсталось попыток {--count}");
                }

            }
            while (count > 0);

            Console.ReadLine();
        }
    }
}
