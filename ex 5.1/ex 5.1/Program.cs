using System;

namespace ex_5._1
{
    class Man
    {
        public String name { get; set; }
        public String state { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Man obj1 = new Man { name = "Oleg", state = "Киргизия", age = 12 };
            Console.WriteLine($"Name {obj1.name} State {obj1.state} Age {obj1.age}");

            //2.
            Console.WriteLine($"Name: {0} State: {1} Age: {2}", obj1.name, obj1.state, obj1.age);

            //3.
            int x = 8;
            int y = 9;
            string result = $"{x} + {y} = {x + y}";
            Console.WriteLine(result);

            //4.
            Console.WriteLine($"Имя: {obj1.name,-10} Возраст: {obj1.age}"); // пробелы после
            Console.WriteLine($"Имя: {obj1.name,10} Возраст: {obj1.age}"); // пробелы до

            //5.
            string output = String.Format($"Имя: {obj1.name,-3} Возраст: {obj1.age}");
            Console.WriteLine(output);

            //6.
            long number = 19876543210;
            Console.WriteLine(number.ToString("номер: +# (###) ###-##-##"));// +1 (987) 654-32-10

            double money = 20;
            Console.WriteLine(money.ToString("C2")); // $ 20,00

            //7.
            double number1 = 65.18;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 65,1800

            int number2 = 23;

            string result2 = String.Format("{0:d4}", number2);
            Console.WriteLine(result2); // 0023

            //8.
            Console.WriteLine("Введите значение number3");
            int number3=Convert.ToInt32(Console.ReadLine());

            //9
            var usCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Please specify a date. Format 1: " + usCulture.DateTimeFormat.ShortDatePattern);
            string dateString = Console.ReadLine();
            DateTime userDate;
            if (DateTime.TryParse(dateString, usCulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out userDate))
                Console.WriteLine("Valid date entered (long date format):" + userDate.ToLongDateString());
            else
                Console.WriteLine("Invalid date specified!");

            var esCulture = new System.Globalization.CultureInfo("en-ES");
            Console.WriteLine("Please specify a date. Format 2: " + esCulture.DateTimeFormat.ShortDatePattern);
            string dateString2 = Console.ReadLine();
            DateTime eserDate;
            if (DateTime.TryParse(dateString2, esCulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out eserDate))
            {
                Console.WriteLine("Valid date entered (long date format):" + userDate.ToString("dd.MM.yyyy"));
            }
            else
                Console.WriteLine("Invalid date specified!");

        }
    }
}
