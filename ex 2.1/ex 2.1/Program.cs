using System;

namespace ex_2._1
{
    class Man
    {
        protected string name;
        protected int age;

        public Man(string name)
        {
            if (IsNull(name))
            {
                Console.WriteLine("Вы не ввели имя");

            }
            else
            {
                this.name = name;
            }

        }

        public Man(string name, int age):this(name)
        {
            if (IsNull(name))
            {
                Console.WriteLine("Вы не ввели имя");
            }
            else
            {
                this.age = age;
            }
        }

        public virtual void setAge(int age)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return $"Человек {name} {age}";
        }

        private bool IsNull(string name)
        {
            return String.IsNullOrWhiteSpace(name);
        }
    }
     class Teenager: Man
    {
        private String school;
        public Teenager(String name, int age, String school):base(name)
        {
            if(age>12 && age < 20)
            {
                this.age = age;
                this.school = school;
            }
            else
            {
                throw new Exception();
            }
        }

        public override void setAge(int age)
        {
            if (age > 12 && age < 20)
            {
                this.age = age;
            }
            else
            {
                throw new Exception();
            }
        }

        public override string ToString()
        {
            return $"Подросток, {name}, {age}, Место учебы: {school}";
        }
    }
    class Worker: Man
    {
        private String work_place;

        public Worker(String name, int age, String work_place):base(name)
        {
            if(age>15 && age < 71)
            {
                this.age = age;
                this.work_place = work_place;
            }
            else
            {
                throw new Exception();
            }
        }

        public override string ToString()
        {
            return $"Работник, {name}, {age}, Место работы: {work_place}";
        }
    }
    
     
     class Program
     {
            static void Main(string[] args)
            {
                
                Man obj1 = new Man("Tom",15);
                Console.WriteLine(obj1);
                Teenager obj2 = new Teenager("Nick", 16, "School 33");
                Console.WriteLine(obj2);
                Worker obj3 = new Worker("Bill", 29, "каменщик");
                Console.WriteLine(obj3);
            }
     }
}
