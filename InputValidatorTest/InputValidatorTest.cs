using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputValidatorMain;

namespace InputValidatorTest
{
    [TestClass]
    public class InputValidatorTest
    {
        [TestMethod]
        public void CheckName()
        {
            InputValidatorMain.InputValidator iv = new InputValidatorMain.InputValidator();
            string name;

            name = "kalman";
            Assert.IsTrue(iv.ValidateName(name));

            name = "4kalman";
            Assert.IsFalse(iv.ValidateName(name));

            name = "Kalman";
            Assert.IsTrue(iv.ValidateName(name));

            name = "kal4man";
            Assert.IsFalse(iv.ValidateName(name));

            name = "kalman4";
            Assert.IsFalse(iv.ValidateName(name));

            name = "kal4man_";
            Assert.IsFalse(iv.ValidateName(name));

            name = "kaLmaN";
            Assert.IsTrue(iv.ValidateName(name));

            name = "kal_man";
            Assert.IsFalse(iv.ValidateName(name));

            name = "kasza blanka";
            Assert.IsFalse(iv.ValidateName(name));
        }

        [TestMethod]
        public void CheckPhone()
        {
            InputValidatorMain.InputValidator iv = new InputValidatorMain.InputValidator();
            string phone;

            phone = "123-456-7890";
            Assert.IsTrue(iv.ValidatePhone(phone));

            phone = "362-185-2394";
            Assert.IsTrue(iv.ValidatePhone(phone));

            phone = "h362-1865-2394";
            Assert.IsFalse(iv.ValidatePhone(phone));

            phone = "h362-1865-2394h";
            Assert.IsFalse(iv.ValidatePhone(phone));

            phone = "abc-def-ghij";
            Assert.IsFalse(iv.ValidatePhone(phone));

            phone = "362_1865_2394";
            Assert.IsFalse(iv.ValidatePhone(phone));
        }

        [TestMethod]
        public void CheckEmail()
        {
            InputValidatorMain.InputValidator iv = new InputValidatorMain.InputValidator();
            string email;

            email = "local@domain.com";
            Assert.IsTrue(iv.ValidateEmail(email));

            email = "local@domain.hu";
            Assert.IsTrue(iv.ValidateEmail(email));

            email = "loc4l@dom41n.hu";
            Assert.IsTrue(iv.ValidateEmail(email));

            email = "local@domain.hu_";
            Assert.IsFalse(iv.ValidateEmail(email));

            email = "local@domain.";
            Assert.IsFalse(iv.ValidateEmail(email));

            email = "local@domain";
            Assert.IsFalse(iv.ValidateEmail(email));

            email = "@domain.hu";
            Assert.IsFalse(iv.ValidateEmail(email));

            email = "local.hu";
            Assert.IsFalse(iv.ValidateEmail(email));

            email = "localdomainhu";
            Assert.IsFalse(iv.ValidateEmail(email));
        }
    }
}
