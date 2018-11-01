using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_03_Test
    {
        [TestMethod]
        public void CheckPermutation_ReturnsTrueForPermutatedStrings()
        {
            char[] source = "Mr John Smith".ToCharArray();

            char[] expected = "Mr%20John%20Smith".ToCharArray();
            char[] actual = Problem_03.URLify(source);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}