using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.mange_user
{
    public class clsValidateInput
    {
        public enum enInputType
        {
            NumbersOnly,
            LettersOnly
        }


        public static bool  ValidateInput(TextBox txt, enInputType type,ErrorProvider errorProvider)
        {
            errorProvider.SetError(txt, "");

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, "This field is required");
                return false;
            }

            switch (type)
            {
                case enInputType.NumbersOnly:
                    if (!txt.Text.All(char.IsDigit))
                    {
                        errorProvider.SetError(txt, "Only numbers are allowed");
                        return false;
                    }
                    break;

                case enInputType.LettersOnly:
                    if (!txt.Text.All(char.IsLetter))
                    {
                        errorProvider.SetError(txt, "Only letters are allowed");
                        return false;
                    }
                    break;
            }

            return true;
        }
        // فاليديشن للـ Password + ConfirmPassword
        public static bool ValidatePassword(TextBox txtPassword, TextBox txtConfirmPassword, ErrorProvider errorProvider)
        {
            errorProvider.SetError(txtPassword, "");
            errorProvider.SetError(txtConfirmPassword, "");

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required");
                isValid = false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match");
                isValid = false;
            }

            return isValid;
        }
    }




    }

