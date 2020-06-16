using Containervervoer_Test.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.Stack.Count_Valuable_Tests
{
    [TestClass]
    public class CountValuableTest
    {
        //Arrange
        bool trueValue = true;
        bool falseValue = false;

        //Act
        [TestMethod]
        public void CountValuable()
        {
            MockStacks.PopulateStack3();
            bool actualValue = MockStacks.testStacks[3].CountValuable();

            Assert.AreEqual(falseValue, actualValue);
        }

        [TestMethod]
        public void CountValuable2()
        {
            MockStacks.PopulateStack9();
            bool actualValue = MockStacks.testStacks[9].CountValuable();

            Assert.AreEqual(falseValue, actualValue);
        }

        [TestMethod]
        public void CountValuable3()
        {
            MockStacks.PopulateStack();
            bool actualValue = MockStacks.testStacks[0].CountValuable();

            Assert.AreEqual(trueValue, actualValue);
        }
    }
}
