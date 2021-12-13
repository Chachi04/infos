using System;

namespace inheritance
{
    public class Human
    {
        public string name;
        public int age;
        public string email;
        public Human() { }
        public Human(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
        public virtual void printInfo()
        {
            Console.WriteLine($"Name: {this.name}\nAge: {this.age}\nEmail: {this.email}");
        }
    }
    public class Student : Human
    {
        public int clas;
        public int id;
        public Student(string name, int age, string email, int clas, int id) : base(name, age, email)
        {
            this.clas = clas;
            this.id = id;
        }
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine($"Class: {this.clas}");
            Console.WriteLine($"Id: {this.id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human hu = new Human("Jiaqi", 16, "asd");
            hu.printInfo();
            Human st = new Student("Jiaqi", 17, "2004-a-8@mg-babatonka.bg", 11, 8);
            st.printInfo();
        }
    }
}
