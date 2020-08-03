using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexApp
{
    struct StrucComplex
    {
        public double a;
        public double b;

        public StrucComplex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public string Print()
        {
            if (b == 0)
                return $"{a}";
            return b < 0 ? $"{a} - {-b}i" : $"{a} + {b}i";
        }

        public StrucComplex Sum(StrucComplex x, StrucComplex y)
        {
            StrucComplex c = new StrucComplex(x.a + y.a, x.b + y.b);
            return c;
        }

        public StrucComplex Sub(StrucComplex x, StrucComplex y)
        {
            StrucComplex c = new StrucComplex(x.a - y.a, x.b - y.b);
            return c;
        }
    }

    class Complex
    {
        public double a;
        public double b;

        public Complex (double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public string Print()
        {
            if (b == 0)
                return $"{a}";
            return b < 0 ? $"{a} - {-b}i" : $"{a} + {b}i";
        }

        public static Complex Sum (Complex x, Complex y)
        {
            Complex c = new Complex(x.a + y.a, x.b + y.b);
            return c;
        }

        public static Complex Sub(Complex x, Complex y)
        {
            Complex c = new Complex(x.a - y.a, x.b - y.b);
            return c;
        }

        public static Complex Multiplication(Complex x, Complex y)
        {
            Complex c = new Complex(((x.a * y.a) - (x.b * y.b)), ((x.a * y.b) + (x.b * y.a)));
            return c;
        }

        public static Complex Division(Complex x, Complex y)
        {
            double newA = ((x.a * y.a) + (x.b * y.b)) / (y.a * y.a + y.b * y.b);
            double newB = ((x.a * y.b) + (x.b * y.a)) / (y.a * y.a + y.b * y.b);
            Complex c = new Complex(newA, newB);
            return c;
        }
    }

    class Program
    {
        /*
         * Галиев Камиль
         * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
           б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
           в) Добавить диалог с использованием switch демонстрирующий работу класса.
         */

        public static Random rand = new Random();

        public static int Rand()
        {
            
            int randA = -10;
            int randB = 10;

            return rand.Next(randA, randB);
        }

        static void Main(string[] args)
        {
            //Для удобста комплексные числа будут генерироваться методом Rand()
            Console.WriteLine("Структура. Для удобства значения сгенерированы случайным образом");
            StrucComplex strucComp1;
            strucComp1.a = Rand();
            strucComp1.b = Rand();
            Console.WriteLine(strucComp1.Print());

            StrucComplex strucComp2;
            strucComp2.a = Rand();
            strucComp2.b = Rand();
            Console.WriteLine(strucComp2.Print());

            StrucComplex strucCompSum = strucComp1.Sum(strucComp1, strucComp2);

            Console.WriteLine($"Структура: Сумма {strucComp1.Print()} и {strucComp2.Print()} = {strucCompSum.Print()}");

            StrucComplex strucCompSub = strucComp1.Sub(strucComp1, strucComp2);

            Console.WriteLine($"Структура: Разность {strucComp1.Print()} и {strucComp2.Print()} = {strucCompSub.Print()}");

            Console.WriteLine("\nКласс Complex. Для удобства значения сгенерированы случайным образом");
            Complex comp1 = new Complex(Rand(), Rand());
            Console.WriteLine(comp1.Print());

            Complex comp2 = new Complex(Rand(), Rand());
            Console.WriteLine(comp2.Print());

            Complex r = Complex.Sum(comp1,comp2);
            Console.WriteLine($"Класс: Сумма {comp1.Print()} и {comp2.Print()} = {r.Print()}");
            r = Complex.Sub(comp1, comp2);
            Console.WriteLine($"Класс: Разность {comp1.Print()} и {comp2.Print()} = {r.Print()}");

            Console.WriteLine("\nБлок switch\nДоступны операции: + , - , / , * \nДля выхода напишите exit");
            string MyOperation = "";
            do
            {
                MyOperation = Console.ReadLine();

                switch (MyOperation)
                {
                    case "+":
                        Console.WriteLine($"Сумма {comp1.Print()} и {comp2.Print()} = {Complex.Sum(comp1, comp2).Print()}");
                        break;
                    case "-":
                        Console.WriteLine($"Разность {comp1.Print()} и {comp2.Print()} = {Complex.Sub(comp1, comp2).Print()}");
                        break;
                    case "*":
                        Console.WriteLine($"Умножение {comp1.Print()} и {comp2.Print()} = {Complex.Multiplication(comp1, comp2).Print()}");
                        break;
                    case "/":
                        Console.WriteLine($"Деление {comp1.Print()} и {comp2.Print()} = {Complex.Division(comp1, comp2).Print()}");
                        break;
                    default:
                        Console.WriteLine($"Вы ввели {MyOperation}");
                        break;
                }
                if (MyOperation != "exit")
                    Console.WriteLine("\nСледующая операция - введите: + , - , / , * ");
            }
            while (MyOperation != "exit");

            Console.ReadLine();
        }
    }
}
