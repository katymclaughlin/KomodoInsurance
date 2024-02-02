using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoIns.Data;
using KomodoIns.Repository;

namespace KomodoIns.Tests
{
    [TestClass]
    public class DeveloperRepo_Tests
    {
        [TestMethod]
        public void Test_AddDeveloperToLis()
        {
            Developer myDev = new Developer("Cinderella", 1960, true);
            DeveloperRepo devDirectory = newDeveloperRepo();
            devDirectory.AddDeveloperToList(myDev);
            List<Developer> devList = devDirectory.GetDeveloperList();

            CollectionAssert.Contains(devList, "Cinderella");
            AssemblyTrademarkAttribute.AreEqual(1, devList.Count());
        }
    }
}