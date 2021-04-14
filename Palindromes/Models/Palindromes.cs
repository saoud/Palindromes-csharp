using System;
using System.Linq;

namespace Palindromes
{
  public class Palindrome
	{
        public bool IsPalindrome(string stringToTest)
        {
            string lowerWords = stringToTest.ToLower();
            string cleanedString = String.Concat(lowerWords.Where(c => !Char.IsWhiteSpace(c)));
            char[] cleanedStringArr = cleanedString.ToCharArray();
            Array.Reverse(cleanedStringArr);
            string reversed = new string(cleanedStringArr);
            if (cleanedString == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}