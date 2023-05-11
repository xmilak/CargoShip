using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShip
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void button1_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }

        private void updateUI()
        {
            progressBar1.Maximum = ship.Capacity;

            if (ship.getShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.getShipLoad();

            label9.Text = ship.ToString();

            //motorcyckes
            label1.Text = ship.CycleCount.ToString();

            //cars
            label2.Text = ship.CarCount.ToString();

            //trucks
            label4.Text = ship.TruckCount.ToString();
            
            //train cars
            label3.Text = ship.TrainCarCount.ToString();

            if (ship.overUnder() < 0)
            {
                label5.Text = "Overloaded!";
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.Text = "Underloaded!";
                label5.ForeColor = Color.Green;
            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = trackBar3.Value;
            updateUI();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = trackBar2.Value;
            updateUI();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = trackBar4.Value;
            updateUI();
        }
    }
}
