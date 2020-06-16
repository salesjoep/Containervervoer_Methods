using Containervervoer_Methods.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test
{
    [TestClass]
    public class CanAddContainersToEmptyListTest
    {
        //Arrange
        Containervervoer_Methods.Models.Stack stack = new Containervervoer_Methods.Models.Stack();        
        bool trueValue = true;
        bool falseValue = false;
        
        //Act
        [TestMethod]
        //NORMAL CONTAINERS
        public void CanAddNormalContainerToStack()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[0]);
            
            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //NORMAL CONTAINERS
        public void CanAddNormalContainerWeightToStack2()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[1]);
            
            // Assert
            Assert.AreEqual(falseValue, actualvalue);
        }

        [TestMethod]
        //NORMAL CONTAINERS
        public void CanAddNormalContainerWeightToStack3()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[2]);
            
            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //VALUABLE CONTAINERS
        public void CanAddValuableContainerWeightToStack()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[3]);
            
            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //VALUABLE CONTAINERS
        public void CanAddValuableContainerWeightToStack2()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[4]);

            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //VALUABLE CONTAINERS
        public void CanAddValuableContainerWeightToStack3()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[5]);

            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //COOLED CONTAINERS
        public void CanAddCooledContainerWeightToStack()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[6]);

            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //COOLED CONTAINERS
        public void CanAddCooledContainerWeightToStack2()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[7]);

            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

        [TestMethod]
        //COOLED CONTAINERS
        public void CanAddCooledContainerWeightToStack3()
        {
            bool actualvalue = stack.CanAddContainerToStack(MockContainers.testContainers[8]);

            // Assert
            Assert.AreEqual(trueValue, actualvalue);
        }

    }
}
