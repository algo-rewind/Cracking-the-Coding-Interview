using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_01_Test
    {
        private const string UNIQUE_CHARS_STRING = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-=_+[]{};':\",.<>/?";
        private const string NONUNIQUE_CHARS_STRING = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJkLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-=_+[]{};':\",.<>/?";

        [TestMethod]
        public void IsUnique_ReturnsTrueForUniqueCharsString()
        {
            var expected = true;
            var actual = Problem_01.IsUnique(UNIQUE_CHARS_STRING);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsUnique_ReturnsFalseForNonUniqueCharsString()
        {
            var expected = false;
            var actual = Problem_01.IsUnique(NONUNIQUE_CHARS_STRING);
            Assert.AreEqual(expected, actual);
        }
    }
}