using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

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
	}
}