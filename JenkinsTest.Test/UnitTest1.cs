using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            int expected = 7;
            int actual;
            actual=class1.sum(3);
            Assert.AreEqual(expected, actual);
        }
    }
}
