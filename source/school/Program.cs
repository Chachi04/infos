using System;

namespace school
{
    public class School
    {
        public string name;
        public string address;
        public string telephone;
        public string website;
    }
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Console.Write("Enter the name of the school: "); school.name = Console.ReadLine();
            Console.Write("Enter the address of the school: "); school.address = Console.ReadLine();
            Console.Write("Enter the telephone of the school: "); school.telephone = Console.ReadLine();
            Console.Write("Enter the website of the school: "); school.website = Console.ReadLine();
            bool run = true;
            Console.WriteLine("Choose a question: (1,2,3,4,5)");
            Console.WriteLine("1. What is the name of the school?");
            Console.WriteLine("2. What is the address of the school?");
            Console.WriteLine("3. What is the telephone of the school?");
            Console.WriteLine("4. What is the school's website?");
            Console.WriteLine("5. No further questions.");
            while (run)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine($"The school's name is {school.name}");
                        break;
                    case 2:
                        Console.WriteLine($"The school's address is {school.address}");
                        break;
                    case 3:
                        Console.WriteLine($"The school's telephone is {school.telephone}");
                        break;
                    case 4:
                        Console.WriteLine($"The school's website is {school.website}");
                        break;
                    case 5:
                        run = false;
                        break;
                }
            }
        }
    }
}
