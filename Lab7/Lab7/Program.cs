//Gradin ID:S6863
//Lab 7
//3/29/2020
//CIS199-75
//This program asks the user for an integer and it produces the number of * in rows and columns based on the users input
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7
{
    class Program
    {
        //The main method asks the user for an input and it must be a positve integer
        static void Main(string[] args)
        {
            int userInput; //defines the user's input
            Write("Enter an integer: ");
            if(int.TryParse(ReadLine(), out userInput)) //Makes sure the user inputs a positve integer
            {
                if (userInput >= 0)
                {
                    ShowSquareOfStars(userInput);
                }
                else
                {
                    WriteLine("Please enter a POSITIVE integer");
                }
            }
            else
            {
                WriteLine("Please enter a number");
            }
           
            
        }

        //This method creates the rows and columns of *
        public static void ShowSquareOfStars (int numStars)
        {
            for (int x = 0; x < numStars; x++) //a for loop is created for each round (0,1,etc) based on the users input and then it goes to the next for for the *
            {
                for (int y = 0; y < numStars; y++) //for each each round it completes another round (0,0; 0,1; 0,2; etc) it continues to put an * based on the amount the user inputed
                {
                    Write("*");
                }
                WriteLine(""); //for each round (0,1,etc): after it completed the second for, it adds a space so it go through the whole process again
            }



        }
    }
}
