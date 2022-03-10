using System;
using System.Linq;
using System.Collections;

namespace parens
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter some brackets: ");
            string line = Console.ReadLine();
            Console.WriteLine(CorrectBrackets(line) ? "Correct" : "Wrong");
        }
        struct Bracket
        {
            public Bracket(char a, char b)
            {
                this.open = a;
                this.close = b;
            }
            public char open;
            public char close;
        };
        static bool CorrectBrackets(string line)
        {
            // Bracket[] brackets1 = new Bracket[3];
            // brackets1[0] = new Bracket('(', ')');
            // brackets1[0] = new Bracket('(', ')');
            // char[] openBrackets = { '(', '[', '{' };
            // char[] closeBrackets = { ')', ']', '}' };
            Stack brackets = new Stack();
            for (int i = 0; i < line.Length; i++)
            {
                if (openclose.Contains(line[i]))
                {
                    brackets.Push(line[i]);
                }
                else if (closeBrackets.Contains(line[i]) && line[i] == (char)brackets.Peek())
                {
                    brackets.Pop();
                }
                else
                    return false;
            }
            if (brackets.Count != 0) return false;
            return true;
        }
    }
}
