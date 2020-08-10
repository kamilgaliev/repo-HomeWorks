using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginApp
{
    class Program
    {
        //Галиев Камиль
        //Создать программу, которая будет проверять корректность ввода логина.
        //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы 
        //латинского алфавита или цифры, при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений.

        public static bool CheckLoginWithoutReg(string login)
        {
            try
            {
                if (char.GetNumericValue(login[0]) == -1 && login.Length >= 2 && login.Length <= 10)
                {
                    for (int i = 0; i < login.Length; i++)
                        if (char.GetNumericValue(login[i]) == -1)
                            if (('a' <= login[i] && login[i] <= 'z') || ('A' <= login[i] && login[i] <= 'Z'))
                                continue;
                            else
                                return false;
                    return true;
                }

                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckLoginWithReg(string login)
        {
            try
            {
                Regex MyReg = new Regex(@"[a-zA-Z]+[a-zA-Z0-9]{2,10}");
                return MyReg.IsMatch(login);
            }
            catch
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool bWithoutReg = false;

            bool bWithReg = false;

            Console.WriteLine("Проверка логина без регулярных вырожении");
            while (bWithoutReg != true)
            {
                Console.WriteLine("Логин не должен начинаться с цифры. Должен состоять из латинских букв и цифр.\n Длина логина от 2 до 10 символов");
                string login = Console.ReadLine();
                if (CheckLoginWithoutReg(login))
                {
                    Console.WriteLine("Хороший логин\n");
                    bWithoutReg = true;
                }
                else
                    Console.WriteLine("Плохой логин\n");
            }

            Console.WriteLine("Проверка логина с помощью регулярных вырожении");
            while (bWithReg != true)
            {
                Console.WriteLine("Логин не должен начинаться с цифры. Должен состоять из латинских букв и цифр.\n Длина логина от 2 до 10 символов");
                string login = Console.ReadLine();
                if (CheckLoginWithReg(login))
                {
                    Console.WriteLine("Хороший логин\n");
                    bWithReg = true;
                }
                else
                    Console.WriteLine("Плохой логин\n");
            }

            Console.ReadLine();
        }
    }
}
