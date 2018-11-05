using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_03_Test
    {
        private static readonly LinkedList<int> LIST = new LinkedList<int>();
        private static readonly LinkedListNode<int>[] NODES = new LinkedListNode<int>[4]
        {
            new LinkedListNode<int>(0),
            new LinkedListNode<int>(1),
            new LinkedListNode<int>(2),
            new LinkedListNode<int>(3)
        };

        private static readonly LinkedList<int> MODIFIED_LIST = new LinkedList<int>
        (
            new int[] { 0, 2, 3 }
        );

        [TestInitialize]
        public void Setup()
        {
            for (int i = 0; i < 4; i++)
                LIST.Append(NODES[i]);
        }

        [TestMethod]
        public void DeleteMiddleNode_DeletesANodeInTheMiddle()
        {
            Problem_03.DeleteMiddleNode(NODES[1]);

            // Checking lists are equal.
            using (var e1 = LIST.GetEnumerator())
            using (var e2 = MODIFIED_LIST.GetEnumerator())
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