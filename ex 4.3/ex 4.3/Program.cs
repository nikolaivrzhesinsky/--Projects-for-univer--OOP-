using System;

namespace ex_4._3
{
    
    public delegate void Comparison (int[] array); //делегат для сортировки
    public delegate int compareDel (int x, int y);


    class NumberArray
    {
        private int[] array;
        private int size;
        
        public NumberArray(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public int this[int index]  //индексатор
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("вышли за границы массива");
                }
            }
        }

        public void addValue()
        {
            Console.WriteLine( "Введите значения элементов");
            for(int i=0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void setValue(int i, int num)
        {
            try
            {
                array[i] = num;
            }
            catch(Exception e)
            {
                Console.WriteLine( "Ввели неподходящий номер элемента");
            }
        }

        public void getArray()  //вывод на экран
        {
            Console.WriteLine();
            for(int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void sort(Comparison compare)  // сортировка
        {
            compare(array);
        }

        public void copyArray(NumberArray obj) //копирование
        {
            try
            {
                for (int i = 0; i < obj.array.Length; i++)
                {
                    this.array[i] = obj.array[i];
                }
            }
            catch
            {
                 Console.WriteLine("размер массива не подходит для копирования");
            }

        }
        

    }
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            NumberArray obj1 = new NumberArray(6);
            obj1.addValue();        
            obj1.getArray();

            NumberArray copyObj= new NumberArray(6);
            copyObj.copyArray(obj1);

            Comparison Sort_del=bubbleSort;  //????????
            obj1.sort(Sort_del);  //к примеру отсортируем пузырьком
           
            copyObj.getArray();
            obj1[1] = 10;
            Console.WriteLine( obj1[1] );
            


        }

        private static void swap(ref int a1, ref int a2) 
        {
            var temp = a1;
            a1 = a2;
            a2 = temp;
        }

        public static void bubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                        swap(ref array[i], ref array[j]);
        }
    }
}
