using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbersInNumberApp
{
    class Program
    {
        /*
         * Галиев Камиль
         * 
         * Написать метод подсчета количества цифр числа
         */

        public static bool IsNumber(string number)
        {
            int num;
            if (Int32.TryParse(number,out num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static int CountNumbers(int number)
        {
            int count = 0;

            do
            {
                count++;
                number = number / 10;
            }
            while (number != 0);

            return count;
        }
        static void Main(string[] args)
        {
            int MyNumber = -1;

            while(MyNumber < 0)
            {
                Console.WriteLine("Введите положительное число");
                string number = Console.ReadLine();

                if (IsNumber(number))
                {
                    MyNumber = Convert.ToInt32(number);

                    int count = CountNumbers(MyNumber);
                    if (count == 1)
                    {
                        Console.WriteLine($"Число {MyNumber} состоит из {count} числа");
                    }
                    else
                    {
                        Console.WriteLine($"Число {MyNumber} состоит из {count} чисел");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели букву или слово\n");
                }
            }

            Console.ReadLine();

        }
    }
}
