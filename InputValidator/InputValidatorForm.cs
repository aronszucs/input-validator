﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace InputValidatorMain
{
    public partial class InputValidatorForm : Form
    {
        public InputValidatorForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            InputValidator iv = new InputValidator();

            if (!iv.ValidateName(nameTextBox.Text))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }
            try
            {
                phoneTextBox.Text = iv.ReformatPhone(phoneTextBox.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The phone number is not valid.");
            }
            if (!iv.ValidateEmail(emailTextBox.Text))
            {
                MessageBox.Show("The e-mail address is not valid.");
            }
        }
    }
}
