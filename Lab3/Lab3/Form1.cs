//Grading ID: S6863
//Lab Number: Lab3
//Due Date: 2/16/20
//Course section: CIS199-75
//This program creates the output for the Diamter, Surface Area, and Volume of sphere from radius that the user provides
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }
        //When the calculate button is clicked, the diamter, surface area, and volume of the spheare is calcualted from the radius that was provided
        private void Calculate_Click(object sender, EventArgs e)
        {
            double Diameter; //defines the variable for the equation of the diameter
            double Area; //defines the variable for the equation of the surface area
            double Volume; //defines the variable for the equation of the volume
            double RadiusOfSphere; //defines the variable for the radius that the user inputs
            RadiusOfSphere = double.Parse(SphereTB.Text);
            Diameter = 2 * RadiusOfSphere;
            Area = 4 * Math.PI * Math.Pow(RadiusOfSphere, 2);
            Volume = (4 * Math.PI * Math.Pow(RadiusOfSphere, 3) / 3);
            DiameterOP.Text = ($"{Diameter:f2}");
            SurfaceAreaOP.Text = ($"{Area:f2}");
            VolumeOP.Text = ($"{Volume:f2}");


        }
    }
}
