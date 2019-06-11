using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab12.Tests
{
    [TestClass]
    public class StudentServiceTest
    {
        [TestMethod]
        public void CheckUserAndPasswordTest()
        {
            StudentService ss = new StudentService();
          bool b= ss.CheckUserAndPassword("zzzzz", "zzzzz");
            Assert.AreEqual(false, b);
        }
    }
}
