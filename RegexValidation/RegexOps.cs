using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation
{
    internal class RegexOps
    {
        //public static string RegexRule = "(^[A-Z][A-Za-z]{3,20})+( [A-Z]{1}[A-Za-z]{3,20})$"; //First_Last Name Validation

        // public static string RegexRule = "^([A-Za-z0-9]{3,20})([.][A-Za-z0-9]{1,10})*([@][A-Za-z]{2,5})+[.][A-Za-z]{2,3}([.][A-Za-z]{2,3})?$";//Validate Email_ID

        // public static string RegexRule = "^[1-9]{2} [6-9]{1}[0-9]{9}$";  // validate Mobile Number

        public static string RegexRule = "(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8}";
        //Validate password which has atleast one Uppercase char and atleast one number
        public bool ValidateUserName(string User_Pass)
        {
            {
                return Regex.IsMatch(User_Pass, RegexRule);

            }
        }
    }
}
