using System;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Palindrome palindromeChecker = new Palindrome();
      Console.WriteLine("I can check whether something is a palindrome. Type what you want to check:");
      string userInput = Console.ReadLine();
      bool inputChecked = palindromeChecker.IsPalindrome(userInput);
      if (inputChecked)
      {
        Console.WriteLine(userInput + " is a palindrome.");
      }
      else
      {
        Console.WriteLine(userInput + " is not a palindrome.");
      }
    }
  }
}