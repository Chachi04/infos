using System;

namespace toto
{
    class Toto
    {
        private int[] array;
        int cnt, from;
        private int sh = 10000;

        public Toto(int cnt, int from)
        {
            this.cnt = cnt;
            this.from = from;
        }

        private void FillNumbers()
        {
            this.array = new int[from];
            for (int i = 0; i < from; i++)
            {
                this.array[i] = i;
            }
        }
        private void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < sh; i++)
            {
                int x = r.Next(); x = x % from;
                int y = r.Next(); y = y % from;
                int temp = this.array[x];
                this.array[x] = this.array[y];
                this.array[y] = temp;
            }
        }
        public void Draw()
        {
            FillNumbers();
            Shuffle();
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(this.array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Toto r = new Toto(6, 49);
            r.Draw();
        }
    }
}
