using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Lab.tesr
{
    class smartHouse
    {
        public DateTime date { get; set; }  //дата замера
        public string room { get; set; }   // комната
        public int detector { get; set; }  // определяет назначение датчика
        public double signal { get; set; } // показатель, который имеет датчик
       
        
        public smartHouse() { }

        public smartHouse(DateTime date, string room, int detector, double signal)
        {
            this.date = date;
            this.room = room;
            this.detector = detector;
            this.signal = signal;
        }
        public void Print()
        {
            switch (detector)
            {
                case 1:
                {
                        
                        Console.WriteLine($"Date- {date} Room- {room} Темпаратура- {signal} градусов");
                        break;
                }
                case 2:
                    {
                        Console.WriteLine($"Date- {date} Room- {room} Влажность- {signal}");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine($"Date- {date} Room-{room} Давление- {signal}");
                        break;
                    }
                
            }
        }

        public override string ToString()
        {
            return ($"{date} {room} {detector} {signal}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\абв\Documents\GitHub\--Projects-for-univer\test2.txt";
            List<smartHouse> detectors = new List<smartHouse>();
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            int sizeList;
            using (StreamReader sr = new StreamReader(fs))
            {
                int N = 0;
                while (!sr.EndOfStream)
                {
                    string[] array = sr.ReadLine().Split();
                    detectors.Add(new smartHouse(Convert.ToDateTime(array[0]), array[1], int.Parse(array[2]), double.Parse(array[3])));

                    N++;
                }
                sizeList = N;
            }

            bool endPoint = true;
            while (endPoint)
            {
                Console.WriteLine("             Меню\n");
                Console.WriteLine("1- Вывести содержимое файла на экран\n");  //+
                Console.WriteLine("2- Вывести отдельную строчку на экран\n"); //+
                Console.WriteLine("3- Редактирование записи\n");
                Console.WriteLine("4- Удаление записи\n");
                Console.WriteLine("5- Добавление записи\n");
                Console.WriteLine("0- Выход из меню\n"); //+
                Console.WriteLine("\n");
                Console.WriteLine("Введите номер операции для выполнения: ");

                int switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                switch (switch_on)
                {
                    case 1:
                        {
                            Console.Clear();
                            for (int i = 0; i <sizeList ; i++)
                            {
                                detectors[i].Print();
                            }
                            Console.WriteLine("\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            string[] lines = File.ReadAllLines(path);
                            Console.WriteLine("введите номер записи: ");
                            int num = int.Parse(Console.ReadLine());
                            string[] temp = lines[num-1].Split(' ');
                           for(int i = 0;i <temp.Length; i++)
                            {
                                Console.Write(temp[i]+ " ");
                            }
                            Console.WriteLine("\n");
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            detectors.Add(new smartHouse());
                            Console.WriteLine("Добавление днных с клавиатуры. Введите параметры");
                            Console.WriteLine("Введите дату в формате (2009-05-01T07:54:59)");
                            
                            break;
                        }

                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Вы действительно хотите выйти?\n");
                            Console.WriteLine("1-yes, 0-no");
                            int signal = int.Parse(Console.ReadLine());
                            if (signal == 1)
                            {
                                endPoint = false;
                            }
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

