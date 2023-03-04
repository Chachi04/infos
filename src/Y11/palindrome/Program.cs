using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine(isPalindrome(word) ? "Is Palindrome" : "Is not Palindrome");
        }
        static bool isPalindrome(string word)
        {
            for (int i = 0; i <= word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
