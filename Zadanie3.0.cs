using System;
using System.IO; //Библиотека работы с файлами


//Шахматная доска 8x8. Пермитр выпеленной фигруы равен 4*N - 2*n, где N-кол-во клеток, n-кол-во смежных сторон

namespace Zadanie_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int size = 8;
            string path = @"C:\Users\HYPERPC\Desktop\input.txt";
            string[] lines = File.ReadAllLines(path);
            int[,] num = new int[size, size];
            
            int N = Convert.ToInt32(lines[0]); ; //кол-во записанных ячеек

            for (int i = 0; i < size; ++i) //присваивание всем ячейкам массива 0
            {
                for (int j = 0; j < size; ++j)
                    num[i, j] = 0;
            }

            for (int i=1; i <= N; ++i)
            {
                string[] temp = lines[i].Split(' ');
                int k = Convert.ToInt32(temp[0]) - 1;
                int m = Convert.ToInt32(temp[1]) - 1;
                num[k, m] = 1;
                                
            }

            int P = 4 * N;
            
            for (int i=0; i<size;++i) 
            {
                for(int j=0;j<size;++j)
                {
                    if (i == size - 1 || j == size - 1)
                    {
                        if (num[i, j] == 1 && num[i, j - 1] == 1)
                        {
                            P = P - 2;
                        }
                    }
                    else
                    {
                        if (num[i, j] == 1 && num[i, j + 1] == 1)
                            P = P - 2;
                    }
                }
            }
            //просмотр массива по вертикали
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (i == size - 1 || j == size - 1)
                    {
                        if (num[i, j] == 1 && num[i - 1, j] == 1)
                        {
                            P = P - 2;

                        }
                    }
                    else
                    {
                        if (num[i, j] == 1 && num[i + 1, j] == 1)
                            P = P - 2;
                    }
                }
            }
            //просмотр массива по горизонатли

           
            string txt = Convert.ToString(P);

            File.WriteAllText(@"C:\Users\HYPERPC\Desktop\output.txt", txt);


        }
    }
}
