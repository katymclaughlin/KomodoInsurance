using System.Reflection.Metadata;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoIns.Data;

namespace KomodoIns.Tests
{
    [TestClass]
    public class Developer_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Developer myDev = new Developer();
            myDev.Name = "Pac Man";
            //myDev.Id = 1;
            myDev.HasPluralsight = false;

            Assert.IsFalse(myDev.HasPluralsight);
            Assert.AreEqual(1, myDev.Id);
            Assert.AreEqual("Pac Man", myDev.Name);

        }
    }
}