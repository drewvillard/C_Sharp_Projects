using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Calculator : Form
    {
        double firstNum = 0;
        double secondNum = 0;
        string operation = "";
        double result = 0;
        double decimalPlace = 0;

        public Calculator()
        {
            InitializeComponent();
        }
        // Clear Entry Button
        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNum = 0;
                
            }
            else 
            {
                secondNum = 0;
                
            }
            decimalPlace = 0;
            txtBoxEntry.Clear();
        }

        // Number Buttons
        //takes correct num (determined through testing operation) and effectively appends the users choice to then end of the number
        //by multiplying it by ten then adding the pushed buttons number(assume firstNum=3 and the user pushes 2 ex.((3*10)+2=32)
        //so the user would've pushed 3 then 2. and all buttons are coded the same way.
       
        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 1;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum =firstNum + (1/decimalPlace);
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10)+1;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (1 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 2;
                   
                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 2 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10)+2;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (2 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 3;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 3 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 3;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (3 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 4;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 4 / decimalPlace;   
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 4;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (4 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 5;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 5 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 5;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (5 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 6;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 6 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {

                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 6;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (6 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 7;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 7 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 7;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (7 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 8;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 8 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {
                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 8;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (8 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 9;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 9 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();

            }
            else
            {

                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 9;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (9 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }
        //not sure how to properly implement 0 after the decimal place, it gets added to the number but not displayed properly
        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                if (decimalPlace == 0)
                {
                    firstNum = (firstNum * 10) + 0;

                }
                else
                {
                    decimalPlace *= 10;
                    firstNum += 0 / decimalPlace;
                }
                txtBoxEntry.Text = firstNum.ToString();
            }
            else
            {

                if (decimalPlace == 0)
                {
                    secondNum = (secondNum * 10) + 0;
                }
                else
                {
                    decimalPlace *= 10;
                    secondNum = secondNum + (0 / decimalPlace);
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        // Decimal Button
        private void decimalBtn_Click(object sender, EventArgs e)
        {
            //if there isnt a decimal, add one.
            if (!txtBoxEntry.Text.Contains("."))
            {
                txtBoxEntry.Text += ".";

                decimalPlace = 1;
            }

        }

        // Arithmetic Operation Buttons
        // Sets operation variable to appropriate operation based on button pushed. also resets decimal place because secondNum is to be set.
        private void plusBtn_Click(object sender, EventArgs e)
        {
            operation = "+";
            decimalPlace = 0;
            txtBoxEntry.Text = "0";
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            operation = "-";
            decimalPlace = 0;
            txtBoxEntry.Text = "0";
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            operation = "*";
            decimalPlace = 0;
            txtBoxEntry.Text = "0";
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            operation = "/";
            decimalPlace = 0;
            txtBoxEntry.Text = "0";
        }

        // Equals Button
        //when dividing by 0 nothing will happen.
        private void equalsBtn_Click(object sender, EventArgs e)
        {
            // Perform calculation with the current operation and first and second numbers from txtBoxEntry
            // and display the result in txtBoxEntry
            switch(operation){
                case "*":
                    result=firstNum*secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        
                    }
                    else
                    {
                        result = firstNum / secondNum;
                       
                    }
                    break;
                default:
                    break;

            }
            //set first num equal to result for rolling calculation
            firstNum = result;
            secondNum = 0;
            decimalPlace = 0;
            txtBoxEntry.Text = result.ToString();
        }

        // Clear Button
        //re-initializes all variables
        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            operation = "";
            decimalPlace = 0;
            result = 0;
            txtBoxEntry.Clear();
        }

        // Backspace Button
        private void backSpaceBtn_Click(object sender, EventArgs e)
        {
            if (operation.Equals("")) 
            {
                if (decimalPlace == 0)
                {
                    // Remove the last digit from firstNum
                    firstNum = (int)(firstNum / 10);

                    // Update the text box with the new value of firstNum
                    txtBoxEntry.Text = firstNum.ToString();
                }
                else 
                {
                    // reduce the decimal place by a factor of 10
                    decimalPlace /= 10; 
                    // remove the last decimal place by moving all but last digit to the integer side of the decimal then rounding down to the nearest int
                    // thereby truncating the last digit on the number. Then it divides this new int by decimalPlace, producing a backspaced effect.
                    firstNum = Math.Floor(firstNum * decimalPlace) / decimalPlace; 
                }
                txtBoxEntry.Text = firstNum.ToString();
            }
            
            else
            {
                if (decimalPlace == 0)
                {
                    // Remove the last digit from firstNum
                    secondNum = (int)(secondNum / 10);

                    // Update the text box with the new value of firstNum
                    txtBoxEntry.Text = secondNum.ToString();
                }
                else
                {
                    decimalPlace /= 10; // reduce the decimal place by a factor of 10
                    secondNum = Math.Floor(secondNum * decimalPlace) / decimalPlace; // remove the last decimal place
                }
                txtBoxEntry.Text = secondNum.ToString();
            }
        }

        // Sign Switch Button
        private void signSwitchBtn_Click(object sender, EventArgs e)
        {
            //multiplies correct num by negative 1
            if (operation.Equals(""))
            {
                firstNum = firstNum * -1;
                txtBoxEntry.Text = firstNum.ToString();
            }
            else
            {
                secondNum = secondNum * -1;
                txtBoxEntry.Text = secondNum.ToString();
            }
            
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
