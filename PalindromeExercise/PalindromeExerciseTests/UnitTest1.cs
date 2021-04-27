using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("anna", true)]
        [InlineData("jeff", false)]
        [InlineData("radar", true)]
        [InlineData("kayak", true)]
        [InlineData("penny", false)]
        public void Test1(string input, bool expected)
        {
            //arrange
            var t = new WordSmith();

            //act
            var actual = t.IsAPalindrome(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
