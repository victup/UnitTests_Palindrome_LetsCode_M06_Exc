﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Domain
{
    public interface IPalindromeService
    {
        public bool IsPalindrome(string word);
    }
}
