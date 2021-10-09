using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы");
            Console.Write("Строки: ");
            int x = int.Parse(Console.ReadLine());  

            Console.Write("Столбцы: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите границы диапозона");
            Console.Write("от: ");
            int ot = int.Parse(Console.ReadLine());

            Console.Write("до: ");
            int po = int.Parse(Console.ReadLine());

            int[,] myArray = new int[x, y];
            Console.WriteLine("Матрица заполняется рандомными числами:");

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {

                    myArray[i, j] = random.Next(ot, po);

                }
            }
                for (int p = 0; p < myArray.GetLength(0); p++)
                {
                    for (int q = 0; q < myArray.GetLength(1); q++)
                    {

                        Console.Write(myArray[p, q] + "\t");
                        
                    }
                    Console.WriteLine();
                }
            
        }
    }
}