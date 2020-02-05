using Kata._6_kyu_kata;
using Xunit;

namespace Kata.Test._6_kyu_kata
{
    public class Kata_6_1_Test
    {
        [Fact]
        public void ExactlyFoundMissingCharacter()
        {
            Assert.Equal('e', Kata_6_1.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.Equal('P', Kata_6_1.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }

    }
}
