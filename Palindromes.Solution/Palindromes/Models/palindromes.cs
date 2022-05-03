using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindrome {
  public class Palindromes {
    public static void Main() {

    }

    public static string IsPalindrome(string word)
    {
      char[] array = word.ToCharArray();
      Array.Reverse(array);
      string newWord = new string(array);
      if (word == newWord) {
        return "Word is a Palindrome";
      }
      else {
        return "The word is not a Palindrome";
      }
    }
  }
}
