using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindNextBiggerNumberTest
{
    [TestClass]
    public class FindTest   
    {
        [TestMethod]
        
        public void NextBiggerNumberTest1()
        {
            int number = 3456432;
            int expected = 3462345;

            int actual = FindNextBiggerNumber.Find.FindNextBiggerNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumberTest2()
        {
            int number = 12;
            int expected = 21;

            int actual = FindNextBiggerNumber.Find.FindNextBiggerNumber(number);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void NextBiggerNumberTest3()
        {
            int number = 144;
            int expected = 414;

            int actual = FindNextBiggerNumber.Find.FindNextBiggerNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NextBiggerNumberTest4()
        {
            int number = 10;
            int expected = -1;

            int actual = FindNextBiggerNumber.Find.FindNextBiggerNumber(number);
            
            Assert.AreEqual(expected, actual);
        }
    }
}
