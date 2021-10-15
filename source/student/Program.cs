using System;

namespace student
{
    public class Student
    {
        public string name;
        public int id;
        public int schoolClass;
        public double dBEL, dForeign, dMath, dPhys, dChem, dBio;
        public double average;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.Write("Enter student name: "); st.name = Console.ReadLine();
            Console.Write("Enter class number: "); st.schoolClass = int.Parse(Console.ReadLine());
            Console.Write("Enter student id: "); st.id = int.Parse(Console.ReadLine());
            Console.Write("Enter BEL grade: "); st.dBEL = double.Parse(Console.ReadLine());
            Console.Write("Enter Foreign grade: "); st.dForeign = double.Parse(Console.ReadLine());
            Console.Write("Enter Math grade: "); st.dMath = double.Parse(Console.ReadLine());
            Console.Write("Enter Phys grade: "); st.dPhys = double.Parse(Console.ReadLine());
            Console.Write("Enter Chem grade: "); st.dChem = double.Parse(Console.ReadLine());
            Console.Write("Enter Bio grade: "); st.dBio = double.Parse(Console.ReadLine());
            st.average = (st.dBEL + st.dForeign + st.dMath + st.dPhys + st.dChem + st.dBio) / 6d;
            Console.WriteLine("С П Р А В К А");
            Console.WriteLine($"за успеха на {st.name}, ученик от");
            Console.WriteLine($"{st.schoolClass} клас, номер {st.id}");
            Console.WriteLine($"BEL           - {st.dBEL}");
            Console.WriteLine($"Foreign       - {st.dForeign}");
            Console.WriteLine($"Math          - {st.dMath}");
            Console.WriteLine($"Phys          - {st.dPhys}");
            Console.WriteLine($"Chem          - {st.dChem}");
            Console.WriteLine($"Bio           - {st.dBio}");
            Console.WriteLine($"Average grade - {Math.Round(st.average, 2)}");
        }
    }
}
