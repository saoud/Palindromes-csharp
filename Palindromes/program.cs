using System;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
      {    
        Palindrome palindromeChecker = new Palindrome();
        Console.WriteLine("I can check whether something is a palindrome. Type what you want to check: ");
        string userInput = Console.ReadLine();
        bool inputChecked = palindromeChecker.IsPalindrome(userInput);
        if (inputChecked)
        {
          Console.WriteLine(userInput + " is a palindrome.");
          Continue();
        }
        else
        {
          Console.WriteLine(userInput + " is not a palindrome.");
          Continue();
        }
      }
    public static void Continue()
    {
      Console.Write("Would you like to check a different input? Type [y] if yes, [n] if you would like to exit: ");
      string userContinue = Console.ReadLine();
      if (userContinue == "y" || userContinue == "Y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye.");
      }
    }
  }
}