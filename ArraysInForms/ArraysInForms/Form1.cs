using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysInForms
{
    public partial class Form1 : Form
    {
        static double[] numbers;
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, EventArgs e)
        {
            btnTask1.BackColor = Color.LightGreen;
            btnTask1.ForeColor = Color.Black;

            /*.........Task 1.........*/

            /*Display the necessary parts for task 1*/
            textBoxTask1.Visible = true;
            textBoxTask1Instructions.Visible = true;
            lblTask.Visible = true;

            /*Set the required properties*/
            lblTask.Text = "Task 1";

            numbers = new double[10];


        }

        private void TextBoxTask1_Click(object sender, EventArgs e)
        {
            textBoxTask1.Text = "";
            textBoxTask1.ForeColor = Color.Black;
        }

        private void TextBoxTask1_TextChanged(object sender, EventArgs e)
        {
            btnAddNumber.Visible = true;
        }

        private void BtnAddNumber_Click(object sender, EventArgs e)
        {
            if(counter <= 9)
            {
                if (double.TryParse(textBoxTask1.Text, out numbers[counter]))
                {

                    counter++;
                    btnAddNumber.Text = $"Add number {counter + 1}";
                    textBoxTask1.ForeColor = Color.LightGray;
                    textBoxTask1.Text = $"Enter your numbers here .....";
                }
                else if (!double.TryParse(textBoxTask1.Text, out numbers[counter]))
                {
                    textBoxTask1.ForeColor = Color.LightGray;
                    textBoxTask1.Text = $"Enter your numbers here .....";
                }
            }
            if(counter > 9)
            {
                textBoxTask1.Visible = false;
                btnDisplay.Visible = true;
                textBoxTask1Instructions.Text = "Thankyou, all 10 numbers have been input...";
            }

            btnAddNumber.Visible = false;
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            foreach(var x in numbers)
            {
                listBoxArray.Items.Add(x);
            }
        }
    }
}
