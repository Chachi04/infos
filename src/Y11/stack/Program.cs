using System;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr;
            Stack<int> myStack = new Stack<int>(100);
            Console.Write("Enter expression: ");
            expr = Console.ReadLine();
            if (expr[0] == '}') { Console.WriteLine("Wrong"); return; }
            myStack.Push(expr[0]);
            for (int i = 1; i < expr.Length; i++)
            {
                if (expr[i] == '{') myStack.Push(expr[i]);
                else
                {
                    if (myStack.Count > 0)
                        myStack.Pop();
                    else
                    {
                        Console.WriteLine("Wrong");
                        return;
                    }
                }
            }
            if (myStack.Count > 0) Console.WriteLine("Wrong");
            else Console.WriteLine("Correct");
        }
    }
}
