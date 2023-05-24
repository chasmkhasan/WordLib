using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Logic
{
    public class Palindrome
    {
        public bool IsPalindrome(string text)
        {
            if(string.IsNullOrEmpty(text))
                throw new ArgumentNullException("Cannot pass empty or null values");

            string newText = string.Empty;

            for (int i = text.Length; i > 0; i--)
            {
                newText += text.Substring(i);
            }

            return (text == newText) ? true : false;
        }
    }
}