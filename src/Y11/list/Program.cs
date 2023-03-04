using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string> { "one", "abc", "lij" };
            // li.AddRange(new int[] { 4, 5 });
            li.Sort();
            foreach (var item in li)
            {
                Console.Write(item + " ");
            }
        }
    }
}
