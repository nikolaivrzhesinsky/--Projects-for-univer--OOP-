using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class ThreeKeyPressedEventArgs : EventArgs
    {
        public char Currentdigit { get; set; }
    }

    class FiveKeyPressedEventArgs : EventArgs
    {
        public char Currentdigit { get; set; }
    }

    class DigitKeyPressedEventArgs : EventArgs
    {
        public char Currentdigit { get; set; }

        public DigitKeyPressedEventArgs(char digit)
        {
            Currentdigit = digit;
        }


    }
    class AnyKeyPressedEventArgs : EventArgs
    {
        public char Currentdigit { get; set; }

        public AnyKeyPressedEventArgs(char key)
        {
            Currentdigit = key;
        }

    }

    class ThreeSubscriber
    {
        public ThreeSubscriber(KeyboardManager e)
        {
            e.ThreeKeyPressed += ThreeKeyPressed;
        }

        public void Unsubscribe(KeyboardManager e)
        {
            e.ThreeKeyPressed -= ThreeKeyPressed;
        }

        public void ThreeKeyPressed(object sender, ThreeKeyPressedEventArgs e)
        {
            if (!(sender is KeyboardManager manager))
                throw new ArgumentException();

            Console.WriteLine("нажатие на 3");
        }
    }

    class FiveSubscriber
    {
        public FiveSubscriber(KeyboardManager e)
        {
            e.FiveKeyPressed += FiveKeyPressed;
        }

        public void Unsubscribe(KeyboardManager e)
        {
            e.FiveKeyPressed -= FiveKeyPressed;
        }
        public void FiveKeyPressed(object sender, FiveKeyPressedEventArgs e)
        {
            if (!(sender is KeyboardManager manager))
                throw new ArgumentException();

            Console.WriteLine("нажатие на 5");
        }
    }

    class DigitSubscriber
    {
        public DigitSubscriber(KeyboardManager e)
        {
            e.DigitKeyPressed += DigitKeyPressed;
        }

        public void Unsubscribe(KeyboardManager e)
        {
            e.DigitKeyPressed -= DigitKeyPressed;
        }
        public void DigitKeyPressed(object sender, DigitKeyPressedEventArgs e)
        {
            if (!(sender is KeyboardManager manager))
                throw new ArgumentException();

            Console.WriteLine("нажатие на " + e.Currentdigit);
        }
    }

    class LogSubscriber
    {
        public LogSubscriber(KeyboardManager e)
        {
            e.AnyKeyPressed += AnyKeyPressed;
        }

        public void UnSubscribe(KeyboardManager e)
        {
            e.AnyKeyPressed -= AnyKeyPressed;
        }

        public void AnyKeyPressed(object sender, AnyKeyPressedEventArgs e)
        {
            if (!(sender is KeyboardManager manager))
                throw new ArgumentException();

            Console.WriteLine("нажатие на " + e.Currentdigit);
            
            string txt = Convert.ToString(e.Currentdigit);
            File.AppendAllText(@"C:\Users\Kirill\Desktop\output.txt", txt);
        }
    }

    class KeyboardManager
    {
        public event EventHandler<ThreeKeyPressedEventArgs> ThreeKeyPressed;
        public event EventHandler<FiveKeyPressedEventArgs> FiveKeyPressed;
        public event EventHandler<DigitKeyPressedEventArgs> DigitKeyPressed;
        public event EventHandler<AnyKeyPressedEventArgs> AnyKeyPressed;

        protected virtual void OnThreeKeyPressed(ThreeKeyPressedEventArgs e)
        {
            EventHandler<ThreeKeyPressedEventArgs> temporary = ThreeKeyPressed;
            if (temporary != null) 
                temporary(this, e); 
        }

        protected virtual void OnFiveKeyPressed(FiveKeyPressedEventArgs e)
        {
            EventHandler<FiveKeyPressedEventArgs> temporary = FiveKeyPressed;
            if (temporary != null) 
                temporary(this, e); 
        }

        protected virtual void OnDigitKeyPressed(DigitKeyPressedEventArgs e)
        {
            EventHandler<DigitKeyPressedEventArgs> temporary = DigitKeyPressed;
            if (temporary != null) 
                temporary(this, e); 
        }
        protected virtual void OnAnyKeyPressed(AnyKeyPressedEventArgs e)
        {
            EventHandler<AnyKeyPressedEventArgs> temporary = AnyKeyPressed;
            if (temporary != null)
                temporary(this, e); 
        }

        public void WaitingForAButtonPress()
        {
            while (true)
            {
                ConsoleKeyInfo smth;
                smth = Console.ReadKey(true);

                char key = smth.KeyChar;

                if (key == '3')
                    this.OnThreeKeyPressed(new ThreeKeyPressedEventArgs());

                if (key == '5')
                    this.OnFiveKeyPressed(new FiveKeyPressedEventArgs());

                if (Char.IsDigit(key) && key != '3' && key != '5')
                    this.OnDigitKeyPressed(new DigitKeyPressedEventArgs(key));

                if (Char.IsLetter(key))
                    this.OnAnyKeyPressed(new AnyKeyPressedEventArgs(key));
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var Manager = new KeyboardManager();
            var Three = new ThreeSubscriber(Manager);
            var Five = new FiveSubscriber(Manager);
            var Digit = new DigitSubscriber(Manager);
            var Letter = new LogSubscriber(Manager);

            Manager.WaitingForAButtonPress();
        }
    }
}