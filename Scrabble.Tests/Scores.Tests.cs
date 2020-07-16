using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;

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
    // Test methods will go here.

  }
}