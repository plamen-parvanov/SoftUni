using System;
using System.Collections.Generic;

namespace _04.Palindromes
{
    public class Problem04
    {
        public static void Main()
        {
            var delimeter = " ,.?!".ToCharArray();
            var text = Console.ReadLine()
                .Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }                
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
