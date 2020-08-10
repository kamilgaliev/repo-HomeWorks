using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    //Галиев Камиль
    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

    class MyMessage
    {
        string mes;

        public MyMessage(string mes)
        {
            this.mes = mes;
        }

        public void PrintWordsWithLength(int n)
        {
            char[] div = { ' ' };
            string str = String.Empty;
            string[] parts = mes.Replace(".", "").Replace(",", "").Split(div);
           
            for (int i = 0; i < parts.Length; i++)
                if(parts[i].Length <= n)
                    str += parts[i] + " ";
            Console.WriteLine($"Слова которые содержат не более {n} букв: {str}\n");
        }

        public void PrintMessageAfterDeleteWords(string s)
        {
            char[] div = { ' ' };
           
            string AfterDel = mes;
            string[] parts = AfterDel.Replace(".", "").Replace(",", "").Split(div);
            
            for (int i = 0; i < parts.Length; i++)
                if (parts[i].EndsWith(s))
                {
                    int idx = AfterDel.IndexOf(parts[i]);
                    AfterDel = AfterDel.Remove(idx, parts[i].Length);
                }
                    
            Console.WriteLine($"Сообщение после удаления слов которые заканчиваются на {s}: {AfterDel}\n");
        }

        public void MaxLength()
        {
            char[] div = { ' ' };
            string[] parts = mes.Replace(".", "").Replace(",", "").Split(div);
            string max = parts[0];
            for (int i = 1; i < parts.Length; i++)
                if (parts[i].Length > max.Length)
                {
                    max = parts[i];
                }
            Console.WriteLine($"Самое длинное слово в сообщении это: {max}\n");
        }

        public void AllWordsWithMaxLength()
        {
            char[] div = { ' ' };
            string[] parts = mes.Replace(".", "").Replace(",", "").Split(div);
            int max = parts[0].Length;
            for (int i = 1; i < parts.Length; i++)
                if (parts[i].Length > max)
                {
                    max = parts[i].Length;
                }
            StringBuilder a = new StringBuilder();

            for (int i = 0; i < parts.Length; i++)
                if (parts[i].Length == max)
                {
                    a.Append(parts[i] + ", ");
                }
            a.Remove(a.Length - 2, 1);
            Console.WriteLine($"StringBuilder. Самые длинные слова в сообщении: {a}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст\n");
            string poems = Console.ReadLine();
            MyMessage Mess = new MyMessage(poems);
           
            string choice = String.Empty;
            while (choice != "0")
            {
                Console.WriteLine("\n\nВыберите действие:\n1 - Вывести только те слова сообщения,  которые содержат не более n букв\n" +
                    "2 - Удалить из сообщения все слова, которые заканчиваются на заданный символ\n" +
                    "3 - Найти самое длинное слово сообщения\n" +
                    "4 - Сформировать строку с помощью StringBuilder из самых длинных слов сообщения\n" +
                    "0 - Выход из программы\n\n");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите количество букв");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Mess.PrintWordsWithLength(n);
                        break;
                    case "2":
                        Console.WriteLine("Введите букву");
                        string s = Console.ReadLine();
                        Mess.PrintMessageAfterDeleteWords(s);
                        break;
                    case "3":
                        Mess.MaxLength();
                        break;
                    case "4":
                        Mess.AllWordsWithMaxLength();
                        break;
                    default:
                        Console.WriteLine($"Вы ввели {choice}");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
