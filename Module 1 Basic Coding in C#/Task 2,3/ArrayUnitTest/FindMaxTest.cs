using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EpamTasksTest

{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void FindMax_Negative_Exp0()
        {

            int[] arr = { -1, 0, 10, -2, -5, -4, -6, -8, -7 };
            int expected = 10;

            int actual = EpamTasks.Array.FindMax(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EqualSumIndex_Possitive_Exp8()
        {

            int[] arr = { 3,1,2,3,4,10,6,7 };
            int expected = 5;

            int actual = EpamTasks.Array.EqualSumIndex(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
