using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student2
{
    public class Student
    {
        public string name;
        public int id;
        public int schoolClass;

        private double dBEL, dForeign, dMath, dPhys, dChem, dBio;

        public double DBEL
        {
            get { return this.dBEL; }
            set
            {
                if (value >= 2.0 && value <= 6.0) this.dBEL = value;
                else
                {
                    Console.WriteLine("Грешни данни! оценката автоматично ще се приеме за 2.");
                    this.dBEL = 2;
                }
            }
        }
        public double DForeign
        {
            get { return this.dForeign; }
            set
            {
                if (value >= 2.0 && value <= 6.0) this.dForeign = value;
                else
                {
                    Console.WriteLine("Грешни данни! оценката автоматично ще се приеме за 2.");
                    this.dForeign = 2;
                }
            }
        }
        public double DMath
        {
            get { return this.dMath; }
            set
            {
                if (value >= 2.0 && value <= 6.0) this.dMath = value;
                else
                {
                    Console.WriteLine("Грешни данни! оценката автоматично ще се приеме за 2.");
                    this.dMath = 2;
                }
            }
        }
        public double DPhys
        {
            get { return this.dPhys; }
            set
            {
                if (value >= 2.0 && value <= 6.0) this.dPhys = value;
                else
                {
                    Console.WriteLine("Грешни данни! оценката автоматично ще се приеме за 2.");
                    this.dPhys = 2;
                }
            }
        }
        public double DChem
        {
            get { return this.dChem; }
            set
            {
                if (value >= 2.0 && value <= 6.0) this.dChem = value;
                else
                {
                    Console.WriteLine("Грешни данни! оценката автоматично ще се приеме за 2.");
                    this.dChem = 2;
                }
            }
        }
        public double DBio
        {
            get { return this.dBio; }
            set
            {
                if (value >= 2.0 && value <= 6.0) this.dBio = value;
                else
                {
                    Console.WriteLine("Грешни данни! оценката автоматично ще се приеме за 2.");
                    this.dBio = 2;
                }
            }
        }
        public double Average { get; set; }
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
            Console.Write("Enter Foreign grade: "); st.DForeign = double.Parse(Console.ReadLine());
            Console.Write("Enter Math grade: "); st.DMath = double.Parse(Console.ReadLine());
            Console.Write("Enter Phys grade: "); st.DPhys = double.Parse(Console.ReadLine());
            Console.Write("Enter Chem grade: "); st.DChem = double.Parse(Console.ReadLine());
            Console.Write("Enter Bio grade: "); st.DBio = double.Parse(Console.ReadLine());
            st.Average = (st.DBEL + st.DForeign + st.DMath + st.DPhys + st.DChem + st.DBio) / 6d;
            Console.WriteLine("С П Р А В К А");
            Console.WriteLine($"за успеха на {st.name}, ученик от");
            Console.WriteLine($"{st.schoolClass} клас, номер {st.id}");
            Console.WriteLine($"BEL           - {st.DBEL}");
            Console.WriteLine($"Foreign       - {st.DForeign}");
            Console.WriteLine($"Math          - {st.DMath}");
            Console.WriteLine($"Phys          - {st.DPhys}");
            Console.WriteLine($"Chem          - {st.DChem}");
            Console.WriteLine($"Bio           - {st.DBio}");
            Console.WriteLine($"Average grade - {Math.Round(st.Average, 2)}");
        }
    }
}
