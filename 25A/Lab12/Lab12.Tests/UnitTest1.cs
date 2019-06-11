using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab12;
namespace Lab12.Tests
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void CheckEmailTest()
        {
            Helper h = new Helper();
            bool b = h.CheckEmail("abctest.com");
            Assert.AreEqual(false, b);
        }
    }
}
