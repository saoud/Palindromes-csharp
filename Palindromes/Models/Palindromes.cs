using System;
namespace Palindromes
{
  public class Palindrome
	{
        public bool IsPalindrome(string word)
        {
            char[] letterArr = word.ToCharArray();
            Array.Reverse(letterArr);
            string reversed = new string(letterArr);
            if (word == reversed)
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
