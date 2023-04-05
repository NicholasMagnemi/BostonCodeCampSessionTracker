using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SemesterProjectTest
{
    public class BackendInputValidation
    {
        public BackendInputValidation() { }

        public bool validateAsDouble(string s)
        {
            try
            {
                Convert.ToDouble(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool validateAsInt(string s)
        {
            try
            {
                Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool validateAsStringForNoNumbers(string s)
        {
            for (int count = 0; count <= s.Length - 1; count++)
            {
                if (Char.IsNumber(s[count]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool validateStringForNoLetters(string s)
        {
            for (int count = 0; count <= s.Length - 1; count++)
            {
                if (Char.IsLetter(s[count]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool validateStringLengthAsPhoneNumber(string s)
        {
            if (s.Length < 25)
            {
                return true;
            }
            return false;
        }

        public bool validateStringLengthForTextBox(string s)
        {
            if (s.Length <= 280)
            {
                return true;
            }
            return false;
        }

        public bool validateStringAsPhoneNumber(string s)
        {
            if (s.Length <= 12)
            {
                return true;
            }
            return false;

        }

        public bool validateStringAsEmail(string s)
        {
            Regex ValidEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            return ValidEmail.IsMatch(s);
        }
    }
}