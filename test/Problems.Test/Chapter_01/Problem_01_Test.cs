using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_01_Test
    {
        private static readonly string UNIQUE_CHARS_STRING = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-=_+[]{};':\",.<>/?";
        private static readonly string NON_UNIQUE_CHARS_STRING = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJkLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-=_+[]{};':\",.<>/?";

        [TestMethod]
        public void IsUnique_ReturnsTrueForUniqueCharsString()
        {
            var result = Problem_01.IsUnique(UNIQUE_CHARS_STRING);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUnique_ReturnsFalseForNonUniqueCharsString()
        {
            var result = Problem_01.IsUnique(NON_UNIQUE_CHARS_STRING);
            Assert.IsFalse(result);
        }
    }
}