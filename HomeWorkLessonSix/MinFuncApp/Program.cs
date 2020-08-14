using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinFuncApp
{
    //Галиев Камиль
    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и 
    //на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум 
    //через параметр(с использованием модификатора out). 

    public delegate double Fun(double a, double x);

    class Program
    {
        public static double F(double a,double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName,Fun f,double start, double end, double step, out double[] mass, double a=1)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            int i = -1;
            int n=1;
            if (start < 0 && step != 1)
            {
                n = Convert.ToInt32((-1 * start + end+1) / step);
            }
            else if (start >= 0 && step != 1)
            {
                n = Convert.ToInt32((end - start + 1) / step);
            }
            else if (start < 0 && step == 1)
            {
                n = Convert.ToInt32(-1 * start + end + 1);
            }
            else if (start >= 0 && step == 1)
            {
                n = Convert.ToInt32(end - start + 1);
            }
            mass = new double[n];
            while (x <= end)
            {
                i++;
                bw.Write(f(a, x));
                mass[i] = f(a, x);
                x += step;// x=x+h;
                
            }
            bw.Close();
            fs.Close();
        }
       
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static double MyFunc(double a, double x)
        {
            return x * x * x;
        }

        public static double MyFuncTwo(double a,double x)
        {
            return a * (x * x);
        }

        public static double MyFuncThree(double a,double x)
        {
            
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            List<string> ls = new List<string> { "x^2 - 50 * x + 10", "x^3","a * x^2", "a * Sin(x)"};

            double[] mass;

            string choise = String.Empty;
            while (choise != "0")
            {
                Console.WriteLine("Выберите фнукцию:");
                foreach (string str in ls)
                {
                    Console.WriteLine($"{ls.IndexOf(str) + 1} - {str}");
                }
                Console.WriteLine("Для выхода Введите 0\n");
                choise = Console.ReadLine();
                double start=0, end=1,step=0.5, a=1;
                if (choise != "0" && choise != String.Empty)
                {
                    try
                    {
                        Console.WriteLine("Функция от (введите число):");
                        start = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        start = 0;
                    }

                    try
                    {
                        Console.WriteLine("Функция до (введите число):");
                        end = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        end = 1;
                    }
                    try
                    {
                        Console.WriteLine("Шаг (введите число):");
                        step = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        step = 0.5;
                    }
                }

                int n = 1;
                if (start < 0 && step != 1)
                {
                    n = Convert.ToInt32((-1 * start + end + 1) / step);
                }
                else if (start >= 0 && step != 1)
                {
                    n = Convert.ToInt32((end - start + 1) / step);
                }
                else if (start < 0 && step == 1)
                {
                    n = Convert.ToInt32(-1 * start + end + 1);
                }
                else if (start >= 0 && step == 1)
                {
                    n = Convert.ToInt32(end - start + 1);
                }
                mass = new double [n];

                switch (choise)
                {
                    case "1":
                        SaveFunc("data.bin", F,start: start, end: end, step: step, mass:out mass);
                        break;
                    case "2":
                        SaveFunc("data.bin", MyFunc, start: start, end: end, step: step, mass: out mass);
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Введите а:");
                            a = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            a = 1;
                        }
                        SaveFunc("data.bin", MyFuncTwo, start: start, end: end, step: step, mass: out mass, a:a);
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("Введите а:");
                            a = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            a = 1;
                        }
                        SaveFunc("data.bin", MyFuncThree, start: start, end: end, step: step, mass: out mass, a:a);
                        break;
                    default:
                        Console.WriteLine($"Вы ввели {choise}");
                        break;
                }
                if (choise != "0" && choise != String.Empty)
                {
                    Console.WriteLine("OUT. Массив считанных значений");
                    for (int i = 0; i < mass.Length;i++)
                    {
                        Console.Write($"{mass[i]} ");
                    }
                    Console.WriteLine($"\nМинимальное значение: {Load("data.bin")}\n");
                }
            }
            
            Console.ReadKey();
        }
    }
}
