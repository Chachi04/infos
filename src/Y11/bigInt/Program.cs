using System;

namespace bigInt
{
    public class bigInt
    {
        public string value;
        public char sign;
        public bigInt()
        {
            this.sign = '+';
            this.value = "";
        }
        public bigInt(string s)
        {
            this.sign = (s[0] == '+' || s[0] == '-') ? s[0] : '+';
            this.value = (s[0] == '+' || s[0] == '-') ? s.Substring(1) : s;
        }
        public void Print()
        {
            if (this.sign == '-') Console.Write(this.sign);
            int i = 0;
            if (this.value.Length > 1)
                while (this.value[i] == '0') i++;
            Console.WriteLine(this.value.Substring(i));
        }
        public char addDigit(char d1, char d2, ref int p)
        {
            int x; char c;
            x = (d1 - '0') + (d2 - '0') + p;
            p = x / 10;
            c = (char)(x % 10 + '0');
            return c;
        }
        public bigInt AddPos(bigInt b)
        {
            int i, j, x;
            char c;
            int prenos = 0;
            bigInt result = new bigInt(" ");
            int tL = this.value.Length - 1, bL = b.value.Length - 1;
            for (i = tL, j = bL; i >= 0 && j >= 0; i--, j--)
            {
                c = addDigit(this.value[i], b.value[j], ref prenos);
                result.value = c + result.value;
            }
            if (i < 0)
                while (j >= 0)
                {
                    c = addDigit('0', b.value[j--], ref prenos);
                    result.value = c + result.value;
                }
            if (j < 0)
                while (i >= 0)
                {
                    c = addDigit(this.value[i--], '0', ref prenos);
                    result.value = c + result.value;
                }
            if (prenos != 0) result.value = '1' + result.value;
            return result;
        }
        public int ComparePos(bigInt b)
        {
            if (this.value.Length > b.value.Length) return 1;
            if (this.value.Length < b.value.Length) return -1;
            int i = 0;
            while (i < this.value.Length)
            {
                if (this.value[i] == b.value[i]) { i++; continue; }
                else if (this.value[i] > b.value[i]) return 1;
                else return -1;
            }
            return 0;
        }
        public bigInt SubPos(bigInt c)
        {
            int i, j, x; bigInt result = new bigInt();
            int aL = this.value.Length, bL = c.value.Length;
            char[] a = new char[aL]; for (i = 0; i < aL; i++) a[i] = this.value[i];
            char[] b = new char[bL]; for (i = 0; i < bL; i++) a[i] = c.value[i];
            for (i = aL - 1, j = bL - 1; j >= 0; i--, j--)
            {
                if (a[i] >= b[j]) result.value = (char)(a[i] - b[j] + '0') + result.value;
                else
                {
                    x = i - 1;
                    while (a[x] == '0') x--;
                    a[x] = (char)(a[x] - 1);
                    x++;
                    while (x < i) { a[x] = '9'; x++; }
                    result.value = (char)(a[x] - b[j] + 10 + '0') + result.value;
                }
            }
            while (i >= 0) { result.value = a[i--] + result.value; }
            return result;
        }
        public bigInt Add(bigInt b)
        {
            bigInt result = new bigInt();
            if (this.sign == '+' && b.sign == '+')
            {
                result = this.AddPos(b); result.sign = '+';
            }
            else if (this.sign == '-' && b.sign == '-')
            {
                result = this.AddPos(b); result.sign = '-';
            }
            else
            {
                int x = this.ComparePos(b);
                if (x == 1)
                {
                    result = this.SubPos(b); result.sign = this.sign;
                }
                else if (x == -1)
                {
                    result = b.SubPos(this); result.sign = b.sign;
                }
                else
                {
                    result.value = "0"; result.sign = '+';
                }
            }
            return result;
        }
        public bigInt Sub(bigInt b)
        {
            bigInt result = new bigInt();
            if (this.sign == '+' && b.sign == '-')
            {
                result = this.AddPos(b); result.sign = '+';
            }
            else if (this.sign == '-' && b.sign == '+')
            {
                result = this.AddPos(b); result.sign = '-';
            }
            else
            {
                int x = this.ComparePos(b);
                if (x == 1)
                {
                    result = this.SubPos(b); result.sign = this.sign;
                }
                else if (x == -1)
                {
                    result = b.SubPos(this); result.sign = b.sign;
                }
                else
                {
                    result.value = "0"; result.sign = '+';
                }
            }
            return result;
        }
        public bigInt MulDig(char c)
        {
            int x, prenos = 0;
            bigInt result = new bigInt();
            for (int i = this.value.Length - 1; i >= 0; i--)
            {
                x = (c - '0') * (this.value[i] - '0') + prenos;
                result.value = (char)(x % 10 + '0') + result.value;
                prenos = x / 10;
            }
            if (prenos > 0) result.value = (char)(prenos % 10 + '0') + result.value;
            x = prenos / 10;
            if (x > 0) result.value = (char)(prenos % 10 + '0') + result.value;
            return result;
        }
        public bigInt MulPos(bigInt b)
        {
            string zeros = "0";
            bigInt result = this.MulDig(b.value[b.value.Length - 1]);
            for (int i = b.value.Length - 2; i >= 0; i--)
            {
                bigInt tmp = this.MulDig(b.value[i]);
                tmp.value += zeros; zeros += "0";
                result = result.Add(tmp);
            }
            return result;
        }
        public bigInt Mul(bigInt b)
        {
            bigInt result = this.MulPos(b);
            if (result.value == "0") { result.sign = '+'; return result; }
            if (this.sign == b.sign) result.sign = '+';
            else result.sign = '-';
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bigInt n = new bigInt("-205100491");
            bigInt m = new bigInt("-794899508");
            bigInt k = n.Add(m);
            n.Print();
            k.Print();
        }
    }
}
