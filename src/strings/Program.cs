using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Split();
            Trim();
        }

        static void Split()
        {
            string listOfNames = "Gosha,Pesho Mariika. Peter";
            char[] seps = new char[] { ' ', ',', '.' };
            string[] names = listOfNames.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }

        static void Trim()
        {
            string data1 = " 111 $ % Text Example ### s ";
            string data2 = " \n\n Text Example ";
            char[] trimCh = new char[] { ' ', '1', '$', '%', '#', 's', '\n' };
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine("Trim with arguments");
            Console.WriteLine(data1.Trim(trimCh));
            Console.WriteLine(data2.Trim(trimCh));
            Console.WriteLine("Trim without arguments");
            Console.WriteLine(data1.Trim());
            Console.WriteLine(data2.Trim());
            Console.WriteLine("------");
            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }
    }
}
