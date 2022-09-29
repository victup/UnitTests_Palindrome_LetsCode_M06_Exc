using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Domain
{
    public class PalindromeService : IPalindromeService
    {
        public bool IsPalindrome(string word)
        {
            word = word.ToUpper().Replace(" ", "");

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word.Reverse().ToArray()[i]) return false;
            }
            return true;
        }
    }
}
