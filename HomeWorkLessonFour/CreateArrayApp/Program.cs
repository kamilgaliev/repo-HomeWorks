using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateArrayApp
{
    class Program
    {
        /*          
         * Галиев Камиль
         * 
         * Дан  целочисленный  массив  из 20 элементов.  
         * Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
         * Заполнить случайными числами.  
         * Написать программу, позволяющую найти и вывести количество пар элементов массива, 
         * в которых только одно число делится на 3.
        */
        static void Main(string[] args)
        {
            //Размер массива
            int n = 20;

            //Случайные числа
            Random r = new Random();

            //Создаем массив где n - размер массива
            int[] arr = new int[n];

            //Заполняем массив случайными числами
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(-10000, 10000);

            Console.WriteLine("Массив");

            //выводим массив на экран
            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine("\n");

            //количество пар элементов массива, в которых только одно число делится на 3
            int count = 0;
            for (int i = 0; i < n - 1; i++)
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                    count++;

            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {count}");
            Console.ReadLine();
        }
    }
}
