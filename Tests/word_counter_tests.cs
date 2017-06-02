using Xunit;
using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class WordCounterTests
  {
    [Fact]
    public void WordCount_NoMatches_0()
    {
      //arrange
      string testSingleWord = "sun";
      string testSentence = "See Spot run.";

      //act
      RepeatCounter newRepeatCounter = new RepeatCounter(testSingleWord, testSentence);

      //assert
      Assert.Equal(0, newRepeatCounter.CountRepeats());
    }

    [Fact]
    public void WordCount_Matches_2()
    {
      //arrange
      string testSingleWord = "day";
      string testSentence = "The day was sunny, but the day wasn't bright.";

      //act
      RepeatCounter newRepeatCounter = new RepeatCounter(testSingleWord, testSentence);

      //assert
      Assert.Equal(2, newRepeatCounter.CountRepeats());
    }
  }
}
