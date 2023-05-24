
namespace Palindrome.Logic
{
    [TestClass]
    public class PalindromeTests
    {
        Palindrome palindrome;

        [TestInitialize]
        public void SetUp()
        {
            palindrome = new Palindrome();
        }

        [TestMethod]
        public void IsPalindrome_WhenWhenStringIsPalindrome_ReturnsTrue()
        {
            var result = palindrome.IsPalindrome("dad");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsPalindrome_WhenWhenStringIsNotPalindrome_ReturnsFalse()
        {
            var result = palindrome.IsPalindrome("father");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [ExpectedException(typeof(ArgumentException))]
        public void IsPalindrome_WhenPassedNullOrEmptyValue_ThrowsArgumentException(string text)
        {
            var result = palindrome.IsPalindrome(text);
        }
    }
}