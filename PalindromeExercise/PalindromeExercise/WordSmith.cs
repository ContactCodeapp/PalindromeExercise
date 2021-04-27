using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string input)
        {
            char[] arry = input.ToCharArray();
            Array.Reverse(arry);
            var flip = new string(arry);

            return (input == flip);

        }
    }
}
