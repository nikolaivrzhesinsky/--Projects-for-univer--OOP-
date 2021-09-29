using System;

namespace ex_3._4
{
    class paramsTest
    {
        public static int sum(params int[] array)
        {
            int Sum = 0;
            foreach(int temp in array)
            {
                Sum += temp;
            }
            return Sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(paramsTest.sum(25, 4, 4)  );
        }
    }
}
