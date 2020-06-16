using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Test.MockData
{
    public static class MockRows
    {
        public static List<Containervervoer_Methods.Models.Row> testRows = new List<Containervervoer_Methods.Models.Row>()
        {
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(3),
            new Containervervoer_Methods.Models.Row(7),

            new Containervervoer_Methods.Models.Row(3),
        };

        public static void PopulateRow()
        {
            testRows[0].CanAddContainer(MockContainers.testContainers[0]);
        }
    }
}
