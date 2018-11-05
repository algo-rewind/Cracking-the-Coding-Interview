using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_06_Test
    {
        private static readonly LinkedList<int> VALID_PALINDROME = new LinkedList<int>
        (
            new int[] { 1, 2, 3, 4, 3, 2, 1 }
        );

        private static readonly LinkedList<int> INVALID_PALINDROME = new LinkedList<int>
        (
            new int[] { 1, 2, 3, 4, 2, 1 }
        );


        [TestMethod]
        public void Palindrome_ReturnsTrueWhenLinkedListIsPalindrome()
        {
            bool result = Problem_06.Palindrome(VALID_PALINDROME);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Palindrome_ReturnsFalseWhenLinkedListIsNotPalindrome()
        {
            bool result = Problem_06.Palindrome(INVALID_PALINDROME);
            Assert.IsFalse(result);
        }
    }
}