using System;
using System.Text;

namespace charArray
{
    class CharArray
    {
        public char[] el;
        public int Length;
        public int MaxLength = 64;

        public CharArray()
        {
            el = new char[64];
            Length = 0;
        }
        public CharArray(int n)
        {
            el = new char[n];
            Length = 0;
        }
        public CharArray(string s)
        {
            el = new char[s.Length + 1];
            for (int i = 0; i < s.Length; i++)
            {
                this.el[i] = s[i];
            }
            Length = s.Length;
        }
        public override string ToString()
            => string.Join("", this.el);

        public void Delete(int pos)
        {
            if (pos < 0 || pos >= this.Length)
                throw new Exception("Index out of bound");
            for (int i = 0; i < this.Length; i++)
            {
                this.el[i] = this.el[i + 1];
            }
            this.Length--;
        }

        public void Insert(int pos, char item)
        {
            if (pos < 0 || pos >= this.Length)
                throw new Exception("Index out of bound");
            for (int i = this.Length; i > pos; i--)
            {
                this.el[i] = this.el[i - 1];
            }
            this.el[pos] = item;
            this.Length++;
        }

        public void Replace(int pos, char item)
        {
            if (pos < 0 || pos >= this.Length)
                throw new Exception("Index out of bound");
            this.el[pos] = item;
        }

        public void Append(char item)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            CharArray s = new CharArray(Console.ReadLine());
            Console.WriteLine("Your string: " + s);
            s.Delete(0);
            Console.WriteLine("Removed the first letter: " + s);
            s.Insert(0, '@');
            Console.WriteLine("Inserted @: " + s);
            s.Replace(s.Length - 1, '@');
            Console.WriteLine("Replaced last letter: " + s);
        }
    }
}
