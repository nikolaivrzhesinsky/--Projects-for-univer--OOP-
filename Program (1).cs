using System;


    public class NameAttribute : System.Attribute //атрибут который хранит текстовое описание объекта
{
    public string Text { get; set; }
        public NameAttribute() { }
        public NameAttribute(string text)
        {
            Text = text;
        }
    public override string ToString()
        {
        return Text;
        }

    }

    class FirstClass  // класс с десятью свойствами

{
        [NameAttribute("First property attribute")]
        public string First { get; set; }
        [NameAttribute("Second property attribute")]
        public string Second { get; set; }
        [NameAttribute("Third property attribute")]
        public string Third { get; set; }
        [NameAttribute("Fourth property attribute")]
        public string Fourth { get; set; }
        [NameAttribute("Fifth property attribute")]
        public string Fifth { get; set; }
        [NameAttribute("Sixth property attribute")]
        public string Sixth { get; set; }
        [NameAttribute("Seventh property attribute")]
        public string Seventh { get; set; }
        [NameAttribute("Eighth property attribute")]
        public string Eighth { get; set; }
        [NameAttribute("Ninth property attribute")]
        public string Ninth { get; set; }
        [NameAttribute("Tenth property attribute")]
        public string Tenth { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
            
            var firstclass = new FirstClass();
            
            foreach (var property in firstclass.GetType().GetProperties()) //  foreach проходящий по каждому свойству экземпляра класса

            {

                                                                               // GetCustomAttributes - Извлекает настраиваемый атрибут, примененный к параметру метода.
                foreach (var atribute in property.GetCustomAttributes(false)) // foreach проходящий по всем атрибутам свойства и выводящий строку вида: "ИмяСвойства - ОписаниеСвойства  
                {
                        Console.WriteLine("{0,8} = {1}", property.Name, atribute.ToString());
                    }
                }
            }

        }
    }