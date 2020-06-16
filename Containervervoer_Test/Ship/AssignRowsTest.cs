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
    public class AssignRowsTest
    {
        List<Containervervoer_Methods.Models.Row> expectedRows = new List<Containervervoer_Methods.Models.Row>();
        List<Containervervoer_Methods.Models.Row> actualRows = new List<Containervervoer_Methods.Models.Row>();
         
        [TestMethod]
        public void CreateNewRowOnGo()
        {
            // Arrange
            MockShips.testShip.AssignRows();

            Assert.IsNotNull(MockShips.testShip.rowList);
        }

        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void AssignRows1()
        {
            // Arrange
            MockShips.testShip1.AddContainerToShip(MockContainers.testContainers[0]);
            MockShips.testShip1.AddContainerToShip(MockContainers.testContainers[0]);
            MockShips.testShip1.AddContainerToShip(MockContainers.testContainers[0]);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void AssignRows2()
        {
            // Arrange
            MockShips.testShip2.AddContainerToShip(MockContainers.testContainers[7]);
            MockShips.testShip2.AddContainerToShip(MockContainers.testContainers[7]);
            MockShips.testShip2.AddContainerToShip(MockContainers.testContainers[8]);
            MockShips.testShip2.AddContainerToShip(MockContainers.testContainers[8]);

            MockShips.testShip2.AddContainerToShip(MockContainers.testContainers[10]);

        }

        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void AssignRows3()
        {
            // Arrange
            for (int i = 0; i < 9; i++)
            {
                MockShips.testShip3.AddContainerToShip(MockContainers.testContainers[7]);
                MockShips.testShip3.AddContainerToShip(MockContainers.testContainers[8]);
                MockShips.testShip3.AddContainerToShip(MockContainers.testContainers[9]);
            }
            MockShips.testShip3.AddContainerToShip(MockContainers.testContainers[10]);

        }
    }
}
