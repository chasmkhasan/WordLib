

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
        public void IsPalindrome_WhenStringIsPalindrome_ReturnTrue()
        {
            var result = palindrome.IsPalindrome("dad");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsPalindrome_WhenStringIsNotPalindrome_ReturnFalse()
        {
            var result = palindrome.IsPalindrome("father");

            Assert.AreEqual(false, result);
        }

        //Need to connect with Data!
        //[DataTestMethod]
        //[DataRow(null)]
        //[DataRow("")]
        //[ExpectedException(typeof(ArgumentException))]
        //public void IsPalindrome_WhenPassedValueIsNullOrEmpty_ThrowArgumentException(string parameter)
        //{
        //    var result = palindrome.IsPalindrome(parameter);

        //}
    }
}