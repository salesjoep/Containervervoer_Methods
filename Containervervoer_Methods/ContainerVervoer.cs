using Containervervoer_Methods.Exceptions;
using Containervervoer_Methods.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containervervoer_Methods
{
    public partial class ContainerVervoer : Form
    {
        private readonly List<Models.Container> _containers = new List<Models.Container>();
        Ship ship;
        int containers = 0;
        int weight = 0;

        public ContainerVervoer()
        {
            InitializeComponent();
            ShipInfoLabel.Visible = false;
            ShipInfoLb.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {                        
            if (NormalRb.Checked)
            {
                Models.Container container = new Models.Container(1, Convert.ToInt32(ContainerWeightNud.Value));
                _containers.Add(container);
                ContainersLb.Items.Add(container);
                //Show container amount
                containers += 1;
                weight += container.ContainerWeight;
                Weightlabel.Text = weight.ToString();
                containerCountLabel.Text = containers.ToString();
            }
            if (CooledRb.Checked)
            {
                Models.Container container = new Models.Container(2, Convert.ToInt32(ContainerWeightNud.Value));
                _containers.Add(container);
                ContainersLb.Items.Add(container);
                //Show container amount
                containers += 1;
                weight += container.ContainerWeight;
                Weightlabel.Text = weight.ToString();
                containerCountLabel.Text = containers.ToString();
            }
            if (ValuableRb.Checked)
            {
                Models.Container container = new Models.Container(3, Convert.ToInt32(ContainerWeightNud.Value));
                _containers.Add(container);
                ContainersLb.Items.Add(container);
                //Show container amount
                containers += 1;
                weight += container.ContainerWeight;
                Weightlabel.Text = weight.ToString();
                containerCountLabel.Text = containers.ToString();
            }
        }

        private void Stackbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            var enoughCargo = _containers.Sum(c => c.ContainerWeight) < ship.MinWeight;

            if (enoughCargo)
            {
                throw new ShipRowException("applicationErrorFlag: NotEnoughCargo");
            }
            //double weight = 0;
            StackLb.Items.Clear();
            foreach (var container in _containers)
            {

                ship.AddContainerToShip(container);
                //weight += container.ContainerWeight;
            }
            //ship.CalculateTotalWeight();

            ship.OpenUnityWebGL();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContainersLb.SelectedIndex;
            if (selectedIndex <0)
            {
                MessageBox.Show("Please select a Container.");
                return;
            }
            ContainersLb.Items.RemoveAt(selectedIndex);
            _containers.RemoveAt(selectedIndex);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ship != null)
            {
                throw new ShipRowException("applicationErrorFlag: ShipAlreadyExists");
            }
            int length = Convert.ToInt32(LengthNud.Value);
            int width = Convert.ToInt32(WidthNud.Value);            
            ship = new Ship(length, width);

            ShipInfoLabel.Visible = true;
            ShipInfoLb.Visible = true;
            ShipInfoLb.HorizontalScrollbar = true;
            ShipInfoLb.Items.Add(ship.ToString());

            MinWeight.Text = ship.MinWeight.ToString();
            MaxWeight.Text = ship.MaxWeight.ToString();

            
        }

        private void VisualizeBtn_Click(object sender, EventArgs e)
        {
            if (ship != null)
            {
                ship.OpenUnityWebGL();
            }
        }

        private void CooledRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShipInfoLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ContainerVervoer_Load(object sender, EventArgs e)
        {

        }
    }
}
