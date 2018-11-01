using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_06_Test
    {
        private static readonly string UNCOMPRESSED_STRING = "AABCCCCCAAA";

        [TestMethod]
        public void StringCompression_ReturnsCompressedString()
        {
            var expected = "A2B1C5A3";
            var actual = Problem_06.StringCompression(UNCOMPRESSED_STRING);

            Assert.AreEqual(expected, actual);
        }
    }
}