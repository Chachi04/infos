using System;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 50000; i++)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            string s = sb.ToString();
            Console.WriteLine(s.Substring(0, 100));
        }
    }
}
