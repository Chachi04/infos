using System;

namespace student2
{
    public class Student{
        public string name;
        public int id;
        public int schoolClass;

        private double dBEL, dForeign, dMath, dPhys, dChem, dBio;
        private double average;

        public double DBEL {
            set { this.dBEL = value; }
            get { return this.dBEL; }
        }
        public double DFOREIGN {
            set { this.dForeign = value; }
            get { return this.dForeign; }
        }
        public double DMATH {
            set { this.dMath = value; }
            get { return this.dMath; }
        }
        public double DPHYS {
            set { this.dPhys = value; }
            get { return this.dPhys; }
        }
        public double DCHEM {
            set { this.dChem = value; }
            get { return this.dChem; }
        }
        public double DBIO {
            set { this.dBio = value; }
            get { return this.dBio; }
        }
        public double Average {
            set { this.average = value; }
            get { return this.average; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.Write("Enter student name: "); st.name = Console.ReadLine();
            Console.Write("Enter class number: "); st.schoolClass = int.Parse(Console.ReadLine());
            Console.Write("Enter student id: "); st.id = int.Parse(Console.ReadLine());
            Console.Write("Enter BEL grade: "); st.DBEL = double.Parse(Console.ReadLine());
            Console.Write("Enter Foreign grade: "); st.DFOREIGN = double.Parse(Console.ReadLine());
            Console.Write("Enter Math grade: "); st.DMATH = double.Parse(Console.ReadLine());
            Console.Write("Enter Phys grade: "); st.DPHYS = double.Parse(Console.ReadLine());
            Console.Write("Enter Chem grade: "); st.DCHEM = double.Parse(Console.ReadLine());
            Console.Write("Enter Bio grade: "); st.DBIO = double.Parse(Console.ReadLine());
            st.Average = (st.DBEL + st.DFOREIGN + st.DMATH + st.DPHYS + st.DCHEM + st.DBIO) / 6d;
            Console.WriteLine("С П Р А В К А");
            Console.WriteLine($"за успеха на {st.name}, ученик от");
            Console.WriteLine($"{st.schoolClass} клас, номер {st.id}");
            Console.WriteLine($"BEL           - {st.DBEL}");
            Console.WriteLine($"Foreign       - {st.DFOREIGN}");
            Console.WriteLine($"Math          - {st.DMATH}");
            Console.WriteLine($"Phys          - {st.DPHYS}");
            Console.WriteLine($"Chem          - {st.DCHEM}");
            Console.WriteLine($"Bio           - {st.DBIO}");
            Console.WriteLine($"Average grade - {Math.Round(st.Average, 2)}");
        }
    }
}
