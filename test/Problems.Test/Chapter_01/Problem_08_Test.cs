using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Chapter_01;

namespace Problems.Test.Chapter_01
{
    [TestClass, TestCategory("Chapter_01")]
    public class Problem_08_Test
    {
        private static readonly int[,] MATRIX =
        {
            { 01, 02, 03, 04, 05 },
            { 06, 00, 08, 09, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 00, 20 },
            { 00, 22, 23, 24, 25 }
        };

        private static readonly int[,] ZEROED_MATRIX =
        {
            { 00, 00, 03, 00, 05 },
            { 00, 00, 00, 00, 00 },
            { 00, 00, 13, 00, 15 },
            { 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00 }
        };

        [TestMethod]
        public void ZeroMatrix_ReturnsZeroedMatrix()
        {
            Problem_08.ZeroMatrix(MATRIX);
            CollectionAssert.AreEqual(ZEROED_MATRIX, MATRIX);
        }
    }
}