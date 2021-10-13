using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day16_17_Algorithm_Assignments
{
    public class Message_Demonstration
    {
        public static string Regex_Name = "^[A-Z]{1}[a-z]+$";
        public static string Regex_FullName = "^([A-Z]{1}[a-zA-Z]*[ ])?[A-Z]{1}[a-zA-Z]+[ ][A-Z]{1}[a-zA-Z]+$";
        public static string Regex_MobileNumber = "^[0-9]{1,4}[-][0-9]{10}$";
        public static string Regex_Date = "^[0-9]{2}[/][0-9]{2}[/][0-9]{4}$";
        public bool ValidateName(string name) //Method for checking name
        {
            return Regex.IsMatch(name, Regex_Name);
        }
        public bool ValidateFullName(string fullname) //Method for checking fullname
        {
            return Regex.IsMatch(fullname, Regex_FullName);
        }
        public bool ValidatePhoneNumber(string phonenumber) //Method for checking phonenumber
        {
            return Regex.IsMatch(phonenumber, Regex_MobileNumber);
        }
        public bool ValidateDate(string date) //Method for checking date
        {
            return Regex.IsMatch(date, Regex_Date);
        }
        
    }
}
