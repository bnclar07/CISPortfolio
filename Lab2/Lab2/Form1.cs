//Grading ID: S6863
//Lab Number: Lab 2
//Due date: 2/2/2020
//CIS199-75
//This brogram create a GUI Application that calcualtes tip for three differnt percentages
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        //User has to click button and it will display tip for three different percentages
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double UserNumber; //Defines the information in the UserText Box
            double TipRateLowPrice; //Defines the amount of the User inpute with the low percentage amount
            double TipRateMiddlePrice; //Defines the amount of the User input with the middle percentage amount
            double TipRateHighPrice; //Defines the amount of the User input with the high percentage amount
            const double TIPRATE_LOW = .15; //Defines the variable for a low percentage amount
            const double TIPRATE_MIDDLE = .18; //Defines the varaible for a middle percentage amount
            const double TIPRATE_HIGH = .20; //Defines the varaible for a high percentage amount
            UserNumber = Convert.ToDouble(UserText.Text);

            TipRateLowPrice = UserNumber * TIPRATE_LOW;
            TipRateMiddlePrice = UserNumber * TIPRATE_MIDDLE;
            TipRateHighPrice = UserNumber * TIPRATE_HIGH;
            TipRateLowOP.Text = ($"{TipRateLowPrice:C2}");
            TipRateMiddleOP.Text = ($"{TipRateMiddlePrice:C2}");
            TipRateHighOP.Text = ($"{TipRateHighPrice:C2}");







        }

        //Before the program loads, variables on the design are changed based on the constants
        //This part is the optional Load Event step
        private void Lab2_Load(object sender, EventArgs e)
        {
            const double TIPRATE_LOW = .15; //Defines the variable for a low percentage aount
            const double TIPRATE_MIDDLE = .18; //Defines the variable for a middle percentage amount
            const double TIPRATE_HIGH = .20; //Defines the variable for a high percentage amount
            TipRateLowTB.Text = ($"{TIPRATE_LOW:p0}");
            TipRateMiddleTB.Text = ($"{TIPRATE_MIDDLE:p0}");
            TipRateHighTB.Text = ($"{TIPRATE_HIGH:p0}");





        }
    }
}
