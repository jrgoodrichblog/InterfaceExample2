using System;

namespace lesson8
{
    public abstract class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void sayHello()
        {
            Console.WriteLine("Hello, my name is " + this.name);
        }

        public int getAge()
        {
            return this.age;
        }
    }

    public class Teacher : Person
    {
        string subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            setSubject(subject);
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
        }
    }

    class Program
    {
        static void Main()
        {
            // Tim Boyd is the name, 35 is the age, and Math is the subject.
            Teacher teacher = new Teacher("Tim Boyd", 35, "Math");
            teacher.sayHello();
        }
    }
}