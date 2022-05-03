using System;

namespace static_stack
{
    public class IntStack
    {
        private int n, top;
        private int[] Elements;
        public IntStack(int n)
        {
            this.n = n;
            this.Elements = new int[n];
            this.top = -1;
        }
        public bool NotEmpty()
            => this.top > -1;
        public void Push(int x)
        {
            if (top == this.n - 1)
            {
                this.n += 32;
                Array.Resize(ref this.Elements, this.n);
            }
            this.Elements[++top] = x;
        }
        public int Pop()
        {
            if (top == -1) throw new Exception("Stack is empty");
            return this.Elements[top--];

        }
        public int Peek()
        {
            if (top == -1) throw new Exception("Stack is empty");
            return this.Elements[top];
        }
        public int Size() => top + 1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string expr;
            IntStack myStack = new IntStack(100);
            Console.Write("Enter expression: ");
            expr = Console.ReadLine();
            if (expr[0] == '}') { Console.WriteLine("Wrong"); return; }
            myStack.Push(expr[0]);
            for (int i = 1; i < expr.Length; i++)
            {
                if (expr[i] == '{') myStack.Push(expr[i]);
                else
                {
                    if (myStack.NotEmpty())
                        myStack.Pop();
                    else
                    {
                        Console.WriteLine("Wrong");
                        return;
                    }
                }
            }
            if (myStack.NotEmpty()) Console.WriteLine("Wrong");
            else Console.WriteLine("Correct");
        }
    }
}
