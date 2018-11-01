using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_05_Test
    {
        private static readonly string[] ONE_EDIT_AWAY_STRINGS = { "PALE", "PLE" };
        private static readonly string[] TWO_EDITS_AWAY_STRINGS = { "PALE", "BAKE" };

        [TestMethod]
        public void OneAway_ReturnsTrueForStringsThatAreOneEditAway()
        {
            var result = Problem_05.OneAway(ONE_EDIT_AWAY_STRINGS[0], ONE_EDIT_AWAY_STRINGS[1]);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OneAway_ReturnsFalseForStringsThatAreTwoEditsAway()
        {
            var result = Problem_05.OneAway(TWO_EDITS_AWAY_STRINGS[0], TWO_EDITS_AWAY_STRINGS[1]);
            Assert.IsFalse(result);
        }
    }
}