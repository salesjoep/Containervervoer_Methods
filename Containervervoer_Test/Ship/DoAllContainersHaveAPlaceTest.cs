using Containervervoer_Methods.Exceptions;
using Containervervoer_Methods.Models;
using Containervervoer_Test.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.Ship
{
    [TestClass]
    public class DoAllContainersHaveAPlaceTest
    {
        Containervervoer_Methods.Models.Ship shipTest;
        List<Container> containerListTest = new List<Container>();
        [TestMethod]
        public void DoAllContainershaveAPlace1()
        {
            // Arrange
            shipTest = MockShips.testShip4;

            // Act
            for (int i = 0; i < 3; i++)
            {
                containerListTest.Add(MockContainers.testContainers[11]);
            }
            for (int i = 0; i < 3; i++)
            {
                containerListTest.Add(MockContainers.testContainers[9]);
            }
            for (int i = 0; i < 3; i++)
            {
                containerListTest.Add(MockContainers.testContainers[10]);
            }

            foreach (var container in containerListTest)
            {
                shipTest.AddContainerToShip(container);
            }
            // Assert
            Assert.AreEqual(1, shipTest.rowList.Count);

        }

        [TestMethod]
        public void DoAllContainershaveAPlace2()
        {
            // Arrange
            shipTest = MockShips.testShip4;

            // Act
            for (int i = 0; i < 4; i++)
            {
                containerListTest.Add(MockContainers.testContainers[11]);
            }
            for (int i = 0; i < 4; i++)
            {
                containerListTest.Add(MockContainers.testContainers[9]);
            }
            for (int i = 0; i < 4; i++)
            {
                containerListTest.Add(MockContainers.testContainers[10]);
            }

            foreach (var container in containerListTest)
            {
                shipTest.AddContainerToShip(container);
            }
            // Assert
            Assert.AreEqual(2, shipTest.rowList.Count);

        }
        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void DoAllContainershaveAPlace3()
        {
            // Arrange
            shipTest = MockShips.testShip4;

            // Act
            for (int i = 0; i < 6; i++)
            {
                containerListTest.Add(MockContainers.testContainers[11]);
            }
            for (int i = 0; i < 6; i++)
            {
                containerListTest.Add(MockContainers.testContainers[9]);
            }
            for (int i = 0; i < 6; i++)
            {
                containerListTest.Add(MockContainers.testContainers[10]);
            }

            foreach (var container in containerListTest)
            {
                shipTest.AddContainerToShip(container);
            }
            // Assert

        }
    }
}
