using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Lab.tesr
{
    class Man
    {

        public string name { get; set; }
        public int age { get; set; }
        public int stage { get; set; }
        public DateTime date { get; set; }

        public Man(string name, int age, int stage, DateTime date)
        {
            this.name = name;
            this.age = age;
            this.stage = stage;
            this.date = date;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Stage: {stage}, Date: {date}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Man> people = new List<Man>();
            FileStream fs = new FileStream(@"C:\Users\абв\Documents\GitHub\--Projects-for-univer\Lab.test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int N = 0;
            while (!sr.EndOfStream)
            {
                string[] array = sr.ReadLine().Split();
                people.Add(new Man(array[0], int.Parse(array[1]), int.Parse(array[2]), Convert.ToDateTime(array[3])));
                N++;
            }
            sr.Close();
            for (int i = 0; i < N; i++)
            {
                people[i].Print();
            }

            bool endPoint = true;
            while (endPoint)
            {
                Console.WriteLine("             Меню\n");
                Console.WriteLine("1- Вывести содержимое файла на экран\n");
                Console.WriteLine("2- Вывести отдельную строчку на экран\n");
                Console.WriteLine("3- Редактирование записи\n");
                Console.WriteLine("4- Удаление записи\n");
                Console.WriteLine("5- Добавление записи\n");
                Console.WriteLine("0- Выход из меню\n");
                Console.WriteLine("\n");
                Console.WriteLine("Введите номер операции для выполнения: " );
                
                int switch_on=Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("\n");
                switch (switch_on)
                {
                    case 1:
                        {
                            for (int i = 0; i < N; i++)
                            {
                                people[i].Print();
                            }
                            break;
                        }
                    case 2:
                        {
                            
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка при вводе названия команды, повторите");
                            break;
                        }
                }
            }

        }
       
    }
}
