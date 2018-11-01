using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_04_Test
    {
        private static readonly string VALID_PALINDROME_PERMUTATION = "TACTCOA";
        private static readonly string INVALID_PALINDROME_PERMUTATION = "HANNAA";

        [TestMethod]
        public void PalindromePermutation_ReturnsTrueForValidPalindromePermutation()
        {
            var result = Problem_04.PalindromePermutation(VALID_PALINDROME_PERMUTATION);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PalindromePermutation_ReturnsFalseForInvalidPalindromePermutation()
        {
            var result = Problem_04.PalindromePermutation(INVALID_PALINDROME_PERMUTATION);
            Assert.IsFalse(result);
        }
    }
}