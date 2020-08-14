using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTableApp
{
    //Галиев Камиль
    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x)

    public delegate double Fun(double x);
    public delegate double FunTwo(double a,double x);

    class Program
    {
        public static void Table(Fun F, double start, double end, double step)
        {
            
            for(double x=start; x<end; x+=step)
            {
                Console.WriteLine($"| {x,20} | {F(x),-20} |");
               
            }
            Console.WriteLine(new String('-',50));
        }
        public static void Table(FunTwo F, double a,double start, double end, double step)
        {
            Console.WriteLine($"|------a-----|------x-----|----------F(x)--------|");
            for (double x = start; x < end; x += step)
            {
                Console.WriteLine($"| {a,10} | {x,10} | {F(a,x),-20} |");

            }
            Console.WriteLine(new String('-', 50));
        }

        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        public static double MyFuncTwo(double a,double x)
        {
            return a * (x * x);
        }

        public static double MyFuncThree(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции MyFunc из методички:");          
            Table(MyFunc, -2, 2,1);

            Console.WriteLine("Таблица функции MyFuncTwo a* x^2:");
            Table(MyFuncTwo, 2,-2, 2, 1);

            Console.WriteLine("Таблица функции MyFuncThree a* sin(x):");
            Table(MyFuncThree, 2, -2, 2, 1);

            Console.ReadLine();
        }
    }
}
