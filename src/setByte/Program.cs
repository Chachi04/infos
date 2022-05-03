using System;

namespace setByte
{
    class SetByte
    {
        public byte[] elements;
        public int size;
        public SetByte()
        {
            this.size = 0;
            this.elements = new byte[256];
        }
        public SetByte(byte[] e, int s)
        {
            this.size = s;
            this.elements = new byte[256];
            for (int i = 0; i < s; i++)
                this.elements[i] = e[i];
            Array.Sort(this.elements, 0, s);
        }
        public SetByte(SetByte s)
        {
            this.size = s.size;
            this.elements = new byte[256];
            for (int i = 0; i < this.size; i++)
                this.elements[i] = s.elements[i];
        }
        public void Print()
        {
            Console.WriteLine("{" + string.Join(", ", this.elements[0..(this.size)]) + "}");
        }
        public SetByte Union(SetByte b)
        {
            SetByte c = new SetByte();
            int n1 = 0, n2 = 0, n = -1, i;
            while (n1 < this.size && n2 < b.size)
            {
                if (this.elements[n1] == b.elements[n2]) n2++;
                if (this.elements[n1] <= b.elements[n2])
                    c.elements[++n] = this.elements[n1++];
                else
                    c.elements[++n] = b.elements[n2++];
            }
            if (n1 == this.size)
                for (i = n2; i < b.size; i++)
                    c.elements[++n] = b.elements[i];
            else
                for (i = n1; i < this.size; i++)
                    c.elements[++n] = this.elements[i];
            c.size = (byte)(n + 1);
            return c;
        }
        public SetByte Intersect(SetByte b)
        {
            SetByte c = new SetByte();
            int n1 = 0, n2 = 0, n = -1;
            while (n1 < this.size && n2 < b.size)
            {
                if (this.elements[n1] < b.elements[n2]) n1++;
                else if (this.elements[n1] > b.elements[n2]) n2++;
                else
                {
                    c.elements[++n] = this.elements[n1++];
                    n2++;
                }
            }
            c.size = (byte)(n + 1);
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SetByte a = new SetByte(new byte[] { 1, 2, 3, 4 }, 4);
            SetByte b = new SetByte(new byte[] { 1, 2, 3, 4, 5, 6 }, 6);
            Console.Write("a: ");
            SetByte c = a.Union(b);
            Console.Write("Union: "); c.Print();
            SetByte d = a.Intersect(b);
            Console.Write("Intersect: "); d.Print();
        }
    }
}
