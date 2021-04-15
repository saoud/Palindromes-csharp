using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass] 
	public class PalindromeTests
	{
    [TestMethod]
        public void IsPalindrome_WordSpelledSameBackwardsAndForward_True()
        {
            Palindrome testPalindrome = new Palindrome();
            Assert.AreEqual(true, testPalindrome.IsPalindrome("bob"));
        }
    [TestMethod]
        public void IsPalindrome_WordNotSpelledSameBackwardsAndForwards_False()
        {
            Palindrome testPalindrome = new Palindrome();
            Assert.AreEqual(false, testPalindrome.IsPalindrome("joe"));
    }
    [TestMethod]
        public void IsPalindrome_WordSpelledSameBackwardsAndForwardsWithDifferentCases_True()
        {
            Palindrome testPalindrome = new Palindrome();
            Assert.AreEqual(true, testPalindrome.IsPalindrome("Bob"));
        }
    [TestMethod]
        public void IsPalindrome_SentaceSpelledSameBackwardsAndForwards_True()
        {
            Palindrome testPalindrome = new Palindrome();
            Assert.AreEqual(true, testPalindrome.IsPalindrome("Taco cat"));
        }
    [TestMethod]
        public void IsPalindrome_PalindromeContainingNumericalCharacters_True()
        {
            Palindrome testPalindrome = new Palindrome();
            Assert.AreEqual(true, testPalindrome.IsPalindrome("101"));
        }
    [TestMethod]
		public void IsPalindrome_PalindromeContainingSpecialCharacters_True()
        {
            Palindrome testPalindrome = new Palindrome();
            Assert.AreEqual(true, testPalindrome.IsPalindrome("Borrow or rob?"));
        }
	}
}