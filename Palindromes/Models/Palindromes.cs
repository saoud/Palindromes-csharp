using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Palindromes
{
  public class Palindrome
	{
		
        public bool IsPalindrome(string stringToTest)
        {
            string lowerWords = stringToTest.ToLower();
            string cleanedString = RemoveSpecialCharacters(String.Concat(lowerWords.Where(c => !Char.IsWhiteSpace(c))));
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
	public static string RemoveSpecialCharacters(string input)
{
    Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
    return r.Replace(input, String.Empty);
}
	}
}