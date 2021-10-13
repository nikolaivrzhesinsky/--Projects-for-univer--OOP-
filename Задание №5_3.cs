using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter SW = new StreamWriter("input.txt");
            bool no_stop = true;
            Console.WriteLine("Введите текст. Для завершения ввода поставьтев конце \\.");
            String STR = "";
            while (no_stop)
            {
                String str = Console.ReadLine();
                STR = STR + "\n" + str;
                no_stop = str[str.Length - 1] != '\\';
            }
            STR = STR.Substring(0, STR.Length - 1);
            byte[] utfBytes = Encoding.UTF8.GetBytes(STR);
            byte[] winArr = Encoding.Convert(Encoding.Default, Encoding.UTF8, utfBytes);
            string myString = Encoding.UTF8.GetString(winArr);
            SW.WriteLine(myString);

            utfBytes = Encoding.Unicode.GetBytes(STR);
            winArr = Encoding.Convert(Encoding.Default, Encoding.Unicode, utfBytes);
            myString = Encoding.Unicode.GetString(winArr);
            SW.WriteLine(myString);


            SW.WriteLine(STR);
            SW.Close();

            bool FileExists = File.Exists("input.txt");
            if (FileExists)
            {
                StreamReader SR = new StreamReader("input.txt");

                while (!SR.EndOfStream)
                {
                    string str = SR.ReadLine();
                    Console.WriteLine(str);
                }
                SR.Close();

            }
            else
                Console.WriteLine("Нет файла input.txt.");

            Console.ReadKey();
        }
    }
}
