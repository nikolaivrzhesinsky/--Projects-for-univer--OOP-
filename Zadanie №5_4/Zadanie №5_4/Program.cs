using System;
using System.Diagnostics;
using System.Text;

namespace Zadanie__5_4
{
    class Program
    {
        static double StringConcatCountTime(int N)
        {
            Stopwatch stopWatch = new Stopwatch();
            string str = "";

            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str = String.Concat(i.ToString(), str);
            }
            stopWatch.Stop();

            return stopWatch.ElapsedMilliseconds;

        }

        static double StringBuilderCountTime(int N)
        {
            Stopwatch stopWatch = new Stopwatch();
            StringBuilder sb = new StringBuilder();

            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append(i.ToString());
            }
            stopWatch.Stop();

            return stopWatch.ElapsedMilliseconds;
        }
        static void Main(string[] args)
        {
            Int32 N = Int32.Parse(Console.ReadLine());
            double t1 = StringConcatCountTime(N);
            double t2 = StringBuilderCountTime(N);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            
        }
    }
}
