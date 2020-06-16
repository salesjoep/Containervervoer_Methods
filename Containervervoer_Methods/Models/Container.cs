using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Methods.Models
{
    public enum ContainerType
    {
        Normal = 1, Cooled = 3, Valuable = 2
    }
    public class Container
    {
        //Class properties
        public int Type { get; set; }
        public int ContainerWeight { get; private set; }

        //Class Constructor
        public Container(int type, int containerWeight)
        {
            this.Type = Convert.ToInt32(TypeToInt(type));
            this.ContainerWeight = containerWeight;
        }

        //Class Methods
        private ContainerType TypeToInt(int _type)
        {
            ContainerType containerType = ContainerType.Normal;
            if (_type == 1) containerType = ContainerType.Normal;
            else if (_type == 2) containerType = ContainerType.Valuable;
            else if (_type == 3) containerType = ContainerType.Cooled;
            return containerType;
        }
        
        public override string ToString()
        {
            return "Containertype: " + Type + " -" + " Container Weight: " + ContainerWeight;
        }
    }
}
