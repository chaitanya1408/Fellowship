// ******************************************************************************
//  <copyright file="InventoryDataManagement.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution: InventoryDataManagement.cs
//  
//     Purpose: To call all the Function related to InventoryManagement
//     @author  Chaitanya Vaidya
//     @version 1.0
//     @since   27-01-2020
//  </copyright>
//  <creator name="Chaitanya Vaidya"/>
// ******************************************************************************
namespace FellowshipChaitanya.Object_Oriented_Programs.Inventory_Data_Management
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Inventory_Data_Management;
    /// <summary>
    /// InventoryDataManagement as a class
    /// </summary>
    public class InventoryDataManagement
    {
        /// <summary>
        /// Inventories the data management function.
        /// purspose to call all the operation according to user
        /// </summary>
        public static void InventoryDataManagementFunction()
        {
            ManagerUtility utility = new ManagerUtility();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("");
                Console.WriteLine("Inventory Data Managment Program!!!");
                Console.WriteLine("1. View All The data From Inventory.");
                Console.WriteLine("2. Add Item.");
                Console.WriteLine("3. Delete Item.");
                Console.WriteLine("4. Edit Item.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("");
                Console.WriteLine("Enter Your choice");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            utility.DisplayInventory();
                            break;
                        case 2:
                            ManagerUtility.AddInventory();
                            break;
                        case 3:
                            ManagerUtility.DeleteInventory();
                            break;
                        case 4:
                            ManagerUtility.EditInventory();
                            break;
                        case 5:
                            Console.WriteLine("Exit from Inventory Data Management");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in ?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                InventoryDataManagement.InventoryDataManagementFunction();
                            else
                                flag = false;
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
