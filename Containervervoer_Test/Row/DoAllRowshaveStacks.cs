using Containervervoer_Methods.Models;
using Containervervoer_Test.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.Row
{
    [TestClass]
    public class DoAllRowshaveStacks
    {
        Containervervoer_Methods.Models.Row rowTest;
        List<Container> containerListTest = new List<Container>();

        [TestMethod]
        public void DoAllRowsHaveStacksTest1()
        {
            rowTest = MockRows.testRows.Last();

            containerListTest.Add(MockContainers.testContainers[0]);
            containerListTest.Add(MockContainers.testContainers[9]);
            containerListTest.Add(MockContainers.testContainers[10]);
            containerListTest.Add(MockContainers.testContainers[11]);

            foreach (var container in containerListTest)
            {
                rowTest.CanAddContainer(container);
            }

            Assert.AreEqual(2, rowTest.stackList.Count);
        }

        [TestMethod]
        public void DoAllRowsHaveStacksTest2()
        {
            rowTest = MockRows.testRows.Last();

            containerListTest.Add(MockContainers.testContainers[0]);
            containerListTest.Add(MockContainers.testContainers[9]);
            containerListTest.Add(MockContainers.testContainers[10]);
            containerListTest.Add(MockContainers.testContainers[11]);
            containerListTest.Add(MockContainers.testContainers[0]);
            containerListTest.Add(MockContainers.testContainers[11]);

            foreach (var container in containerListTest)
            {
                rowTest.CanAddContainer(container);
            }

            Assert.AreEqual(3, rowTest.stackList.Count);
        }
        [TestMethod]
        public void DoAllRowsHaveStacksTest3()
        {
            rowTest = MockRows.testRows[10];

            containerListTest.Add(MockContainers.testContainers[6]);
            containerListTest.Add(MockContainers.testContainers[7]);
            containerListTest.Add(MockContainers.testContainers[8]);
            containerListTest.Add(MockContainers.testContainers[6]);
            containerListTest.Add(MockContainers.testContainers[7]);

            foreach (var container in containerListTest)
            {
                rowTest.CanAddContainer(container);
            }

            Assert.AreEqual(5, rowTest.stackList.Count);
        }
    }
}
