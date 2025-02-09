using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{

    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        /// Helper method to calculate the arithmetic mean of a given array
        private double CalculateAverage(int[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        /// Event handler for the Generate button click
        /// Creates a Fibonacci sequence based on user input n
        /// Optionally calculates the average of the sequence
        private void button1_Click(object sender, EventArgs e)
        {
            // Start processing if TextBox is not empty
            if (textBox1.Text.Length != 0)
            {
                // Get the number entered by user
                int n = int.Parse(textBox1.Text);
                int[] fibonacci = new int[n];

                // Check for invalid number
                if (n < 1)
                {
                    MessageBox.Show("Please enter a valid number!");
                }
                // Special case for n=1
                else if (n == 1)
                {
                    fibonacci[0] = 1;
                }
                // Calculate Fibonacci sequence for n>1
                else
                {
                    fibonacci[0] = 1;
                    fibonacci[1] = 1;

                    for (int i = 2; i < n; i++)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }
                }

                // Display results in TextBox
                textBox2.Lines = Array.ConvertAll(fibonacci, x => x.ToString());

                // Calculate and show average if CheckBox is checked
                if (checkBox1.Checked)
                {
                    double average = CalculateAverage(fibonacci);
                    LbA.Text = "Average: " + average.ToString("0.00");
                }
                else
                {
                    LbA.Text = "";
                }
            }
        }

        /// Event handler to ensure only numeric input in TextBox
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number");
            }
        }

        /// Event handler to update button text based on CheckBox state

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = checkBox1.Checked ? "GENERATE AND CALCULATE" : "GENERATE";
        }
    }
}