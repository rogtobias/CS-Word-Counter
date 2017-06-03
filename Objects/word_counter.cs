using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userWord;
    private string _userSentence;
    private int _wordsCounted;

    //states what will be going into the class
    public RepeatCounter(string userWord, string userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
      _wordsCounted = 0;
    }

    //gets the inputted word from the user
    public string GetUserWord()
    {
      return _userWord;
    }

    //gets the inputted sentence from the user
    public string GetUserSentence()
    {
      return _userSentence;
    }

    //creates the counter method
    public int CountRepeats()
    {
      //
      //splits the sentence the user inputted into an array
      string[] splitSentence = _userSentence.ToLower().Split(' ');
      //Console.WriteLine(splitSentence.Length);
      //loops through the inputted sentence to find matches
      for (int i = 0; i < splitSentence.Length; i++)
      {
        //Console.WriteLine(splitSentence[i]);
        //checks the single word in the array to the single word the user inputted
        if (splitSentence[i] == _userWord.ToLower())
        {
          //adds 1 to the wordsCounted variable
          _wordsCounted += 1;
          Console.WriteLine(_wordsCounted);
        }
      }
      //returns the counted wordsCounted
      Console.WriteLine(_userWord);
      Console.WriteLine(_wordsCounted);
      return _wordsCounted;
    }
  }
}
