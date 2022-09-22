using System;
using System.Collections.Generic;
using Replace.Models;

/*     UI Logic     */ 
namespace Replace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Find 'N Replace");
      Console.WriteLine("Enter any sentence: ");
      string inputSentence = Console.ReadLine();
      Console.WriteLine("Enter the word in your sentence you would like to replace: ");
      string inputReplace = Console.ReadLine();
      Console.WriteLine("Finally, enter the word you would like to replace it with: ");
      string inputReplacement = Console.ReadLine();
      FindReplace letsReplace = new FindReplace(inputSentence, inputReplace, inputReplacement);
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Here is your new sentence: " + letsReplace.FindAndReplace());
    } 
  }
}