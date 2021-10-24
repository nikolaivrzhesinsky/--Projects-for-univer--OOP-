using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;


namespace SmartHouse2
{
    public class DataBase
    {
        public DateTime date { get; set; }  //дата замера
        public string room { get; set; }   // комната
        public int detector { get; set; }  // определяет назначение датчика
        public double signal { get; set; } // показатель, который имеет датчик

        public List<DataBase> detectors = new List<DataBase>();
        public string path = @"C:\Users\HYPERPC\Desktop\smarthouse.txt";

        public DataBase() { }
        public DataBase(DateTime date, string room, int detector, double signal)
        {
            this.date = date;
            this.room = room;
            this.detector = detector;
            this.signal = signal;
        }
    }



}
