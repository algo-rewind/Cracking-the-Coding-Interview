using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_08_Test
    {
        [TestMethod]
        public void LoopDetection_ReturnsNodeAtStartOfLoop()
        {
            var nodes = new LinkedListNode<int>[]
            {
                new LinkedListNode<int>(0),
                new LinkedListNode<int>(1),
                new LinkedListNode<int>(2),
                new LinkedListNode<int>(3),
                new LinkedListNode<int>(4),
            };

            var list = new LinkedList<int>();
            list.Append(nodes[0]);
            list.Append(nodes[1]);
            list.Append(nodes[2]);
            list.Append(nodes[3]);
            list.Append(nodes[4]);
            list.Append(nodes[0]);

            var expected = nodes[0];
            var actual = Problem_08.LoopDetection(list);

            Assert.AreSame(expected, actual);
        }
    }
}