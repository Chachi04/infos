using System;
using System.Collections.Generic;
using System.Linq;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            // int command = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("> ");
                int[] myArgs = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                switch (myArgs[0])
                {
                    case 1:
                        if (myArgs.Length == 1)
                        {
                            Console.Write("Enter a value to store: ");
                            q.Enqueue(int.Parse(Console.ReadLine()));
                            break;
                        }
                        q.Enqueue(myArgs[1]);
                        break;
                    case 2:
                        Console.WriteLine(q.TryPeek(out int m) ? m : "Queue is empty");
                        break;
                    case 3:
                        Console.WriteLine(q.TryDequeue(out int n) ? n : "Queue is empty");
                        break;
                    case 4:
                        foreach (var item in q)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }

            }
        }
    }
}
