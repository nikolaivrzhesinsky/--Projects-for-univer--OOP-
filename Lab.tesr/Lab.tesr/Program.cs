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
                        Console.WriteLine($"Date- {date} Room- {room} Влажность- {signal}%");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine($"Date- {date} Room- {room} Давление- {signal} паскаль");
                        break;
                    }

            }
        }

       
    }


    class Program
    {
        
        static void Sort(List<smartHouse> array,int size)
        {
            
            for (int i = 0; i < size-1; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    int compareDate = DateTime.Compare(array[i].date, array[j].date);
                    if(compareDate>0)
                    {
                        smartHouse temp = new smartHouse();
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    
                }
            }
        }

        static void Update(string path, int sizeList, List<smartHouse> detectors)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i=0; i < sizeList; i++)
            {
                string date = detectors[i].date.ToShortDateString();
                string room = detectors[i].room.ToString();
                string detector = detectors[i].detector.ToString();
                string signal = detectors[i].signal.ToString();
                sw.WriteLine($"{date} {room} {detector} {signal}");
            }
            sw.Close();
            
        }
        static void Delete(int lineNumber, List<smartHouse> detectors)
        {
            detectors.RemoveAt(lineNumber);
           
        }
        
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
                Console.WriteLine("6- Вычислить среднее за выбранный период\n");
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
                            for (int i = 0; i < sizeList; i++)
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
                            string[] temp = lines[num - 1].Split();
                            for (int i = 0; i < temp.Length; i++)
                            {
                                Console.Write(temp[i] + " ");
                            }
                            Console.WriteLine("\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Какую строку вы хотите изменить");
                            int num = int.Parse(Console.ReadLine());
                            bool setCheck = true;
                            while (setCheck)
                            {
                                Console.WriteLine("Введите номер команды");
                                Console.WriteLine("1- смениить дату");
                                Console.WriteLine("2- сменить комнату");
                                Console.WriteLine("3- сменить назначение датчика");
                                Console.WriteLine("4- сменить значение");
                                Console.WriteLine("0- Exit");
                                int comand_on = int.Parse(Console.ReadLine());
                                switch (comand_on)
                                {
                                    case 1:
                                        {
                                            detectors[num-1].date = Convert.ToDateTime(Console.ReadLine());
                                            break;
                                        }
                                    case 2:
                                        {
                                            detectors[num-1].room = Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            detectors[num-1].detector = int.Parse(Console.ReadLine());
                                            break;
                                        }
                                    case 4:
                                        {
                                            detectors[num-1].signal = double.Parse(Console.ReadLine());
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
                                                setCheck= false;
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
                            Update(path, sizeList, detectors);
                            Console.WriteLine("\nБаза данных была обновлена!\n");

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            string[] lines = File.ReadAllLines(path);
                            Console.WriteLine("Введите строчку для удаления: ");
                            int num = int.Parse(Console.ReadLine());
                            sizeList--;
                            Delete(num-1, detectors);
                            Update(path, sizeList, detectors);
                            Console.WriteLine("\nБаза данных была обновлена!\n");
                            for(int i=0; i< sizeList;i++)
                            {
                                detectors[i].Print();
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            
                            Console.WriteLine("Добавление данных с клавиатуры. Введите параметры");
                            Console.WriteLine("Введите дату в формате (ShortDate)");
                            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите название команиты (без пробела)");
                            string place = Console.ReadLine();
                            Console.WriteLine("Введите тип датчика: 1-температуры, 2- влажность, 3- давление ");
                            int detNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Установите числовое значение вычисления");
                            double sigDet = double.Parse(Console.ReadLine());
                            detectors.Add(new smartHouse(dateTime,place,detNum,sigDet));
                            sizeList++;
                            Update(path, sizeList, detectors);
                            Console.WriteLine("\nБаза данных была обновлена!\n");

                            break;
                        }
                    case 6:
                        {
                            Sort(detectors, sizeList);
                            Update(path, sizeList, detectors);
                            Console.WriteLine("\nБаза данных была обновлена!\n");
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
