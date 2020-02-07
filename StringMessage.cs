
namespace FellowshipChaitanya
{
    // 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    public class StringMessage
    {
        /// <summary>
        /// Strings the message input.
        /// </summary>
        public static void StringMessageInput()
        {
            // 
            String name = null, phoneNumber = null, dateString = null;


            Console.WriteLine("Kindly enter following details:");

            String regex = @"^(?<countryCode>[\+][1-9]{1}[0-9]{0,2}\s)?(?<areaCode>0?[1-9]\d{0,4})(?<number>\s[1-9][\d]{5,12})(?<extension>\sx\d{0,4})?$";
            String regName = "^[a-zA-z ]*$";
            String regDate = "^(1[0-2]|0[1-9])/(3[01]|[12][0-9]|0[1-9])/[0-9]{4}$";
            Boolean nameValid = false;
            Boolean mobileValid = false;
            Boolean dateValid = false;

            while (nameValid != true)
            {

                Console.WriteLine("Enter name: ");
                name = Utility.StringInput();
                nameValid = Regex.IsMatch(name, regName);

                if (nameValid == false)
                {
                    Console.WriteLine("\nEnter proper Name");

                }
            }

            while (mobileValid != true)
            {
                Console.WriteLine("Enter Phone Number: (Ex. 91 XXXXXXXXXX) ");
                phoneNumber = Utility.StringInput();

                mobileValid = Regex.IsMatch(phoneNumber, regex);
                if (mobileValid == false)
                {
                    Console.WriteLine("\nEnter proper Mobile number in 91 XXXXXXXXXX");
                }
            }

            while (dateValid != true)
            {
                Console.WriteLine("Enter date: (Ex. MM/DD/YYYY) ");
                dateString = Utility.StringInput();

                dateValid = Regex.IsMatch(dateString,regDate);

                if (dateValid == false)
                {
                    Console.WriteLine("\nEnter proper Date like MM/DD/YYYY");
                }
            }

            Console.WriteLine("Hello " + name + " in our system. Your contact nuber is: " + phoneNumber + ".\nPlease let us know in case of any clarification. \nThank you,\nBridge Labs\n" + dateString);
        }
    }
}
