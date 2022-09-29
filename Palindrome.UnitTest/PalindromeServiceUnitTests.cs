using FluentAssertions;
using Palindrome.Domain;

namespace Palindrome.UnitTest
{
    public class PalindromeServiceUnitTests
    {
        // public void Greeting_IsPalindromo_ReturnTrue()
        [Theory]
        [InlineData("ovo")]
        public void  IsPalindrome_WhenPalindrome_ShouldReturnTrue(string word)
        {
            PalindromeService sut = new PalindromeService();

            var actual = sut.IsPalindrome(word);

            Assert.True(actual);

        }

        [Theory]
        [InlineData("Roma")]
        public void IsPalindrome_WhenPalindrome_ShouldReturnFalse(string word)
        {
            PalindromeService sut = new PalindromeService();

            var actual = sut.IsPalindrome(word);

            actual.Should().BeFalse();

        }
    }
}