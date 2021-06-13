using FirstMissingPositiveDomain.Models;
using Xunit;

namespace FirstMissingPositiveTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void GetFirstMissingPositive_Should_Return_Correct_Positive_Number()
        {
            var numbers = new []{3, 4, -1, 1};
            const int ExpectedResult = 2;

            int result = SuperInteger.GetFirstMissingPositive(numbers);

            Assert.Equal(result, ExpectedResult);
        }
    }
}