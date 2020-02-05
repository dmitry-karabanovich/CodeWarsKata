using Kata._6_kyu_kata;
using Xunit;

namespace Kata.Test._6_kyu_kata
{
    public class Kata_6_2_Test
    {
        [Fact]
        public void RightDecideIfRoadIsValid()
        {
            Assert.True(Kata_6_2.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Assert.False(Kata_6_2.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            Assert.False(Kata_6_2.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.False(Kata_6_2.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }

    }
}
