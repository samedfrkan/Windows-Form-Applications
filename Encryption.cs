using System;
using System.Windows.Forms;

namespace CaesarCipherApp
{
    /// Windows Form application implementing Caesar Cipher encryption
    /// Supports both ROT2 and custom Caesar shift values
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Encrypt button
        /// Handles both ROT2 and custom Caesar cipher encryption based on user selection
        /// </summary>
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            bool success = false;
            string encryptedMessage = "";
            int caesarCode = 0;

            // Check if ROT2 encryption is selected
            if (radioButtonRot2.Checked)
            {
                // Apply ROT2 encryption (fixed shift of 2)
                (success, encryptedMessage) = Encipher(textBoxPassword.Text, 2);
            }
            // Check if Caesar cipher encryption is selected
            else if (radioButtonCaesar.Checked)
            {
                // If no Caesar code is provided, use default shift of 1
                if (textBoxCaesarCode.TextLength == 0)
                {
                    caesarCode = 1;
                    (success, encryptedMessage) = Encipher(textBoxPassword.Text, caesarCode);
                }
                // Try to parse and use custom Caesar shift value
                else if (int.TryParse(textBoxCaesarCode.Text, out caesarCode))
                {
                    (success, encryptedMessage) = Encipher(textBoxPassword.Text, caesarCode);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Caesar code.");
                    return;
                }
            }

            // Display the encrypted result
            encryptedTextLabel.Text = encryptedMessage;

            // Update success/failure indicator
            if (success)
            {
                successLabel.Text = "Success";
                successLabel.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                successLabel.Text = "Encryption failed";
                successLabel.BackColor = System.Drawing.Color.Red;
            }
        }


        /// Event handler to toggle visibility of Caesar code input field
        /// based on encryption method selection
        private void radioButtonCaesar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCaesarCode.Visible = radioButtonCaesar.Checked;
        }

        /// Implements the Caesar cipher encryption algorithm
        private (bool, string) Encipher(string input, int shift)
        {
            // Validate shift value
            if (shift < 0)
            {
                return (false, ""); // Negative shift values are invalid
            }

            string result = "";

            // Process each character in the input string
            foreach (char ch in input)
            {
                // Preserve non-letter characters without modification
                if (!char.IsLetter(ch))
                {
                    result += ch;
                    continue;
                }

                // Apply the shift to the current character
                char shiftedChar = (char)(ch + shift);

                // Handle wraparound for uppercase letters
                if (char.IsUpper(ch))
                {
                    if (shiftedChar > 'Z')
                    {
                        shiftedChar = (char)(shiftedChar - 26);
                    }
                }
                // Handle wraparound for lowercase letters
                else if (char.IsLower(ch))
                {
                    if (shiftedChar > 'z')
                    {
                        shiftedChar = (char)(shiftedChar - 26);
                    }
                }

                result += shiftedChar;
            }

            return (true, result);
        }
    }
}