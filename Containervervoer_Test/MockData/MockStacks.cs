using Containervervoer_Methods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.MockData
{
    public static class MockStacks
    {
        public static List<Containervervoer_Methods.Models.Stack> testStacks = new List<Containervervoer_Methods.Models.Stack>()
        {
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
            new Containervervoer_Methods.Models.Stack(),
        };

        public static void PopulateStack()
        {
            testStacks[0].CanAddContainerToStack(MockContainers.testContainers[0]);
            testStacks[0].CanAddContainerToStack(MockContainers.testContainers[10]);
        }

        public static void PopulateStack1()
        {
            testStacks[1].CanAddContainerToStack(MockContainers.testContainers[0]);
            testStacks[1].CanAddContainerToStack(MockContainers.testContainers[11]);
        }

        public static void PopulateStack2()
        {
            testStacks[2].CanAddContainerToStack(MockContainers.testContainers[11]);
            testStacks[2].CanAddContainerToStack(MockContainers.testContainers[11]);
        }

        public static void PopulateStack3()
        {
            testStacks[3].CanAddContainerToStack(MockContainers.testContainers[0]);
            testStacks[3].CanAddContainerToStack(MockContainers.testContainers[8]);
        }

        public static void PopulateStack4()
        {
            testStacks[4].CanAddContainerToStack(MockContainers.testContainers[0]);
            testStacks[4].CanAddContainerToStack(MockContainers.testContainers[9]);
        }
        public static void PopulateStack5()
        {
            testStacks[5].CanAddContainerToStack(MockContainers.testContainers[0]);
            testStacks[5].CanAddContainerToStack(MockContainers.testContainers[9]);
        }
        public static void PopulateStack6()
        {
            testStacks[6].CanAddContainerToStack(MockContainers.testContainers[3]);
            testStacks[6].CanAddContainerToStack(MockContainers.testContainers[5]);
        }
        public static void PopulateStack7()
        {
            testStacks[7].CanAddContainerToStack(MockContainers.testContainers[5]);
            testStacks[7].CanAddContainerToStack(MockContainers.testContainers[5]);
        }
        public static void PopulateStack8()
        {
            testStacks[8].CanAddContainerToStack(MockContainers.testContainers[3]);
            testStacks[8].CanAddContainerToStack(MockContainers.testContainers[5]);
        }
        public static void PopulateStack9()
        {
            testStacks[9].CanAddContainerToStack(MockContainers.testContainers[7]);
            testStacks[9].CanAddContainerToStack(MockContainers.testContainers[7]);
        }
    }
}
