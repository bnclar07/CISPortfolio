//Student ID:S6863
//Lab 4
//2/16/20
//CIS199-75
//This program calculates if the input meets the requirments of the GPA and Test Score to be accepted whille counting how many have been accepted and rejected
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int Accepted; //Defines the Accepted value for the running total
        int Rejected; //Defines the Rejected value for the running total
        

        public Form1()
        {
            InitializeComponent();
        }

        //When the enter button is clicked, it outputs if the input of the GPA and Test Score meets the requirments whille counting how many has been rejected and aacepted
        private void EnterButton_Click(object sender, EventArgs e)
        {
            float GPA; //Defines the GPA output value as a float
            int TestScore; //Deines the Test Score output value as an integer
            
            //Varify value as an if and else statement
            if (float.TryParse(gpaTB.Text, out GPA)) //Varifies if the GPA is the correct data type

                if (int.TryParse(TestScoreTB.Text, out TestScore)) //Varifies if the Test Score is the correct data type

                    if ((GPA >= 3.0 && TestScore >= 60) || (GPA < 3.0 && TestScore >= 80)) 
                    {
                        DecisionLB.Text = "Accept";                                         //Accept students if they meet requirements
                        Accepted = Accepted + 1;                                            //Keeps a runnin total of how many have been accepted by adding 1
                        AcceptedOP.Text = Convert.ToString(Accepted);
                        RejectedOP.Text = Convert.ToString(Rejected);
                    }

                    else
                    {
                        DecisionLB.Text = "Reject";                                         //Reject students if they dont meet requirments
                        Rejected = Rejected + 1;                                            //Keeps a running total of how many have been rejected by adding 1
                        RejectedOP.Text = Convert.ToString(Rejected);   
                        AcceptedOP.Text = Convert.ToString(Accepted);
                    }
                else
                { MessageBox.Show("Test Score must be an integer of 0 to 100"); } //Shows message if data type is not correct for Test Score
            else
            { MessageBox.Show("GPA must be a value between 0.0 to 4.0"); } //Shows message if data type for GPA is not correct

            

        }
    }
    }
