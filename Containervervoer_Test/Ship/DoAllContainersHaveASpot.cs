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
    public class DoAllContainersHaveASpot
    {
        [TestMethod]
        public void DoAllContainersHaveASpot1()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(10, 10);

            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);

            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[3]);
            testContainers.Add(MockContainers.testContainers[8]);

            List<Container> actualContainers = new List<Container>();

            foreach (var row in testShip.rowList)
            {
                foreach (var stack in row.stackList)
                {
                    foreach (var container in stack.containerList)
                    {
                        actualContainers.Add(container);
                    }
                }
            }

            CollectionAssert.AreEqual(testContainers, actualContainers);
            //Row
            Assert.AreEqual(1, testShip.rowList.Count);
        }

        [TestMethod]
        public void DoAllContainersHaveASpot2()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(2, 2);

            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);

            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[8]);

            List<Container> actualContainers = new List<Container>();

            foreach (var row in testShip.rowList)
            {
                foreach (var stack in row.stackList)
                {
                    foreach (var container in stack.containerList)
                    {
                        actualContainers.Add(container);
                    }
                }
            }

            CollectionAssert.AreEqual(testContainers, actualContainers);
            //Rows
            Assert.AreEqual(2, testShip.rowList.Count);
        }

        [TestMethod]
        public void DoAllContainersHaveASpot3()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(3, 3);

            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[9]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[4]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[6]);

            testContainers.Add(MockContainers.testContainers[3]);
            testContainers.Add(MockContainers.testContainers[9]);
            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[4]);
            testContainers.Add(MockContainers.testContainers[3]);
            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[8]);
            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[6]);

            List<Container> actualContainers = new List<Container>();

            foreach (var row in testShip.rowList)
            {
                foreach (var stack in row.stackList)
                {
                    foreach (var container in stack.containerList)
                    {
                        actualContainers.Add(container);
                    }
                }
            }

            CollectionAssert.AreEqual(testContainers, actualContainers);
            //Rows
            Assert.AreEqual(2, testShip.rowList.Count);
        }

        [TestMethod]
        public void DoAllContainersHaveASpot4()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(3, 5);

            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);

            testContainers.Add(MockContainers.testContainers[6]);
            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[8]);
            testContainers.Add(MockContainers.testContainers[8]);
            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[6]);
            testContainers.Add(MockContainers.testContainers[6]);
            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[8]);

            List<Container> actualContainers = new List<Container>();

            foreach (var row in testShip.rowList)
            {
                foreach (var stack in row.stackList)
                {
                    foreach (var container in stack.containerList)
                    {
                        actualContainers.Add(container);
                    }
                }
            }
            CollectionAssert.AreEqual(testContainers, actualContainers);
            //Rows
            Assert.AreEqual(3, testShip.rowList.Count);
        }

        [TestMethod]
        public void DoAllContainersHaveASpot5()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(2, 5);

            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[4]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[9]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);

            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[4]);
            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[8]);
            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[3]);
            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[8]);
            testContainers.Add(MockContainers.testContainers[7]);
            testContainers.Add(MockContainers.testContainers[9]);
            testContainers.Add(MockContainers.testContainers[5]);
            testContainers.Add(MockContainers.testContainers[3]);
            testContainers.Add(MockContainers.testContainers[6]);
            testContainers.Add(MockContainers.testContainers[8]);
            testContainers.Add(MockContainers.testContainers[8]);

            List<Container> actualContainers = new List<Container>();

            foreach (var row in testShip.rowList)
            {
                foreach (var stack in row.stackList)
                {
                    foreach (var container in stack.containerList)
                    {
                        actualContainers.Add(container);
                    }
                }
            }
            CollectionAssert.AreEqual(testContainers, actualContainers);
            //Rows
            Assert.AreEqual(5, testShip.rowList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void DoAllContainersHaveASpot6()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(1, 1);

            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);

            
        }
        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void DoAllContainersHaveASpot7()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(2, 1);

            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[5]);
            testShip.AddContainerToShip(MockContainers.testContainers[3]);


        }

        [TestMethod]
        [ExpectedException(typeof(ShipRowException))]
        public void DoAllContainersHaveASpot8()
        {
            List<Container> testContainers = new List<Container>();
            Containervervoer_Methods.Models.Ship testShip = new Containervervoer_Methods.Models.Ship(2, 1);

            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[6]);
            testShip.AddContainerToShip(MockContainers.testContainers[7]);
            testShip.AddContainerToShip(MockContainers.testContainers[8]);


        }


    }
}
