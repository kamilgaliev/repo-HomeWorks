using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWorkApp
{
    class Program
    {
        //Галиев Камиль
        //С помощью рефлексии выведите все свойства структуры DateTime

        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Type DateType = typeof(DateTime);
            foreach (var dt in DateType.GetProperties())
                Console.WriteLine($"{dt.Name} - { GetPropertyInfo(dateTime, Convert.ToString(dt.Name)).GetValue(dateTime, null)}");

            Console.ReadKey();
        }
    }
}
