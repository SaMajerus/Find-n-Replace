using System;

/*     Business Logic     */ 
namespace Replace.Models
{
  public class FindReplace
  {
    public string Input { get; set; }
    public string Replace { get; set; }
    public string Replacement { get; set; }

    public FindReplace(string input, string replace, string replacement)
    {
      Input = input;
      Replace = replace;
      Replacement = replacement;
    }

    public string FindAndReplace()
    {
      string sentence = Input;
      var replacement = sentence.Replace(Replace, Replacement);
      // string[] words = Input.Split(' '); 
      // foreach (string word in words)
      // {
      //   if (word == Replace)
      //   {
      //     word = Replacement;
      //   }
      // }
      // string revisedSentence = new string(words);
      // return revisedSentence;
      return replacement;
    }
  }
}