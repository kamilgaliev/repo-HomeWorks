using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbersApp
{
    class Program
    {
        /*
        * Галиев Камиль
        * 
        * С клавиатуры вводятся числа, пока не будет введен 0. 
        * Подсчитать сумму всех нечетных положительных чисел
        */

        public static bool IsNumber(string number)
        {
            int num;
            if (Int32.TryParse(number, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SumNumbers(int sum,int number)
        {
            if (number % 2 != 0 && number != 0 && number > 0)
                sum = sum + number;

            return sum;
        }
        static void Main(string[] args)
        {
            int MyNumber = -1;
            int sum = 0;
            int count = 1;
            while (MyNumber != 0)
            {
                Console.WriteLine($"Введите число №{count}. Для получения результата введите 0");
                string number = Console.ReadLine();
                
                if (IsNumber(number))
                {
                    MyNumber = Convert.ToInt32(number);

                    sum  = SumNumbers(sum,MyNumber);
                    count++;
                }
                else
                {
                    Console.WriteLine("Вы ввели букву или слово\n");
                }
            }

            Console.WriteLine($"Сумма нечетных положительных чисел равна {sum}");
            Console.ReadLine();
        }
    }
}
