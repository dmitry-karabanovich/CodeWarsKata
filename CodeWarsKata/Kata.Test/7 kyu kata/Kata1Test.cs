using Kata._7_kyu_kata;
using Xunit;

namespace Kata.Test._7_kyu_kata
{
    public class Kata1Test
    {
        [Theory]
        [InlineData(3,5,7)]
        [InlineData(5,7,10)]
        [InlineData(2,5,6)]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue(int a, int b, int c)
        {
            Assert.True(Kata1.IsTriangle(a, b, c));
        }

        [Theory]
        [InlineData(3, 1, 7)]
        [InlineData(4, 1, 2)]
        [InlineData(3, 2, 1)]
        public void IsTriangle_ValidPostiveNumbers_ReturnsFalse(int a, int b, int c)
        {
            Assert.False(Kata1.IsTriangle(a, b, c));
        }

    }
}
