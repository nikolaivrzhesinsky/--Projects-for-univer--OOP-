using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SmartHouse;

namespace SmartHouse
{
    
        public partial class Form1 : Form
    {
        Program p1 = new Program();

        Class1 cl1 = new Class1();
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        public Form1()
        {
            InitializeComponent();
            cl1.CreateMyButton(btn1, this, "Вывести содержимое файла на экран", 175, 50, 120, 50, ShowList);
            cl1.CreateMyButton(btn2, this, "Вывести отдеальную строчку на экран", 175, 150, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn3, this, "Редактировать запись", 175, 250, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn4, this, "Удаление записи", 175, 350, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn5, this, "Добавление записи", 500, 50, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn6, this, "Вычислить среднее за выбранный период", 500, 150, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn7, this, "Вычислить пики за выбранный период", 500, 250, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn8, this, "Показать график", 500, 350, 120, 50, Click_My_Button);
        }

        public void Click_My_Button(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }
        public void ShowList(object sender, EventArgs e)
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
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < detectors.Count; i++)
            {
                switch (detectors[i].detector)
                {
                    case 1:
                        {
                            sb.AppendLine($" Date- {detectors[i].date} Room- {detectors[i].room} Темпаратура- {detectors[i].signal} градусов");
                            break;
                        }
                    case 2:
                        {
                            sb.AppendLine($" Date- {detectors[i].date} Room- {detectors[i].room} Влажность- {detectors[i].signal}%");
                            break;
                        }
                    case 3:
                        {
                            sb.AppendLine($" Date- {detectors[i].date} Room- {detectors[i].room} Давление- {detectors[i].signal} паскаль");
                            break;
                        }
                }

            }
            MessageBox.Show(sb.ToString());
        }

    }
}
