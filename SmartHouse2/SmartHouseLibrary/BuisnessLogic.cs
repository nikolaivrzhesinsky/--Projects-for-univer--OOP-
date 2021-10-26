using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
namespace SmartHouseLibrary
{
    public class BuisnessLogic
    {
        DataBase dataBase = new DataBase();

        public void DataCreation()
        {

            FileStream fs = new FileStream(dataBase.path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    string[] array = sr.ReadLine().Split();
                    dataBase.detectors.Add(new DataBase(Convert.ToDateTime(array[0]), array[1], int.Parse(array[2]), double.Parse(array[3])));
                }

            }
        }

        public void SortList()
        {
            for (int i = 0; i < dataBase.detectors.Count - 1; i++)
            {
                for (int j = i + 1; j < dataBase.detectors.Count; j++)
                {
                    int compareDate = DateTime.Compare(dataBase.detectors[i].date, dataBase.detectors[j].date);
                    if (compareDate > 0)
                    {
                        DataBase temp = new DataBase();
                        temp = dataBase.detectors[i];
                        dataBase.detectors[i] = dataBase.detectors[j];
                        dataBase.detectors[j] = temp;
                    }

                }
            }
        }
        public void Update()
        {

            SortList();
            StreamWriter sw = new StreamWriter(dataBase.path);
            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                string date = dataBase.detectors[i].date.ToShortDateString();
                string room = dataBase.detectors[i].room.ToString();
                string detector = dataBase.detectors[i].detector.ToString();
                string signal = dataBase.detectors[i].signal.ToString();
                sw.WriteLine($"{date} {room} {detector} {signal}");
            }
            sw.Close();
        }

        public string PrintListSize()
        {
            string size;
            return size = dataBase.detectors.Count.ToString();
        }
        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                switch (dataBase.detectors[i].detector)
                {

                    case 1:
                        {

                            sb.AppendLine($"{i + 1}: Date- {dataBase.detectors[i].date.ToShortDateString()} Room- {dataBase.detectors[i].room} Темпаратура- {dataBase.detectors[i].signal} градусов");
                            break;
                        }
                    case 2:
                        {
                            sb.AppendLine($"{i + 1}: Date- {dataBase.detectors[i].date.ToShortDateString()} Room- {dataBase.detectors[i].room} Влажность- {dataBase.detectors[i].signal}%");
                            break;
                        }

                    case 3:
                        {
                            sb.AppendLine($"{i + 1}: Date- {dataBase.detectors[i].date.ToShortDateString()} Room- {dataBase.detectors[i].room} Давление- {dataBase.detectors[i].signal} паскаль");
                            break;
                        }
                }
            }
            return sb.ToString();
        }
        public string PrintLine(int lineNumber)
        {
            string line = null;
            switch (dataBase.detectors[lineNumber - 1].detector)
            {

                case 1:
                    {

                        line = ($"Date- {dataBase.detectors[lineNumber - 1].date.ToShortDateString()} Room- {dataBase.detectors[lineNumber - 1].room} Темпаратура- {dataBase.detectors[lineNumber - 1].signal} градусов");
                        break;
                    }
                case 2:
                    {
                        line = ($"Date- {dataBase.detectors[lineNumber - 1].date.ToShortDateString()} Room- {dataBase.detectors[lineNumber - 1].room} Влажность- {dataBase.detectors[lineNumber - 1].signal}%");
                        break;
                    }

                case 3:
                    {
                        line = ($"Date- {dataBase.detectors[lineNumber - 1].date.ToShortDateString()} Room- {dataBase.detectors[lineNumber - 1].room} Давление- {dataBase.detectors[lineNumber - 1].signal} паскаль");
                        break;
                    }
            }

            return line;
        }
        public void Delete(int lineNumber)
        {
            dataBase.detectors.RemoveAt(lineNumber - 1);

        }
        public void Add(string date, string room, int detector, int signal)
        {
            dataBase.detectors.Add(new DataBase(Convert.ToDateTime(date), room, detector, signal));
            Update();
        }

        public void ChangeDate(int lineNumber, string newDate)
        {
            dataBase.detectors[lineNumber - 1].date = Convert.ToDateTime(newDate);
        }
        public void ChangeRoom(int lineNumber, string newRoom)
        {
            dataBase.detectors[lineNumber - 1].room = newRoom;
        }
        public void ChangeDetector(int lineNumber, int newDetectorNumber)
        {
            dataBase.detectors[lineNumber - 1].detector = newDetectorNumber;
        }
        public void ChangeSignal(int lineNumber, int newSignal)
        {
            dataBase.detectors[lineNumber - 1].signal = newSignal;
        }

        public string AverageDays(string date, string room)
        {
            StringBuilder sb = new StringBuilder();
            double averageTemp = 0, averageWet = 0, averagePressure = 0;
            double sumT = 0, sumW = 0, sumP = 0;
            int counterT = 0, counterW = 0, counterP = 0;
            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                if (dataBase.detectors[i].date.Equals(Convert.ToDateTime(date)) && dataBase.detectors[i].room == room)
                {
                    if (dataBase.detectors[i].detector == 1)
                    {
                        sumT += dataBase.detectors[i].signal;
                        counterT++;
                    }
                    if (dataBase.detectors[i].detector == 2)
                    {
                        sumW += dataBase.detectors[i].signal;
                        counterW++;
                    }
                    if (dataBase.detectors[i].detector == 3)
                    {
                        sumP += dataBase.detectors[i].signal;
                        counterP++;
                    }
                }
            }

            averageTemp = sumT / counterT;
            averageWet = sumW / counterW;
            averagePressure = sumP / counterP;
            sb.AppendLine("Среденее по температуре: " + averageTemp.ToString());
            sb.AppendLine("Среднее по влажности: " + averageWet.ToString());
            sb.AppendLine("Среднее по давлению: " + averagePressure.ToString());
            return sb.ToString();
        }
        public string AverageMonth(DateTime date, string room)
        {
            StringBuilder sb = new StringBuilder();
            double averageTemp = 0, averageWet = 0, averagePressure = 0;
            double sumT = 0, sumW = 0, sumP = 0;
            int counterT = 0, counterW = 0, counterP = 0;

            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                if (dataBase.detectors[i].date.Month.Equals(date.Month) && dataBase.detectors[i].date.Year.Equals(date.Year) && dataBase.detectors[i].room == room)
                {
                    if (dataBase.detectors[i].detector == 1)
                    {
                        sumT += dataBase.detectors[i].signal;
                        counterT++;
                    }
                    if (dataBase.detectors[i].detector == 2)
                    {
                        sumW += dataBase.detectors[i].signal;
                        counterW++;
                    }
                    if (dataBase.detectors[i].detector == 3)
                    {
                        sumP += dataBase.detectors[i].signal;
                        counterP++;
                    }
                }
            }
            averageTemp = sumT / counterT;
            averageWet = sumW / counterW;
            averagePressure = sumP / counterP;
            sb.AppendLine("Среденее по температуре: " + averageTemp.ToString());
            sb.AppendLine("Среднее по влажности: " + averageWet.ToString());
            sb.AppendLine("Среднее по давлению: " + averagePressure.ToString());
            return sb.ToString();
        }
        public string AverageYear(DateTime date, string room)
        {
            StringBuilder sb = new StringBuilder();
            double averageTemp = 0, averageWet = 0, averagePressure = 0;
            double sumT = 0, sumW = 0, sumP = 0;
            int counterT = 0, counterW = 0, counterP = 0;

            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                if (dataBase.detectors[i].date.Year.Equals(date.Year) && dataBase.detectors[i].room == room)
                {
                    if (dataBase.detectors[i].detector == 1)
                    {
                        sumT += dataBase.detectors[i].signal;
                        counterT++;
                    }
                    if (dataBase.detectors[i].detector == 2)
                    {
                        sumW += dataBase.detectors[i].signal;
                        counterW++;
                    }
                    if (dataBase.detectors[i].detector == 3)
                    {
                        sumP += dataBase.detectors[i].signal;
                        counterP++;
                    }
                }
            }
            averageTemp = sumT / counterT;
            averageWet = sumW / counterW;
            averagePressure = sumP / counterP;
            return sb.ToString();
        }

        public string Peaks(DateTime time1, DateTime time2, string room)
        {
            StringBuilder sb = new StringBuilder();
            double temperature_peak = -999999999;
            double pressure_peak = -999999999;
            double moisture_peak = -999999999;

            if (time1 > dataBase.detectors[dataBase.detectors.Count - 1].date)
                time1 = dataBase.detectors[dataBase.detectors.Count - 1].date;

            DateTime exacttime = time1;
            for (int i = 0; i < dataBase.detectors.Count; i++)
            {

                if (exacttime <= dataBase.detectors[i].date && room == dataBase.detectors[i].room)
                {
                    while (dataBase.detectors[i].date <= time2)
                    {
                        if (dataBase.detectors[i].room == room)
                        {
                            switch (dataBase.detectors[i].detector)
                            {
                                case 1:
                                    {
                                        if (dataBase.detectors[i].signal >= temperature_peak)
                                            temperature_peak = dataBase.detectors[i].signal;
                                        break;
                                    }
                                case 2:
                                    {
                                        if (dataBase.detectors[i].signal >= moisture_peak)
                                            moisture_peak = dataBase.detectors[i].signal;

                                        break;
                                    }
                                case 3:
                                    {
                                        if (dataBase.detectors[i].signal >= pressure_peak)
                                            pressure_peak = dataBase.detectors[i].signal;
                                        break;
                                    }
                            }
                        }
                        i++;
                        if (i == dataBase.detectors.Count)
                            break;
                    }
                }
            }

            if (temperature_peak == -999999999)
            {
                sb.AppendLine("Нету записей датчиков по температуре о данной команте за этот промежуток времени");
            }
            else
            {
                sb.AppendLine($"Пик по температуре: {temperature_peak}");
            }
            if (moisture_peak == -999999999)
            {
                sb.AppendLine("Нету записей датчиков по влажности о данной команте за этот промежуток времени");
            }
            else
            {
                sb.AppendLine($"Пик по влажностие: {moisture_peak}");
            }
            if (pressure_peak == -999999999)
            {
                sb.AppendLine("Нету записей датчиков по давлению о данной команте за этот промежуток времени");
            }
            else
            {
                sb.AppendLine($"Пик по температуре: {pressure_peak}");
            }
            return sb.ToString();
        }


        public int GetI(DateTime temp)
        {
            int I = 0;
            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                if (dataBase.detectors[i].date > temp)
                    break;
                I = i;
            }
            return I;
        }
        public int Get_i(DateTime temp)
        {
            int I = 0;
            for (int i = 0; i < dataBase.detectors.Count; i++)
            {
                if (dataBase.detectors[i].date == temp)
                    break;
                I++;
            }
            return I;
        }
        public string AverageInSteps(DateTime time1, DateTime time2, string room, double step)
        {
            StringBuilder sb = new StringBuilder();
            string temp = null;
            string moisture = null;
            string pressure = null;
            string dates = null;

            if (time1 < dataBase.detectors[0].date)
                time1 = dataBase.detectors[0].date;
            if (time2 > dataBase.detectors[dataBase.detectors.Count - 1].date)
                time2 = dataBase.detectors[dataBase.detectors.Count - 1].date;

            DateTime currentDate = time1;
            int i = Get_i(currentDate);

            while (currentDate <= time2)
            {
                DateTime tempDate = currentDate.AddDays(step - 1);
                int I = GetI(tempDate);

                double sumT = 0;
                double sumM = 0;
                double sumP = 0;
                int countT = 0;
                int countM = 0;
                int countP = 0;
                for (i = i; i <= I; i++)
                {
                    if (dataBase.detectors[i].room == room)
                    {
                        switch (dataBase.detectors[i].detector)
                        {
                            case 1:
                                {
                                    sumT += dataBase.detectors[i].signal;
                                    countT++;
                                    break;
                                }
                            case 2:
                                {
                                    sumM += dataBase.detectors[i].signal;
                                    countM++;
                                    break;
                                }
                            case 3:
                                {
                                    sumP += dataBase.detectors[i].signal;
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
                if (!double.IsNaN(avTemp))
                {
                    temp = temp + avTemp.ToString() + "\t" + "\t" + "\t"+"-Температура";

                }
                if (!double.IsNaN(avMoisture))
                {
                    moisture = moisture + avMoisture.ToString() + "\t" + "\t" + "\t"+"-Влажность";

                }
                if (!double.IsNaN(avPressure))
                {
                    pressure = pressure + avPressure.ToString() + "\t" + "\t" + "\t"+"-Давление";

                }
                currentDate = currentDate.AddDays(step);

            }
            sb.AppendLine(dates);
            sb.AppendLine(temp);
            sb.AppendLine(moisture);
            sb.AppendLine(pressure);
            return sb.ToString();
        }
    }
}
