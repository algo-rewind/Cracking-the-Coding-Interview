using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_07_Test
    {
        private static readonly LinkedList<int>[] INTERSECTING_LISTS = new LinkedList<int>[2]
        {
            new LinkedList<int>(),
            new LinkedList<int>()
        };

        private static readonly LinkedList<int>[] NON_INTERSECTING_LISTS = new LinkedList<int>[2]
        {
            new LinkedList<int>(),
            new LinkedList<int>()
        };

        [TestMethod]
        public void Intersection_ReturnsTrueWhenTheTwoListIntersect()
        {
            var nodes = new LinkedListNode<int>[]
            {
                new LinkedListNode<int>(0),
                new LinkedListNode<int>(1),
                new LinkedListNode<int>(2),

                new LinkedListNode<int>(3),
                // Will use LinkedListNode<int>(1)
                new LinkedListNode<int>(4),
            };

            // First list.
            INTERSECTING_LISTS[0].Append(nodes[0]);
            INTERSECTING_LISTS[0].Append(nodes[1]);
            INTERSECTING_LISTS[0].Append(nodes[2]);

            // Second list.
            INTERSECTING_LISTS[1].Append(nodes[3]);
            INTERSECTING_LISTS[1].Append(nodes[1]);
            INTERSECTING_LISTS[1].Append(nodes[4]);

            bool result = Problem_07.Intersection(INTERSECTING_LISTS[0], INTERSECTING_LISTS[1]);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Intersection_ReturnsFalseWhenTheTwoListDontIntersect()
        {
            var nodes = new LinkedListNode<int>[]
            {
                new LinkedListNode<int>(0),
                new LinkedListNode<int>(1),
                new LinkedListNode<int>(2),

                new LinkedListNode<int>(3),
                new LinkedListNode<int>(4),
                new LinkedListNode<int>(5),
            };

            // First list.
            INTERSECTING_LISTS[0].Append(nodes[0]);
            INTERSECTING_LISTS[0].Append(nodes[1]);
            INTERSECTING_LISTS[0].Append(nodes[2]);

            // Second list.
            INTERSECTING_LISTS[1].Append(nodes[3]);
            INTERSECTING_LISTS[1].Append(nodes[4]);
            INTERSECTING_LISTS[1].Append(nodes[5]);

            bool result = Problem_07.Intersection(NON_INTERSECTING_LISTS[0], NON_INTERSECTING_LISTS[1]);
            Assert.IsFalse(result);
        }
    }
}