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
            // @"^?(\d{3})?[\s-]?(\d{3})?[\s-]?(\d{4})?$"
            string phoneNumSequence1 = @"\(?(\d{3})\)";
            string phoneNumSequence2 = @"(\d{3})";
            string phoneNumSequence3 = @"(\d{4})?";
            string phoneNumSep = @"?[\s\-]?";
            PhoneRegex = String.Format("^{1}{0}{2}{0}{3}$", phoneNumSep, phoneNumSequence1, phoneNumSequence2, phoneNumSequence3);

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
        public string ReformatPhone(string phone)
        {
            Match m = Regex.Match(phone, PhoneRegex);
            //Match m = Regex.Match(phone, @"^\(?(\d{3})\)?[\s-]?(\d{3})?[\s-]?(\d{4})?$");
            if (!ValidatePhone(phone))
            {
                throw new ArgumentException("Phone number can't be reformatted");
            }
            return String.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
        }
    }
}
