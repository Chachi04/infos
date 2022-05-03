using System;

namespace setChar
{
    class SetCharV
    {
        public byte[] elements;
        public int size;
        public SetCharV()
        {
            this.size = 0;
            this.elements = new byte[256];
        }
        public SetCharV(byte[] e, int s)
        {
            this.size = s;
            this.elements = new byte[256];
            for (int i = 0; i < s; i++) this.elements[e[i]] = 1;
        }
        public SetCharV(SetCharV m)
        {
            this.size = m.size;
            this.elements = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                this.elements[i] = m.elements[i];
            }
        }

        public void Print()
        {
            Console.Write("{");
            if (this.size != 0)
            {
                int i = 0;
                while (this.elements[i] == 0) i++;
                Console.Write(i); i++;
                for (; i < 256; i++)
                    if (this.elements[i] == 1)
                        Console.Write(", " + i);
            }
            Console.Write("}");
            Console.WriteLine();
        }//=> Console.WriteLine("{" + string.Join(", ", this.elements + "}"));
        public SetCharV Union(SetCharV b)
        {
            SetCharV c = new SetCharV();
            for (int i = 0; i < 256; i++)
            {
                if (this.elements[i] == 1 || b.elements[i] == 1)
                {
                    c.elements[i] = 1;
                    c.size++;
                }
            }
            return c;
        }
        public SetCharV Intersection(SetCharV b)
        {
            SetCharV c = new SetCharV();
            for (int i = 0; i < 256; i++)
            {
                if (this.elements[i] == 1 && b.elements[i] == 1)
                {
                    c.elements[i] = 1;
                    c.size++;
                }
            }
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SetCharV a = new SetCharV(new byte[] { 1, 1, 3, 4, 1, 1, 1 }, 7);
            SetCharV b = new SetCharV(new byte[] { 4, 8, 1, 1, 1 }, 5);
            SetCharV c = a.Union(b);
            SetCharV d = a.Intersection(b);
            Console.Write("a: "); a.Print();
            Console.Write("b: "); b.Print();
            Console.Write("Union: "); c.Print();
            Console.Write("Intersection: "); d.Print();
        }
    }
}
