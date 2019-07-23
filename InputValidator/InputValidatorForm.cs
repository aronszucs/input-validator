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

            string phoneNumSequence1 = @"(\d{3})";
            string phoneNumSequence2 = @"(\d{4})";
            string phoneNumSep = @"\-";
            string phoneRegex = String.Format("^{1}{0}{1}{0}{2}$",
                phoneNumSep, phoneNumSequence1, phoneNumSequence2);

            

            string emailPart = @"\w+";
            string emailTopLevelDomain = "[a-z]{2,3}";
            string emailRegex = String.Format(@"^{0}@{0}\.{1}$", emailPart, emailTopLevelDomain);

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
