using NUnit.Framework;
using Problems;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestPrefix()
        {
            Program test = new Program();
            Assert.AreEqual("5,1:hello", test.Prefix("hello"));
        }

        [Test]
        public void TestPrefixBlank()
        {
            Program test = new Program();
            Assert.AreEqual("0,0:", test.Prefix(""));
        }

        [Test]
        public void TestPrefixLong()
        {
            Program test = new Program();
            Assert.AreEqual("27,5:what   ...   did you say?? ", test.Prefix("what   ...   did you say?? "));
        }
    }
}
