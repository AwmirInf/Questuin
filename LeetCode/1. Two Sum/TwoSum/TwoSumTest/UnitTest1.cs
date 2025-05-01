using Xunit;

namespace TwoSumTests
{
    public class TwoSumUnitTests
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void BasicCase()
        {
            int[] result = _solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void DuplicateNumbers()
        {
            int[] result = _solution.TwoSum(new[] { 3, 3 }, 6);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void NegativeNumbers()
        {
            int[] result = _solution.TwoSum(new[] { -1, -2, -3, -4, -5 }, -8);
            Assert.Contains(2, result);
            Assert.Contains(4, result);
        }

        [Fact]
        public void Zeroes()
        {
            int[] result = _solution.TwoSum(new[] { 0, 4, 3, 0 }, 0);
            Assert.Contains(0, result);
            Assert.Contains(3, result);
        }

        [Fact]
        public void LargeNumbers()
        {
            int[] result = _solution.TwoSum(new[] { 1000000000, 3, 1000000000 }, 2000000000);
            Assert.Contains(0, result);
            Assert.Contains(2, result);
        }

        [Fact]
        public void OnlyTwoElements()
        {
            int[] result = _solution.TwoSum(new[] { 1, 2 }, 3);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void UnorderedMatch()
        {
            int[] input = { 4, 2, 1, 3 };
            int[] result = _solution.TwoSum(input, 5);
            Assert.Equal(5, input[result[0]] + input[result[1]]);

            Assert.NotEqual(result[0], result[1]);
        }
    }
}
