using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Models
{
  public class Scrabble
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word and we'll find its Scrabble value!");
      string userInputWord = Console.ReadLine();
      Scores player1 = new Scores(userInputWord);
      int returnedVal = player1.Add();
      Console.WriteLine("Your word is worth " + returnedVal + " points!");
    }
  }
}