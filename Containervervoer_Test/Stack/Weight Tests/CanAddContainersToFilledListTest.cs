using Containervervoer_Test.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.Weight_Tests
{
    [TestClass]
    public class CanAddContainersToFilledListTest
    {
        //Arrange
        bool trueValue = true;
        bool falseValue = false;
        [TestMethod]
        public void CanAddNormalContainerToStack()
        {
            MockStacks.PopulateStack();
            bool actualValue = MockStacks.testStacks[0].CanAddContainerToStack(MockContainers.testContainers[9]);

            Assert.AreEqual(falseValue, actualValue);
            
        }

        [TestMethod]
        public void CanAddNormalContainerToStack1()
        {
            MockStacks.PopulateStack1();
            bool actualValue = MockStacks.testStacks[1].CanAddContainerToStack(MockContainers.testContainers[9]);

            Assert.AreEqual(falseValue, actualValue);

        }

        [TestMethod]
        public void CanAddNormalContainerToStack2()
        {
            MockStacks.PopulateStack2();
            bool actualValue = MockStacks.testStacks[2].CanAddContainerToStack(MockContainers.testContainers[10]);

            Assert.AreEqual(trueValue, actualValue);

        }

        [TestMethod]
        public void CanAddValuableContainerToStack()
        {
            MockStacks.PopulateStack3();
            bool actualValue = MockStacks.testStacks[3].CanAddContainerToStack(MockContainers.testContainers[8]);

            Assert.AreEqual(falseValue, actualValue);

        }

        [TestMethod]
        public void CanAddValuableContainerToStack2()
        {
            MockStacks.PopulateStack4();
            bool actualValue = MockStacks.testStacks[4].CanAddContainerToStack(MockContainers.testContainers[6]);

            Assert.AreEqual(falseValue, actualValue);

        }

        [TestMethod]
        public void CanAddValuableContainerToStack3()
        {
            MockStacks.PopulateStack5();
            bool actualValue = MockStacks.testStacks[5].CanAddContainerToStack(MockContainers.testContainers[8]);

            Assert.AreEqual(trueValue, actualValue);

        }

        [TestMethod]
        public void CanAddCooledContainerToStack()
        {
            MockStacks.PopulateStack6();
            bool actualValue = MockStacks.testStacks[6].CanAddContainerToStack(MockContainers.testContainers[5]);

            Assert.AreEqual(trueValue, actualValue);

        }

        [TestMethod]
        public void CanAddCooledContainerToStack2()
        {
            MockStacks.PopulateStack7();
            bool actualValue = MockStacks.testStacks[7].CanAddContainerToStack(MockContainers.testContainers[5]);

            Assert.AreEqual(trueValue, actualValue);

        }

        [TestMethod]
        public void CanAddCooledContainerToStack3()
        {
            MockStacks.PopulateStack8();
            bool actualValue = MockStacks.testStacks[8].CanAddContainerToStack(MockContainers.testContainers[3]);

            Assert.AreEqual(falseValue, actualValue);

        }
    }
}
