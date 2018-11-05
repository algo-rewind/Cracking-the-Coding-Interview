using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_04_Test
    {
        private static readonly LinkedList<int> LIST = new LinkedList<int>
        (
            new int[] { 3, 5, 8, 5, 10, 2, 1 }
        );

        private static readonly LinkedList<int> PARTITIONED_LIST = new LinkedList<int>
        (
            new int[] { 3, 2, 1, 5, 8, 5, 10 }
        );


        [TestMethod]
        public void Partition_CorrectlyPartitionsList()
        {
            int partition = 5;
            Problem_04.Partition(LIST, partition);

            using (var e1 = LIST.GetEnumerator())
            using (var e2 = PARTITIONED_LIST.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                    if (e1.Current != e2.Current)
                        Assert.Fail();
            }
        }
    }
}