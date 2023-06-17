using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnet_flow;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_flow.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MinusTest()
        {
            Assert.AreEqual(15f / 3, dotnet_flow.Program.Minus(15, 3));
        }

        [TestMethod()]
        public void MinusTest2()
        {
            Assert.AreEqual(20f / 4, dotnet_flow.Program.Minus(20, 4));
        }

        [TestMethod()]
        public void MinusTest3()
        {
            Assert.AreEqual(20f / 3, dotnet_flow.Program.Minus(20, 3));
        }

        [TestMethod()]
        public void MinusTest4()
        {
            Assert.AreEqual(20f / 3, dotnet_flow.Program.Minus(20, 3));
        }

        [TestMethod()]
        public void MinusTest5()
        {
            Assert.AreEqual(21f / 7, dotnet_flow.Program.Minus(21, 7));
        }

        [TestMethod()]
        public void MinusTest6()
        {
            Assert.AreEqual(21f / 7, dotnet_flow.Program.Minus(21, 7));
        }
    }
}