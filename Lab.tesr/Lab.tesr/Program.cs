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

                        Console.WriteLine($" Date- {date} Room- {room} Темпаратура- {signal} градусов");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($" Date- {date} Room- {room} Влажность- {signal}%");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine($" Date- {date} Room- {room} Давление- {signal} паскаль");
                        break;
                    }


            }
        }


    }


    class Program
    {

        static void Sort(List<smartHouse> array, int size)
        {

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    int compareDate = DateTime.Compare(array[i].date, array[j].date);
                    if (compareDate > 0)
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
            Sort(detectors, sizeList);
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < sizeList; i++)
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
        static void Peaks(DateTime time1, DateTime time2, string room, List<smartHouse> detectors)
        {
            double temperature_peak = -999999999;
            double pressure_peak = -999999999;
            double moisture_peak = -999999999;



            DateTime exacttime = time1;
            for (int i = 0; i < detectors.Count; i++)
            {

                if (exacttime <= detectors[i].date && room == detectors[i].room)
                {
                    while (detectors[i].date <= time2)
                    {
                        if (detectors[i].room == room)
                        {
                            switch (detectors[i].detector)
                            {
                                case 1:
                                    {
                                        if (detectors[i].signal >= temperature_peak)
                                            temperature_peak = detectors[i].signal;
                                        break;
                                    }
                                case 2:
                                    {
                                        if (detectors[i].signal >= moisture_peak)
                                            moisture_peak = detectors[i].signal;

                                        break;
                                    }
                                case 3:
                                    {
                                        if (detectors[i].signal >= pressure_peak)
                                            pressure_peak = detectors[i].signal;
                                        break;
                                    }
                            }
                        }
                        i++;
                        if (i == detectors.Count)
                            break;
                    }
                }
            }
            if (temperature_peak == -999999999 && pressure_peak == -999999999 && moisture_peak == -999999999)
                Console.WriteLine("Нету записей датчиков о данной команте за этот промежуток времени\n");
            else
                Console.WriteLine($"Пик по температуре - {temperature_peak},\nПик по влажности - {moisture_peak},\nПик по давлению - {pressure_peak}\n");

        }

        /*static int CountDays(List<smartHouse> detectors)
        {
            int days=1;
            for(int i = 1; i < detectors.Count; i++)
            {
                if (detectors[i].date != detectors[i - 1].date)
                    days++;
            }

            return days;
        }*/
        static int GetI(List<smartHouse> detectors, DateTime temp)
        {
            int I = 0;
            for(int i=0;i<detectors.Count;i++)
            {
                if (detectors[i].date > temp)
                    break;
                I = i;
            }
            return I;
        }
        static int Get_i(List<smartHouse> detectors, DateTime temp)
        {
            int I = 0;
            for (int i = 0; i < detectors.Count; i++)
            {
                if (detectors[i].date == temp)
                    break;
                I ++;
            }
            return I;
        }
        

        static void AverageInSteps(List<smartHouse> detectors, DateTime time1, DateTime time2, string room, double step)
        {
            StringBuilder sb = new StringBuilder();
            string temp = null;
            string moisture = null;
            string pressure = null;
            string dates = null;

            DateTime currentDate = time1;
            int i = Get_i(detectors, currentDate);


            //int days = CountDays(detectors);
            //int interval = days / (int)step;
            while(currentDate <= time2)
            {
                DateTime tempDate = currentDate.AddDays(step-1);
                int I = GetI(detectors, tempDate);
                
                double sumT = 0;
                double sumM = 0;
                double sumP = 0;
                int countT = 0;
                int countM = 0;
                int countP = 0;
                for (i = i ; i <= I; i++)
                {
                    if (detectors[i].room == room)
                    {
                        switch (detectors[i].detector)
                        {
                            case 1:
                                {
                                    sumT += detectors[i].signal;
                                    countT++;
                                    break;
                                }
                            case 2:
                                {
                                    sumM += detectors[i].signal;
                                    countM++;
                                    break;
                                }
                            case 3:
                                {
                                    sumP += detectors[i].signal;
                                    countP++;
                                    break;
                                }
                        }
                    }
                }
                
                double avTemp = sumT / (double)countT;
                double avMoisture = sumM / (double)countM;
                double avPressure = sumP / (double)countP;

                dates = dates + $"{currentDate.ToShortDateString()}-{tempDate.ToShortDateString()}|";
                if(!double.IsNaN(avTemp))
                {
                    temp = temp + avTemp.ToString() + "\t" + "\t" + "\t";
                    
                }
                if (!double.IsNaN(avMoisture))
                {
                    moisture = moisture + avMoisture.ToString() + "\t" + "\t" + "\t";
                    
                }
                if (!double.IsNaN(avPressure))
                {
                    pressure = pressure + avPressure.ToString() + "\t" + "\t" + "\t";
                    
                }
                currentDate = currentDate.AddDays(step);

            }

            sb.AppendLine(dates);
            sb.AppendLine(temp + $"- Температура ");
            sb.AppendLine(moisture + $" - Влажность ");
            sb.AppendLine(pressure + $" - Давление ");
            Console.WriteLine(sb.ToString());
        }

        private static void printAverage(double averageTemp, double averageWet, double averagePressure, int counterT, int counterW, int counterP)
        {
            if (counterT == 0)
            {
                Console.Write("Данных по температуре нет |");
            }
            else Console.Write($" Температура {averageTemp}");

            if (counterW == 0)
            {
                Console.Write("Данных по влажности нет |");
            }
            else Console.Write($" Влажность {averageWet} ");

            if (counterP == 0)
            {
                Console.Write("Данных по давлению нет |");
            }
            else Console.Write($" Давление {averagePressure} ");
            Console.WriteLine("\n");
        }

        static void averageDays(List<smartHouse> detectors, int size, DateTime temp, string place)
        {
            double averageTemp = 0, averageWet = 0, averagePressure = 0;
            double sumT = 0, sumW = 0, sumP = 0;
            int counterT = 0, counterW = 0, counterP = 0;

            for (int i = 0; i < size; i++)
            {
                if (detectors[i].date.Equals(temp) && detectors[i].room == place)
                {
                    if (detectors[i].detector == 1)
                    {
                        sumT += detectors[i].signal;
                        counterT++;
                    }
                    if (detectors[i].detector == 2)
                    {
                        sumW += detectors[i].signal;
                        counterW++;
                    }
                    if (detectors[i].detector == 3)
                    {
                        sumP += detectors[i].signal;
                        counterP++;
                    }
                }
            }
            averageTemp = sumT / counterT;
            averageWet = sumW / counterW;
            averagePressure = sumP / counterP;
            printAverage(averageTemp, averageWet, averagePressure, counterT, counterW, counterP);
        }
        static void averageMonth(List<smartHouse> detectors, int size, DateTime temp, string place)
        {
            double averageTemp = 0, averageWet = 0, averagePressure = 0;
            double sumT = 0, sumW = 0, sumP = 0;
            int counterT = 0, counterW = 0, counterP = 0;

            for (int i = 0; i < size; i++)
            {
                if (detectors[i].date.Month.Equals(temp.Month) && detectors[i].date.Year.Equals(temp.Year) && detectors[i].room == place)
                {
                    if (detectors[i].detector == 1)
                    {
                        sumT += detectors[i].signal;
                        counterT++;
                    }
                    if (detectors[i].detector == 2)
                    {
                        sumW += detectors[i].signal;
                        counterW++;
                    }
                    if (detectors[i].detector == 3)
                    {
                        sumP += detectors[i].signal;
                        counterP++;
                    }
                }
            }
            averageTemp = sumT / counterT;
            averageWet = sumW / counterW;
            averagePressure = sumP / counterP;
            printAverage(averageTemp, averageWet, averagePressure, counterT, counterW, counterP);
        }

        static void averageYear(List<smartHouse> detectors, int size, DateTime temp, string place)
        {
            double averageTemp = 0, averageWet = 0, averagePressure = 0;
            double sumT = 0, sumW = 0, sumP = 0;
            int counterT = 0, counterW = 0, counterP = 0;

            for (int i = 0; i < size; i++)
            {
                if (detectors[i].date.Year.Equals(temp.Year) && detectors[i].room == place)
                {
                    if (detectors[i].detector == 1)
                    {
                        sumT += detectors[i].signal;
                        counterT++;
                    }
                    if (detectors[i].detector == 2)
                    {
                        sumW += detectors[i].signal;
                        counterW++;
                    }
                    if (detectors[i].detector == 3)
                    {
                        sumP += detectors[i].signal;
                        counterP++;
                    }
                }
            }
            averageTemp = sumT / counterT;
            averageWet = sumW / counterW;
            averagePressure = sumP / counterP;
            printAverage(averageTemp, averageWet, averagePressure, counterT, counterW, counterP);
        }

        static void Main(string[] args)
        {
            String path = @"C:\Users\HYPERPC\Desktop\smarthouse.txt";
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
                Console.WriteLine("7- Вычислить пики за указанный период\n");
                Console.WriteLine("8- Вычислить средние значения за шаг за период\n");
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
                            Console.WriteLine("№ Дата      Комната      Показатель          \n");
                            int stringCounter = 0;
                            for (int i = 0; i < sizeList; i++)
                            {
                                Console.Write(++stringCounter);
                                detectors[i].Print();
                            }
                            Console.WriteLine("\n");
                            bool backMenu = true;
                            while (backMenu)
                            {
                                Console.WriteLine("Введите 1, чтобы вернуться в меню");
                                int back = int.Parse(Console.ReadLine());
                                switch (back)
                                {
                                    case 1:
                                        {
                                            backMenu = false;
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Вы ввели не единицу\n");
                                            break;
                                        }
                                }
                            }
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
                            bool backMenu = true;
                            while (backMenu)
                            {
                                Console.WriteLine("Введите 1, чтобы вернуться в меню");
                                int back = int.Parse(Console.ReadLine());
                                switch (back)
                                {
                                    case 1:
                                        {
                                            backMenu = false;
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Вы ввели не единицу\n");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("№ Дата      Комната      Показатель          \n");
                            int stringCounter = 0;
                            for (int i = 0; i < sizeList; i++)
                            {
                                Console.Write(++stringCounter);
                                detectors[i].Print();
                            }
                            Console.WriteLine("\n");

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
                                            detectors[num - 1].date = Convert.ToDateTime(Console.ReadLine());
                                            break;
                                        }
                                    case 2:
                                        {
                                            detectors[num - 1].room = Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            detectors[num - 1].detector = int.Parse(Console.ReadLine());
                                            break;
                                        }
                                    case 4:
                                        {
                                            detectors[num - 1].signal = double.Parse(Console.ReadLine());
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
                                                setCheck = false;
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
                            bool backMenu = true;
                            while (backMenu)
                            {
                                Console.WriteLine("Введите 1, чтобы вернуться в меню");
                                int back = int.Parse(Console.ReadLine());
                                switch (back)
                                {
                                    case 1:
                                        {
                                            backMenu = false;
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Вы ввели не единицу\n");
                                            break;
                                        }
                                }
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            string[] lines = File.ReadAllLines(path);
                            Console.WriteLine("Введите строчку для удаления: ");
                            int num = int.Parse(Console.ReadLine());
                            sizeList--;
                            Delete(num - 1, detectors);
                            Update(path, sizeList, detectors);
                            Console.WriteLine("\nБаза данных была обновлена!\n");
                            for (int i = 0; i < sizeList; i++)
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
                            detectors.Add(new smartHouse(dateTime, place, detNum, sigDet));
                            sizeList++;
                            Sort(detectors, sizeList);
                            Update(path, sizeList, detectors);
                            Console.WriteLine("\nБаза данных была обновлена!\n");

                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("1- Средние значения по дням\n");
                            Console.WriteLine("2- Среднее значение по месяцам\n");
                            Console.WriteLine("3- Среднее значение по годам \n");
                            Console.WriteLine("Выберите подпункт, введите нужное число\n");
                            int checkAver = int.Parse(Console.ReadLine());
                            switch (checkAver)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите дату(пример: 12.10.1999)\n");
                                        DateTime dateValue = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("Введите название комнаты\n");
                                        string place = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine(dateValue);
                                        averageDays(detectors, sizeList, dateValue, place);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите месяц и год (с новой строки в числовом представлении)\n");
                                        Console.WriteLine("Месяц ");
                                        string month = Console.ReadLine();
                                        Console.WriteLine("\nГод ");
                                        string year = Console.ReadLine();
                                        Console.WriteLine("Введите название комнаты\n");
                                        string place = Console.ReadLine();
                                        string dateDtring = "1." + month + "." + year;
                                        DateTime dareValue = Convert.ToDateTime(dateDtring);
                                        averageMonth(detectors, sizeList, dareValue, place);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите год в числовом представлении\n");
                                        string year = Console.ReadLine();
                                        Console.WriteLine("Введите название комнаты\n");
                                        string place = Console.ReadLine();
                                        string dateDtring = "1.1." + year;
                                        DateTime dateValue = Convert.ToDateTime(dateDtring);
                                        averageYear(detectors, sizeList, dateValue, place);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Ошибка при вводе названия команды, повторите");
                                        break;
                                    }
                            }


                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите начальную дату: ");
                            DateTime dateTimeStart = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите конечную дату дату: ");
                            DateTime dateTimeEnd = Convert.ToDateTime(Console.ReadLine());
                            if (dateTimeEnd > detectors[detectors.Count - 1].date)
                                dateTimeEnd = detectors[detectors.Count - 1].date;
                            Console.WriteLine("Введите название комнаты: ");
                            string exactRoom = Console.ReadLine();
                            Peaks(dateTimeStart, dateTimeEnd, exactRoom, detectors);



                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите начальную дату: ");
                            DateTime dateTimeStart = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Введите конечную дату дату: ");
                            DateTime dateTimeEnd = Convert.ToDateTime(Console.ReadLine());
                            if (dateTimeStart < detectors[0].date)
                                dateTimeStart = detectors[0].date;
                            if (dateTimeEnd > detectors[detectors.Count - 1].date)
                                dateTimeEnd = detectors[detectors.Count - 1].date;
                            Console.WriteLine("Введите название комнаты(датчика): ");
                            string exactRoom = Console.ReadLine();
                            Console.WriteLine("Введите шаг: ");
                            double step = double.Parse(Console.ReadLine());
                            AverageInSteps(detectors, dateTimeStart, dateTimeEnd, exactRoom, step);
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
