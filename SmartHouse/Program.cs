using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SmartHouse
{
    public class smartHouse
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
    }
    public class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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

        }
    }
}
