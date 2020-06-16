using Containervervoer_Methods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test
{
    public static class MockContainers
    {
        public static List<Container> testContainers = new List<Container>()
        {
            //Normal containers
            new Container(1, 100), //0
            new Container(1, 160), //1
            new Container(1, 150), //2
            //Cooled containers
            new Container(3, 100), //3
            new Container(3, 150), //4
            new Container(3, 15), //5
            //Valuable containers
            new Container(2, 100), //6
            new Container(2, 30), //7
            new Container(2, 15), //8
            //Normal containers for stacks
            new Container(1, 30), //9
            new Container(1, 10), //10
            new Container(1, 40), //11
        };
    }
}
