using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_09_Test
    {
        private static readonly string SOURCE = "WATERBOTTLE";
        private static readonly string CANDIDATE = "ERBOTTLEWAT";

        [TestMethod]
        public void StringRotation_ReturnsTrueForRotatedString()
        {
            var result = Problem_09.StringRotation(SOURCE, CANDIDATE);
            Assert.IsTrue(result);
        }
    }
}