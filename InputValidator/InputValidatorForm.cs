using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InputValidator
{
    public partial class InputValidatorForm : Form
    {
        public InputValidatorForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string nameRegex = @"^[a-zA-Z]*$";
            string phoneRegex = @"^(\d{3})\-(\d{3})\-(\d{4})$";
            string emailRegex = @"^\w+@\w+\.[a-z]{2,3}$";
            if (!Regex.IsMatch(nameTextBox.Text, nameRegex))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }
            if (!Regex.IsMatch(phoneTextBox.Text, phoneRegex))
            {
                MessageBox.Show("The phone number is not a valid US phone number.");
            }
            if (!Regex.IsMatch(emailTextBox.Text, emailRegex))
            {
                MessageBox.Show("The e-mail address is not valid.");
            }
        }
    }
}
