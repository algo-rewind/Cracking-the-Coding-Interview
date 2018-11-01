using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_07_Test
    {
        private static readonly int[,] MATRIX =
        {
          { 1, 2, 3 },
          { 4, 5, 6 },
          { 7, 8, 9 }
        };

        private static readonly int[,] ROTATED_MATRIX = 
        {
          { 3, 6, 9 },
          { 2, 5, 8 },
          { 1, 4, 7 }
        };

        [TestMethod]
        public void RotateMatrix_ReturnsRotatedMatrix()
        {
            Problem_07.RotateMatrix(MATRIX);
            CollectionAssert.AreEqual(ROTATED_MATRIX, MATRIX);
        }
    }
}