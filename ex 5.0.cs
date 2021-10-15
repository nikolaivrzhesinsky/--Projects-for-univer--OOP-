using System;

namespace task5_0
{
    class Program
    {
         static void Main()
        {
            Console.WriteLine("Введите символ");
            string simvol = Console.ReadLine();

            if (char.IsDigit( simvol, 0))   
                Console.WriteLine("вы ввели Цифру");
            else if (char.IsLetter(simvol, 0))
                Console.WriteLine("вы ввели Букву");
            else if (char.IsSeparator(simvol, 0))
                Console.WriteLine("вы ввели Знак разделения");
            else if (char.IsControl(simvol, 0))
                Console.WriteLine("вы ввели управляющий символ");
            else if (char.IsPunctuation(simvol, 0))
                Console.WriteLine("вы ввели Знак пунктуации");
            else if (char.IsSymbol(simvol, 0))
                Console.WriteLine("вы ввели Символ");

        }
    }
}
