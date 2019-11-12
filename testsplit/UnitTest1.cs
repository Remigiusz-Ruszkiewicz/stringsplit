using NUnit.Framework;
using System.Collections;
using stringsplit;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Ala","Ala")]
        [TestCase("Ala ma kota", "kota ma Ala")]
        public void ReverseTest(string text,string expected)
        {
            var reverse = new Reverser();
            string result = reverse.Reverse(text);
            StringAssert.AreEqualIgnoringCase(result, expected);
        }
    }
}