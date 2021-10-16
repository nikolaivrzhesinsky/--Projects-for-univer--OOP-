using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_3
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        static void Main(string[] args)
        {
            DayOfWeek day;

            Console.Write("Номер дня недели: ");
            int value = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                day = (DayOfWeek)value;
            }
            else
            {
                throw new Exception("Недействительное значение дня недели.");
            }
            Console.WriteLine(day);
        }
    }
}
