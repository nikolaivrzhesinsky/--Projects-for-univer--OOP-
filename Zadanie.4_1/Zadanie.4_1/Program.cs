using System;

namespace Zadanie._4_1
{
    
    
    public interface BubbleSort
    {
        void sort(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            Console.WriteLine("\nBubblesort: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
    public interface ShellaSort
    {

        void sort(int[] array)
        {
            
            //расстояние между элементами, которые сравниваются
            int d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    int j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        int temp = array[j];
                        array[j] = array[j - d];
                        array[j - d] = temp;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            Console.WriteLine("\nShellaSort: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
    public interface ShakerSort
    {
        void sort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j-1];
                        array[j-1] = array[j];
                        array[j] = temp;
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }
            Console.WriteLine("\nShakerSort: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

        }
    }
    class Program : BubbleSort, ShellaSort, ShakerSort
    {

        
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for(int i=0;i<array.Length;++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var sample = new Program();

            var bubble = sample as BubbleSort;
            var shella = sample as ShellaSort;
            var shaker = sample as ShakerSort;

            bubble.sort(array);
            shella.sort(array);
            shaker.sort(array);
        }
    }
}
