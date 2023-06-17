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
    }
}