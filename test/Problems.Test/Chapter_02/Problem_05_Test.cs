using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_05_Test
    {
        private static readonly LinkedList<int> AUGEND = new LinkedList<int>
        (
            new int[] { 7, 1, 6, 2 }
        );

        private static readonly LinkedList<int> ADDEND = new LinkedList<int>
        (
            new int[] { 5, 9, 9 }
        );

        private static readonly LinkedList<int> SUM = new LinkedList<int>
        (
            new int[] { 2, 1, 6, 3 }
        );

        [TestMethod]
        public void SumLists_ReturnsSumList()
        {
            var result = Problem_05.SumLists(AUGEND, ADDEND);

            using (var e1 = result.GetEnumerator())
            using (var e2 = SUM.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                    if (e1.Current != e2.Current)
                        Assert.Fail();
            }
        }
    }
}