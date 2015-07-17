using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum()
        {
            Class1 class1=new Class1();
            int expectedValue = 6;
            int actualValue = class1.sum(3);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
