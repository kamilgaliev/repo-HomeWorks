using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMyArrayApp
{
    //    Галиев Камиль
    //Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //    в)** Добавьте обработку ситуации отсутствия файла на диске.
    // Сумма элементов массива

    class MyArray
    {
        public int[] a;

        private int n;

        public int LengthArr
        {
            get { return n; }
            private set { n = value; }
        }

        public int this[int iElem]
        {
            get { return a[iElem]; }
            set { a[iElem] = value; }
        }

        public MyArray(int n, int min,int max)
        {
            this.n = n;
            a = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
                a[i] = r.Next(min, max);
        }

        public MyArray(string path)
        {
            if (File.Exists(path))
            {
                
                StreamReader sr = new StreamReader(path);
                string[] strArr = sr.ReadLine().Split(',');
                try
                {
                    this.n = Convert.ToInt32(strArr.Length);
                    a = new int[n];

                    for (int i = 0; i < n; i++)
                        a[i] = Convert.ToInt32(strArr[i]);
                }catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("\nФайл не найден!");
            }
        }

        public void SaveToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(ToString());
            sw.Close();
        }

        public int CountElem()
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
                if ((a[i] % 3 == 0 && a[i + 1] % 3 != 0) || (a[i] % 3 != 0 && a[i + 1] % 3 == 0))
                    count++;
            return count;
        }

        public int SumElem()
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += sum + a[i];
            return sum;
        }

        public void PrintCount()
        {
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {CountElem()}\n");
        }

        public override string ToString()
        {
            string str = String.Empty;
            for (int i = 0; i < a.Length; i++)
                str += $"{a[i]},";
            str = str.Substring(0, str.Length - 1);
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(20, -10000, 10000);

            Console.WriteLine($"Сгенерирован массив для примера: {arr.ToString()} \n");

            //arr.PrintCount();

            //MyArray arr2 = new MyArray(20, -10000, 10000);

            //Console.WriteLine($"массив: {arr2.ToString()} \n");

            //arr2.PrintCount();

            //arr2.SaveToFile("massiv.txt");

            //MyArray arr3 = new MyArray("massiv.txt");

            //Console.WriteLine($"массив из файла: {arr3.ToString()} \n");

            
            string choice = String.Empty;

            while(choice!="0")
            {
                Console.WriteLine("\nВыберите действие\nДля сохранения Сгенерированного массива в файле введите 1\n" +
                    "Сгенерировать новый массив - 2\n" +
                    "Количество пар элементов массива, в которых только одно число делится на 3 - 3\n" +
                    "Массив из файла - 4\n" +
                    "Сумма элементов массива - 5\n" +
                    "Для выхода введите - 0");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": arr.SaveToFile("massiv.txt");
                        break;
                    case "2": arr = new MyArray(20, -10000, 10000);
                        Console.WriteLine($"Сгенерирован массив: {arr.ToString()} \n");
                        break;
                    case "3": arr.PrintCount();
                        break;
                    case "4": arr = new MyArray("massiv.txt");
                        Console.WriteLine($"Массив: {arr.ToString()} \n");
                        break;
                    case "5":Console.WriteLine($"Сумма значении массива {arr.SumElem()}");
                        break;
                    default: Console.WriteLine($"Вы ввели {choice}");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
