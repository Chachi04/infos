using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    public class MyException : Exception
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "hello.txt";
            try
            {
                
                using (StreamReader r = new StreamReader(filename))
                {
                    int[] a = new int[100];
                    int cnt;
                    cnt = int.Parse(r.ReadLine());
                    for(int i = 0; i<= cnt; i++)
                    {
                        a[i] = int.Parse(r.ReadLine());
                    }
                }
            }
            catch (FileNotFoundException notfound)
            {
                Console.WriteLine($"No such file: {filename}\nException {notfound.Message}");
            }
            catch (FormatException notint)
            {
                Console.WriteLine($"Number is not\nException {notint.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Unexpected end\nException {ex.Message}");
            }
        }
    }
}
