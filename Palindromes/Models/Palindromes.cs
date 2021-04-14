using System;
namespace Palindromes
{
  public class Palindrome
	{
        public bool IsPalindrome(string word)
        {
            string lowerWord = word.ToLower();
            char[] letterArr = lowerWord.ToCharArray();
            Array.Reverse(letterArr);
            string reversed = new string(letterArr);
            if (lowerWord == reversed)
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
