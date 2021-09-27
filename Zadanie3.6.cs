using System;

namespace _4angle
{
    class Program
    {
        
        private string PerimetrAndSquare(double[,] points, out double Perimetr, out double Square)
        {
            
            Perimetr = 0;
            Square = 0;
            string isCollinear = "true";
            double[,] vector = new double[5, 2];

            for (int i = 1; i < 5; i++) //Вектора, найденные через точки вершин
                for (int j = 0; j < 2; j++)
                    vector[i-1, j] = points[i, j] - points[i - 1, j];
            vector[4, 0] = vector[0, 0];
            vector[4, 1] = vector[0, 1];

            for (int i = 0; i < 4; i++) //проверка на коллинираность
            {
                int j = 0;
                if (vector[i, j] * vector[i + 1, j + 1] - vector[i + 1, j] * vector[i, j + 1] == 0)
                    isCollinear = "false";

            }

            if (isCollinear == "true")
            {
                for (int i = 0; i < 4; i++)
                    for (int j = 1; j < 2; j++)
                        Perimetr += Math.Sqrt(Math.Pow(vector[i, j - 1], 2) + Math.Pow(vector[i, j], 2));

                double temp1 = 0; //Переменная для поиска суммы перемножения абсцисс на ординаты по Алгоритму Гаусса
                for (int i = 0; i < 4; i++)
                {
                    int j = 0;
                    temp1 += points[i, j] * points[i + 1, j + 1];

                }
                double temp2 = 0; //Переменная для поиска сумма перемножения ординат на абсциссы по Алгоритму Гаусса
                for (int i = 0; i < 4; i++)
                {
                    int j = 1;
                    temp2 += points[i, j] * points[i + 1, j - 1];
                }
                Square = Math.Abs((temp1 - temp2) / 2); //Формула нахождения площади многоугольника по алгоритму Гаусса

                isCollinear = "периметр: " + Perimetr.ToString()+"\n"+"площадь: " + Square.ToString();
                    

            }

            return isCollinear;

        }
        static void Main(string[] args)
        {
            double Perimetr;
            double Square;

            double[,] points = new double[5,2];
            

            Program obj = new Program();
            for (int i = 0; i < 4; ++i)
             {
                 Console.WriteLine(i+1+"-ая точка");
                 for (int j = 0; j < 2; ++j)
                 {
                     points[i, j] = double.Parse(Console.ReadLine());
                 }
             }
            points[4, 0] = points[0, 0];
            points[4, 1] = points[0, 1];
            Console.WriteLine(obj.PerimetrAndSquare(points, out Perimetr, out Square));
            

            

        }
    }
}
