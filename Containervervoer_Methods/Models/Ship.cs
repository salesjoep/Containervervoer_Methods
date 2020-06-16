using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Containervervoer_Methods.Exceptions;

namespace Containervervoer_Methods.Models
{
    public class Ship
    {
        private List<Container> containerList = new List<Container>();


        public List<Row> rowList = new List<Row>();

        public int Length { get; set; }
        public int Width { get; set; }
        public int MaxWeight { get; set; }
        public int MinWeight { get; set; }
        public int CurrentWeight { get; set; }

        public Ship(int length, int width)
        {

            this.Length = length;
            this.Width = width;
            this.MaxWeight = (length * width) * 150;
            this.MinWeight = MaxWeight / 2;
        }

        public void AddContainerToShip(Container container)
        {
            containerList.Add(container);
            
            AssignRows();
        }

        public void AssignRows()
        {
            ResetToNewList();

            //If there are no rows, create new one
            if (rowList.Count == 0) rowList.Add(new Row(Length));
            //For each container in the container list
            foreach (var container in containerList)
            {
                //For every row in the row list
                for (int index = 0; index < rowList.Count; index++)
                {
                    //If container can be added to the stack and the row
                    if (rowList[index].CanAddContainer(container))
                    {
                        continue;
                    }
                    else
                    {
                        //If it is not the last row
                        if (index == rowList.Count - 1)
                        {
                            //If there are less rows than the length
                            if (rowList.Count < Width)
                            {
                                //New Row
                                rowList.Add(new Row(Length));
                                rowList[rowList.Count - 1].CanAddContainer(container);
                                break;
                            }

                            else
                            {
                                throw new ShipRowException("ApplicationErrorFlag: CreatedTooMuchContainers");
                            }

                        }

                    }
                }
            }
        }

        public void ResetToNewList()
        {
            rowList = new List<Row>();
        }

        public override string ToString()
        {
            return "Ship length: " + Length + " Containers -" + " Ship width: " + Width + " Containers -" + " Maximum Ship Weight: " + MaxWeight;
        }



        public void OpenUnityWebGL()
        {
            //Create empty args for url
            string stackArg = "";
            string weightArg = "";

            //Rowcount by default
            int rowCount = 0;

            //For each row in the list
            foreach (Row row in rowList)
            {
                //StackCount by default
                int stackCount = 0;

                if (rowCount > 0)
                {
                    //Args for defining new Row
                    stackArg += '/';
                    weightArg += '/';
                }
                //For each stack in in stack list in row obj
                foreach (Stack _stack in row.stackList)
                {
                    //containerCount by default
                    int containerCount = 0;

                    if (stackCount > 0)
                    {
                        //Args for defining new stack
                        stackArg += ',';
                        weightArg += ',';
                    }
                    //For each container in container list in stack obj
                    foreach (Container _container in _stack.containerList)
                    {
                        //New container = selected one
                        Container container = _container;
                        //Define container type in stack arg
                        stackArg += Convert.ToString(container.Type);
                        //Define container weight in weight arg
                        weightArg += Convert.ToString(container.ContainerWeight);
                        //if containerCount is not the last one
                        if (containerCount < (_stack.containerList.Count - 1))
                        {
                            //args for different weights
                            weightArg += "-";
                        }
                        containerCount++;
                    }
                    stackCount++;
                }
                rowCount++;
            }
            //start Unity
            Process.Start("https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?length=" + Length + "&width=" + Width + "&stacks=" + stackArg + "&weights=" + weightArg + "");
        }

    }
}
