
// ******************************************************************************
//  <copyright file="AddressBookUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Addrers.cs
//  
//     Purpose: To create all the Function related to AddressBook
//     @author  Chaitanya Vaidya
//     @version 1.0
//     @since   25-01-2020
//  </copyright>
//  <creator name="Chaitanya Vaidya"/>
// ******************************************************************************

namespace FellowshipChaitanya.Object_Oriented_Programs.AddressBook
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;




    public class AddressBookUtility
    {
        static String regex = @"^9\d{9}$";
        static String nameregex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
        static Boolean result;
        //giving path of AddressBOOk.json file
        static string  path = @"C:\Users\admin\source\repos\FellowshipChaitanya\FellowshipChaitanya\Object_Oriented_Programs\AddressBook\AddressBook.json";
        /// <summary>
        /// Description:display()
        ///Puro/*pse: Displays the details of AddressBook.json File
        /// </summary>
        public static void Display()
        {
            try
            {
                var json = File.ReadAllText(path);//Opens a file, reads all text in the file 
                var jObject = JObject.Parse(json);//A jObject populated from the string that contains JSON
                Console.WriteLine("First Name\t Last Name  \tAddress  \tCity  \tState  \tZip  \tMobile");
                foreach (var details in jObject["AddressBook"]) // this for loop iterate through elements
                {
                    Console.WriteLine(details["firstName"] + "\t" + details["lastName"] + "\t" + details["address"] + "\t" + details["city"] + "\t" + details["state"] + "\t" + details["zip"] + "\t" + details["mobile"]);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddInfo()
        {
            try
            {
                label1: Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                result = Regex.IsMatch(firstName, nameregex);
                if (result == false)
                {
                    Console.WriteLine("Invalid Input");
                    goto label1;
                }

                label2: Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                result = Regex.IsMatch(lastName, nameregex);
                if (result == false)
                {
                    Console.WriteLine("Invalid Input");
                    goto label2;
                }
                label3: Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                result = Regex.IsMatch(address, nameregex);
                if (result == false)
                {
                    goto label3;
                }

                label4: Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                result = Regex.IsMatch(city, nameregex);
                if (result == false)
                {
                    goto label4;
                }

                label5: Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                result = Regex.IsMatch(state, nameregex);
                if (result == false)
                {
                    goto label5;
                }
                label6: Console.WriteLine("Enter Zip code");
                int zip = Convert.ToInt32(Console.ReadLine());
                result = Regex.IsMatch(city, nameregex);
                if (result == false)
                {
                    goto label6;
                }
                label7: Console.WriteLine("Enter 10 Digit Mobile Number");
                String mobile = Console.ReadLine();
                result = Regex.IsMatch(mobile, regex);
                if (result == false)
                {
                    goto label7;
                }
                var newPerson = "{'firstName': '" + firstName + "' ,'lastName':'" + lastName + "','address':'" + address + "','city':'" + city + "' ,'state':'" + state + "','zip':" + zip + ",'mobile':" + mobile + "}";


                var json = File.ReadAllText(path);
                var jsonObj = JObject.Parse(json);
                var personArrary = jsonObj.GetValue("AddressBook") as JArray;
                var newMember = JObject.Parse(newPerson);
                personArrary.Add(newMember);
                jsonObj["AddressBook"] = personArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
                Display();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
     

        }
    }
}
