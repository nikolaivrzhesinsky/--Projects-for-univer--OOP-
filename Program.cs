using System;

namespace Zadanie1
{
    public class StringList
    {
        private string[] STR = new string[100];
        private int temp = 0;
        public int Insert(string ss)
        {
            
            if(temp > 100)
            {
                Console.WriteLine("Вы вышли за границы массива");
            }
            else
            {
                STR[temp] = ss;
                temp++;
            }
            return 0;
        }

        public void Delete(int D_index)
        {
            string[] newSTR = new string[STR.Length];

            for(int i=0; i<D_index; i++)
                newSTR[i] = STR[i];

            for (int i = D_index + 1; i < STR.Length; i++)
            {
                newSTR[i - 1] = STR[i];
            }
            temp--;

            STR = newSTR;
        }


        public int Search( string ss)
        {
            int RightIndex =-1;
            for(int i=0; i<STR.Length; i++)
            {
                if (STR[i] == ss)
                {
                    RightIndex = i;
                    break;
                }
                if (i == STR.Length - 1)
                    Console.WriteLine("Данное слово не найдено");
            }
            return RightIndex;
        }
        public void Update (string ss, int index)
        {
            if(index<0 && index > 100)
            {
                return Console.WriteLine(" Нет такого элемента");
            }
            STR[index] = ss;
        }

        public string GetAt(int i)
        {

            return STR[i];
        }

        public static void Main(string[] argc)
        {
            StringList obj1 = new StringList();
        }
    }
}
