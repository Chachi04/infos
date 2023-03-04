using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void ex1()
        {
            string s;
            Regex pattern = new Regex(@"[a-zA-Z0-9\.]*@[a-zA-Z0-9\.]*");
            s = Console.ReadLine();
            if (!pattern.IsMatch(s))
            {
                Console.WriteLine("No email address"); ;
                return;
            }
            Console.WriteLine(pattern.Match(s));
        }
        static void ex2()
        {
            string s;
            Regex pattern = new Regex(@"[a-zA-Z0-9\.]*@[a-zA-Z0-9\.]*");
            s = Console.ReadLine();
            MatchCollection mc = pattern.Matches(s);
            foreach (var item in mc)
            {
                Console.WriteLine(item);
            }
        }
        static void ex3()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
