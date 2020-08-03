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

        static int GetValue(string message)
        {
            int x;
            string s;
            bool flag;      

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
            
                flag = int.TryParse(s, out x);
            }
            while (!flag); 
            return x;
        }

        public static int SumNumbers(int sum, int number)
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
                string MyStr = $"\nВведите число №{count}. Для получения результата введите 0";
                MyNumber = GetValue(MyStr);

                
                sum = SumNumbers(sum, MyNumber);
                count++;
                
            }

            Console.WriteLine($"Сумма нечетных положительных чисел равна {sum}");
            Console.ReadLine();
        }
    }
}
