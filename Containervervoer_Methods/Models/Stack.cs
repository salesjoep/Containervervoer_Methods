using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containervervoer_Methods.Models
{
    public class Stack
    {
        //Class Fields
        private List<Container> containers = new List<Container>();

        //Class Properties
        private int MaximumStackWeight { get; set; }
        public int CurrentStackWeight { get; set; }

        public List<Container> containerList { get { return containers; } }        


        //Class Constructor
        public Stack()
        {
            int maximumStackWeight = 150;

            this.MaximumStackWeight = maximumStackWeight;
        }

        //Class Methods

        //Method that checks if we can add a container to the stack
        public bool CanAddContainerToStack(Container containerToAdd)
        {
            //If containerToAdd is normal and total weight < maximum
            if (containerToAdd.Type == 1 && ((CurrentStackWeight + containerToAdd.ContainerWeight) <= MaximumStackWeight))
            {
                //Checks for valuable containers in list
                if (!CountValuable())
                {
                    return false;
                }
                //If there are no valuable containers in list
                else
                {                    
                    containers.Add(containerToAdd);
                    CurrentStackWeight += containerToAdd.ContainerWeight;
                    //CurrentStackWeight += containerToAdd.ContainerWeight;
                    return true;
                }
            }
            //If containerToAdd is valuable and total weight < maximum
            if (containerToAdd.Type == 2 && ((CurrentStackWeight + containerToAdd.ContainerWeight) <= MaximumStackWeight))
            {
                //Checks for valuable containers in list
                if (!CountValuable())
                {
                    return false;
                }
                //If there are no valuable containers in list
                else
                {                    
                    containers.Add(containerToAdd);
                    CurrentStackWeight += containerToAdd.ContainerWeight;
                    //CurrentStackWeight += containerToAdd.ContainerWeight;
                    return true;
                }
            }
            //If containerToAdd is cooled and total weight < maximum
            if (containerToAdd.Type == 3 && ((CurrentStackWeight + containerToAdd.ContainerWeight) <= MaximumStackWeight))
            {
                //Checks for valuable containers in list
                if (!CountValuable())
                {
                    return false;
                }
                //If there are no valuable containers in list
                else
                {                    
                    containers.Add(containerToAdd);
                    CurrentStackWeight += containerToAdd.ContainerWeight;
                    //CurrentStackWeight += containerToAdd.ContainerWeight;
                    return true;
                }
            }
            if (CurrentStackWeight >= MaximumStackWeight)
            {                
                return false;
            }
            return false;
        }

        //Method that allows the user to remove a container from the list.
        public bool RemoveContainer(Container container)
        {
            //Is container removed? then return false
            bool removed = containers.Remove(container);
            if (removed == false) return false;

            //else remove container weight from stackweight.
            
            return true;
        }

        //Checks how much valuable containers in container list.
        public bool CountValuable()
        {
            //Counter for valuable containers
            int count = 0;
            //For every container in list
            foreach (var container in containers)
            {
                //If container is valuable
                if (container.Type == 2)
                {
                    count += 1;
                }
            }
            //If >= 1 valuable containers in list
            if (count >= 1)
            {
                return false;
            }
            return true;
        }

        
    }
}
