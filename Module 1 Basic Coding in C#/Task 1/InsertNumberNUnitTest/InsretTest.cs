using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        
        public void InsertNumbers_8and15and3and8_120()
        {

            int a = 8;
            int b = 15;
            int i = 3;
            int j = 8;
            int expected = 120;


            int actual = InsertNumber.Insert.InsertNumbers(a, b, i, j);

            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void InsertNumbers_15and15and0and0_15()
        {

            int a = 15;
            int b = 15;
            int i = 0;
            int j = 0;
            int expected = 15;


            int actual = InsertNumber.Insert.InsertNumbers(a, b, i, j);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InsertNumbers_8and15and0and0_120()
        {

            int a = 8;
            int b = 15;
            int i = 0;
            int j = 0;
            int expected = 9;


            int actual = InsertNumber.Insert.InsertNumbers(a, b, i, j);

            Assert.AreEqual(expected, actual);

        }
    }
}