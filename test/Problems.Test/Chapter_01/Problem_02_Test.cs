using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_02_Test
    {
        private static readonly string[] PERMUTATIONS = {"ABCD", "CDAB"};
        private static readonly string[] NON_PERMUTATIONS = {"ABCD", "CDAE"};

        [TestMethod]
        public void CheckPermutation_ReturnsTrueForPermutatedStrings()
        {
            var result = Problem_02.CheckPermutation(PERMUTATIONS[0], PERMUTATIONS[1]);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPermutation_ReturnsFalseForNonPermutatedStrings()
        {
            var result = Problem_02.CheckPermutation(NON_PERMUTATIONS[0], NON_PERMUTATIONS[1]);
            Assert.IsFalse(result);
        }
    }
}