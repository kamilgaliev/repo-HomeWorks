using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinFromThird
{
    class Program
    {
        /*Галиев Камиль
         * Написать метод, возвращающий минимальное из трёх чисел.
         */

        public static int MyMin(int a, int b, int c)
        {

            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Минимум из трех чисел\n");

            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nМинимальное число из: {a}, {b}, {c} - это {MyMin(a,b,c)}");

            Console.ReadLine();
        }
    }
}
