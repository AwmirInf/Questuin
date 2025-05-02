using _9._Palindrome_Number;

namespace PalindromeNumber_Test
{
    public class Test
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)] 
        [InlineData(10, false)]
        [InlineData(0, true)]
        [InlineData(12321, true)]
        [InlineData(123321, true)]
        [InlineData(12345, false)]
        public void IsPalindrome_ShouldReturnExpectedResult(int input, bool expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            bool result = solution.IsPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
