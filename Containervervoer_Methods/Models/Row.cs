using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;


namespace Containervervoer_Methods.Models
{
    public class Row
    {

        private List<Stack> stacks = new List<Stack>();
        public ReadOnlyCollection<Stack> stackList
        {
            get { return stacks.AsReadOnly(); }
        }
        public int Length { get; private set; }

        public Row(int length)
        {
            this.Length = length;
        }
        
        //Add container Method
        public bool CanAddContainer(Container container)
        {
            //If there are no stacks in list, create new stack
            if (stacks.Count == 0) stacks.Add(new Stack());
            //For each stack in stacklist
            //MessageBox.Show("Length: " + Length.ToString());
            foreach (Stack stack in stacks)
            {
                //MessageBox.Show("Stacks: " + stackList.Count);
                //If we can add a container to the stack
                if (stack.CanAddContainerToStack(container)) return true;
                else
                {
                    //Else if it is the last stack
                    if (stack.Equals(stacks.Last()))
                    {
                        
                        //If the stacklist is not longer than width
                        if (stacks.Count < Length)
                        {
                            
                            stacks.Add(new Stack());
                            stacks[stacks.Count - 1].CanAddContainerToStack(container);
                            return true;
                        }                        
                        else 
                        {
                            return false;
                        }
                    }
                }
            }
            MessageBox.Show(stacks.Count.ToString());
            return false;
        }
    }
}
