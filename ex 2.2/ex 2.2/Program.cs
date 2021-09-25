using System;
using System.Collections.Generic;

namespace ex_2._2
{
    class Big_Number
    {
        private uint[] array;           //массив для заполнения состваными частями большого числа
        private static int move = 3;    //ход шага для делениия большого числа
        private bool isNegative;        //проверка на отрицательность 

        public Big_Number(string str)   //конструктор для преобразования из строки
        {
            isNegative = (str[0] == '-');   //проверка, является ли отрицательным
            if (isNegative)
            {
                str = str.Substring(1); //отсекаем минус есл есть
            }
            while (str.Length % move != 0)
            {
                str = "0" + str;        //доводим длину строки до кратности move
            }
            array = new uint[str.Length / move];

            int j = 0;
            for (int i = 0; i < str.Length; i += move)
            {
                string temp = str.Substring(i,move);
                array[j] = Convert.ToUInt32(temp);//запись в массив
                j++;
            }
        }

        public override String ToString()   //переопределяем для вывода на экран
        {
            string res = "";
            if (isNegative) res += "-";
            foreach (uint num in array)
            {
                res += num;
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is Big_Number number &&
                   EqualityComparer<uint[]>.Default.Equals(array, number.array) &&
                   isNegative == number.isNegative;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(array, isNegative);
        }

        public static bool operator == (Big_Number obj1, Big_Number obj2)
        {
            if (obj1.isNegative != obj2.isNegative)
            {
                return false;
            }
            if((obj1.array[0]==0 && obj2.array[0] != 0)||(obj1.array[0] != 0 && obj2.array[0] == 0))
            {
                return false;
            }
            if (obj1.array.Length != obj2.array.Length)
            {
                return false;
            }
            for(int i = 0; i < obj2.array.Length; i++)
            {
                if (obj2.array[i] != obj1.array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator != (Big_Number obj1, Big_Number obj2)
        {
            if (obj1 == obj2)
            {
                return false;
            }
            return true;
        }

        private Big_Number(uint[] array, bool isNegative)   //используем его закрытым для смены знака числа
        {
            this.array = array;
            this.isNegative = isNegative;
        }

        public static Big_Number operator -(Big_Number obj)
        {
            return new Big_Number(obj.array, !(obj.isNegative));
        }

        public static Big_Number operator +(Big_Number obj1, Big_Number obj2)
        {
            int length = obj1.array.Length > obj2.array.Length ? obj1.array.Length : obj2.array.Length;
            uint[] res = new uint[length + 1];  //результирующий массив
            uint c = 1;
            for(int i = 0; i < move; i++)
            {
                c *= 10;
            }
            bool adding = (obj1.isNegative == obj2.isNegative);
            for(int i = 0; i < res.Length; i++)
            {
                res[i] = 0;
            }
            for(int i = 0; i < res.Length; i++)
            {
                if (obj1.array.Length < i)
                {
                    res[i] += obj1.array[i];
                }
                if (obj2.array.Length < i)
                {
                    if (adding)
                    {
                        if (res[i] + obj2.array[i] < c) res[i] += obj2.array[i];
                        else
                        {
                            res[i] += obj2.array[i];
                            res[i] -= c;
                            res[i + 1]++;
                        }
                    }
                    else if (res[i] > obj2.array[i])
                        res[i] -= obj2.array[i];
                    else
                    {
                        res[i] += c;
                        res[i] -= obj2.array[i];
                        res[i + 1]--;
                    }

                }
                
            }
            bool neg = obj1.isNegative;
            if (res[length] < 0)
            {
                foreach (int x in res)
                {
                    x = c - 1 - x;
                }
                res[length] = 0;
                neg = !neg;
            }
            return new Big_Number(res, neg);
        }

        public static Big_Number operator -(Big_Number obj1, Big_Number obj2)
        {
            return obj1 + (-obj2);
        }















    }
    class Program
     {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                Big_Number bn1 = new Big_Number("-1234567890");
                Big_Number bn2 = new Big_Number("987654321");
                Console.WriteLine(bn1);
                Console.WriteLine(bn2);
                Console.WriteLine(bn1==bn2);
                Console.WriteLine(bn1.Equals(bn2));
            }
    }
    
}
