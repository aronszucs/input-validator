using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace InputValidatorMain
{
    public class InputValidator
    {
        private string NameRegex;
        private string PhoneRegex;
        private string EmailRegex;
        public InputValidator()
        {
            NameRegex = @"^[a-zA-Z]*$";

            string phoneNumSequence1 = @"(\d{3})";
            string phoneNumSequence2 = @"(\d{4})";
            string phoneNumSep = @"\-";
            PhoneRegex = String.Format("^{1}{0}{1}{0}{2}$",
                phoneNumSep, phoneNumSequence1, phoneNumSequence2);

            string emailPart = @"\w+";
            string emailTopLevelDomain = "[a-z]{2,3}";
            EmailRegex = String.Format(@"^{0}@{0}\.{1}$", emailPart, emailTopLevelDomain);
        }

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, NameRegex);
        }

        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, PhoneRegex);
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EmailRegex);
        }
    }
}
