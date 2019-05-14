using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClassString
{
    [TestClass]
    public class SomeActionsTest
    {
        [TestMethod]
        public void Concatenation_string_fine()
        {
            //the text for the concatenation: madam, I am adam - the text for the concatenation
            //the text for the concatenation: madam I am madam I am adam - the text for the concatenation
            string Text1 = "the text for the concatenation: qwerty";
            string Text2 = "ytrewq- the text for the concatenation";
            string expected = "the text for the concatenation: qwerty- the text for the concatenation";

            string actual = ClassString.StringActions.concat(Text1, Text2);

            Assert.AreEqual(expected, actual);
        }
    }
}
