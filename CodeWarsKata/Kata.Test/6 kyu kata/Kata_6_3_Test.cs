using Kata._6_kyu_kata;
using Xunit;

namespace Kata.Test._6_kyu_kata
{
    public class Kata_6_3_Test
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal("no one likes this", Kata_6_3.Likes(new string[0]));
            Assert.Equal("Peter likes this", Kata_6_3.Likes(new string[] { "Peter" }));
            Assert.Equal("Jacob and Alex like this", Kata_6_3.Likes(new string[] { "Jacob", "Alex" }));
            Assert.Equal("Max, John and Mark like this", Kata_6_3.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.Equal("Alex, Jacob and 2 others like this", Kata_6_3.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
