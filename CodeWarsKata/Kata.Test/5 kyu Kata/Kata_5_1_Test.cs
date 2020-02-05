using Kata._5_kyu_Kata;
using Xunit;

namespace Kata.Test._5_kyu_Kata
{
    public class Kata_5_1_Test
    {
        [Fact]
        public void MaxSequenceIsZero()
        {
            Assert.Equal(0, Kata_5_1.MaxSequence(new int[0]));
        }

        [Fact]
        public void TeMaxSequenceIsSix()
        {
            Assert.Equal(6, Kata_5_1.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        [Fact]
        public void TeMaxSequenceIsSeven()
        {
            Assert.Equal(7, Kata_5_1.MaxSequence(new int[] { 2, -3, 3, 4, -5, 2}));
        }
    }
}
