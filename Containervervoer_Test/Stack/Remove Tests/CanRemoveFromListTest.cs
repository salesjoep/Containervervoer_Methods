using Containervervoer_Methods.Models;
using Containervervoer_Test.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.Stack.Remove_Tests
{
    [TestClass]
    public class CanRemoveFromListTest
    {
        //Arrange
        Container container;
        bool trueValue = true;
        bool falseValue = false;

        //Act
        [TestMethod]
        public void RemoveContainer()
        {
            MockStacks.PopulateStack();
            container = MockStacks.testStacks[0].containerList[0];            
            var removed = MockStacks.testStacks[0].RemoveContainer(container);

            //Assert
            Assert.AreEqual(trueValue, removed);
        }

        [TestMethod]
        public void RemoveContainer2()
        {
            var removed = MockStacks.testStacks[0].RemoveContainer(container);

            //Assert
            Assert.AreEqual(falseValue, removed);
        }

        [TestMethod]
        public void RemoveContainer3()
        {
            MockStacks.PopulateStack1();
            container = MockStacks.testStacks[1].containerList[0];
            var removed = MockStacks.testStacks[1].RemoveContainer(container);

            //Assert
            Assert.AreEqual(trueValue, removed);
        }
    }
}
