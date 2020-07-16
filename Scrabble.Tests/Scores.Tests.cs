using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoresTest
  {
    [TestMethod]
    public void ScoresDictionary_ReturnsKeyValuePairs_Scores()
    {
      Dictionary<string, int> ScrabbleScore = new Dictionary<string, int>() {{"a", 1}, {"b", 3}, {"c", 3}, {"d", 3}, {"e", 1}, {"f", 4}, {"g", 2}};
      Assert.AreEqual(1, ScrabbleScore["a"]);
    }
    [TestMethod]
    public void ScoresDictionary_AddsKeyValuePairs_Scores()
    {
      Dictionary<string, int> ScrabbleScore = new Dictionary<string, int>() {{"a", 1}, {"b", 3}, {"c", 3}, {"d", 3}, {"e", 1}, {"f", 4}, {"g", 2}};
      Assert.AreEqual(4, ScrabbleScore["a"] + ScrabbleScore["b"]);
    }
    [TestMethod]
    public void ScoresDictionary_AddressIndexValueOfString_Scores()
    {
      string UserInput = "cab";
      Assert.AreEqual('c', UserInput[0]);
    }
    [TestMethod]
    public void ScoresDictionary_AddsKeyValuePairsFromUserInputString_Scores()
    {
      Dictionary<char, int> ScrabbleScore = new Dictionary<char, int>() {{'a', 1}, {'b', 3}, {'c', 3}, {'d', 3}, {'e', 1}, {'f', 4}, {'g', 2}};
      string UserInput = "cab";
      int count = 0;
      for (int index = 0; index < UserInput.Length; index++)
      {
        Console.WriteLine(ScrabbleScore[UserInput[index]]);
        count += ScrabbleScore[UserInput[index]];
      }
      Assert.AreEqual(7, count);
    }
  }
}