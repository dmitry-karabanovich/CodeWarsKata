using Kata._7_kyu_kata;
using Xunit;

namespace Kata.Test._7_kyu_kata
{
    public class Kata_7_2_Test
    {
        [Fact]
        public void RemoveOnlyNamesWithFourCharacters()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Assert.Equal(expected, Kata_7_2.FriendOrFoe(names));
        }
    }
}
