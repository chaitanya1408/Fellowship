// ******************************************************************************
//  <copyright file="AddressBook.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution: AddressBook.cs
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
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// AddressBook as a class
    /// </summary>
    class AddressBook
    {
            /// <summary>
            /// AddressBookOperartions method helps to take input from a user for which operation have to perform on the AddressBook
            /// And calling appropriate method according to choice
            /// </summary>
        public static void AddressBookOperations()
        {
            Boolean flag = true;
            while (flag)//Iteratively show the Operations
            {
                Console.WriteLine("");
                Console.WriteLine("!!!Address Book!!!");
                Console.WriteLine("1. To view all person's info:");
                Console.WriteLine("2. To create new Persons info:");
                /*Console.WriteLine("3. To edit Existing persons info: ");
                Console.WriteLine("4. To delete Persons info:");
                Console.WriteLine("5. To sort persons info by name:");
                Console.WriteLine("6. To sort Persons info by zip:");*/
                Console.WriteLine("3. Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter Choice:");//asking for opeation choice
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddressBookUtility.Display();
                            break;
                        case 2:
                            AddressBookUtility.AddInfo();
                            break;
                        case 3:
                            Console.WriteLine("Exited From Address Book");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in Address Book?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                AddressBook.AddressBookOperations();
                            else
                                flag = false;
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
