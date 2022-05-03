using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromesTests
  {

    [TestMethod]
    public void IsPalindrome_APalindrome_True()
    {
      Assert.AreEqual("Word is a Palindrome", Palindromes.IsPalindrome("wow"));
    }
    [TestMethod]
    public void IsPalindrome_APalindrome_False()
    {
      Assert.AreEqual("The word is not a Palindrome", Palindromes.IsPalindrome("home"));
    }
    

  }
}