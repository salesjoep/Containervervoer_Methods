using Containervervoer_Methods.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.Row
{
    [TestClass]
    public class CanAddContainerToEmptyRowTest
    {
        Containervervoer_Methods.Models.Row row;        
        List<Containervervoer_Methods.Models.Stack> stacks = new List<Containervervoer_Methods.Models.Stack>();

        bool trueValue = true;
        bool falseValue = false;

        [TestMethod]
        public void CanAddContainerToEmptyRow()
        {
            // Arrange
            row = new Containervervoer_Methods.Models.Row(3);            

            // Act
            bool actualValue = row.CanAddContainer(MockContainers.testContainers[0]);
            // Assert
            Assert.AreEqual(trueValue, actualValue);
        }

        [TestMethod]
        public void CanAddContainerToEmptyRow2()
        {
            // Arrange
            row = new Containervervoer_Methods.Models.Row(1);

            // Act
            row.CanAddContainer(MockContainers.testContainers[0]);
            row.CanAddContainer(MockContainers.testContainers[7]);
            bool actualValue = row.CanAddContainer(MockContainers.testContainers[1]);

            // Assert
            Assert.AreEqual(falseValue, actualValue);
        }

        [TestMethod]
        public void CanAddContainerToEmptyRow3()
        {
            // Arrange
            row = new Containervervoer_Methods.Models.Row(2);

            // Act
            row.CanAddContainer(MockContainers.testContainers[0]);
            row.CanAddContainer(MockContainers.testContainers[7]);
            bool actualValue = row.CanAddContainer(MockContainers.testContainers[1]);

            // Assert
            Assert.AreEqual(trueValue, actualValue);
        }


    }
}
