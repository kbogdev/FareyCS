using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FareyNumbers nums = new FareyNumbers(1);
            Assert.IsTrue(nums.Count == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            FareyNumbers nums = new FareyNumbers(2);
            Assert.IsTrue(nums.Count == 3);
        }
    }
}
