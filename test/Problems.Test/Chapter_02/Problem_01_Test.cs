using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_01_Test
    {
        private static readonly LinkedList<int> LIST_WITH_DUPLICATES = new LinkedList<int>
        (
            new int[] { 0, 0, 1, 1, 1, 2, 3, 4, 4 }
        );

        private static readonly LinkedList<int> LIST_WITHOUT_DUPLICATES = new LinkedList<int>
        (
            new int[] { 0, 1, 2, 3, 4}
        );

        [TestMethod]
        public void RemoveDup_ReturnsListWithDuplicatesRemoved()
        {
            Problem_01.RemoveDups(LIST_WITH_DUPLICATES);

            // Checking lists are equal.
            using (var e1 = LIST_WITH_DUPLICATES.GetEnumerator())
            using (var e2 = LIST_WITHOUT_DUPLICATES.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    if (!e1.Current.Equals(e2.Current))
                        Assert.Fail();
                }
            }
        }
    }
}