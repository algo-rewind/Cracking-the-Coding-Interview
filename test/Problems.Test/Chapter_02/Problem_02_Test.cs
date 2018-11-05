using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_02;
using Utilities.Collections;

namespace Problems.Test.Chapter_02
{
    [TestClass, TestCategory("Chapter_02")]
    public class Problem_02_Test
    {
        private static readonly LinkedList<int> LIST = new LinkedList<int>
        (
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
        );
        
        [TestMethod]
        public void ReturnKthToLast_ReturnsKthToLastElement()
        {
            for (int i = 1; i <= LIST.Length; i++)
            {
                int expected = LIST.Length - i + 1;
                int actual = Problem_02.ReturnKthToLast(LIST, i);

                if (expected != actual)
                    Assert.Fail();
            }
        }
    }
}