using AirconLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FanOutputTests
{
    [TestClass]
    public class FanOutputPropertyTests
    {
        private FanOutput _testOutput;

        [TestInitialize]
        public void BeforeTest()
        {
            _testOutput = new FanOutput(1, "Bjarne", 16, 35);
        }

        [TestMethod]
        public void TestId()
        {
            Assert.AreEqual(1, _testOutput.Id);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Bjarne", _testOutput.Name);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNameLimit()
        {
            _testOutput.Name = "b";
        }

        [TestMethod]
        public void TestTemp()
        {
            Assert.AreEqual(16, _testOutput.Temp);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTempConstrictions()
        {
            _testOutput.Temp = 14;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTempConstrictionsTwo()
        {
            _testOutput.Temp = 26;
        }

        [TestMethod]
        public void TestHumidity()
        {
            Assert.AreEqual(35, _testOutput.Humidity);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHumidityConstrictions()
        {
            _testOutput.Humidity = 29;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHumidityConstrictionsTwo()
        {
            _testOutput.Humidity = 81;
        }


    }
}
