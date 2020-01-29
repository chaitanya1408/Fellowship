// ******************************************************************************
//  <copyright file="InventoryDataManagement.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution: ManagerUtility.cs
//  
//     Purpose: To call all the Function related toinventory according to the Inventory Data
//     @author  Chaitanya Vaidya
//     @version 1.0
//     @since   27-01-2020
//  </copyright>
//  <creator name="Chaitanya Vaidya"/>
// ******************************************************************************
namespace FellowshipChaitanya.Object_Oriented_Programs.Inventory_Data_Management
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Inventory_Data_Management;
    public class ManagerUtility
    {
        InventoryUtility utility = new InventoryUtility();
        /// <summary>
        /// Adds the inventory.
        /// here user will select which item we want to add in the inventory
        /// </summary>
        public static void AddInventory()
        {            
            int choice;
            do
            {
                Console.WriteLine("1. Add rice inventory");
                Console.WriteLine("2. Add wheat inventory");
                Console.WriteLine("3. Add pulse inventory");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 3 || choice < 1);

            switch (choice)
            {
                case 1:
                    InventoryUtility.AddItem("Rice");
                    break;

                case 2:
                    InventoryUtility.AddItem("Wheats");
                    break;

                case 3:
                    InventoryUtility.AddItem("Pulses");
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Deletes the inventory.
        /// here user will decide which item they want to delet
        /// </summary>
        public static void DeleteInventory()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Delete rice inventory");
                Console.WriteLine("2. Delete wheat inventory");
                Console.WriteLine("3. Delete pulse inventory");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 3 || choice < 1);

            switch (choice)
            {
                case 1:
                    InventoryUtility.DeleteItem("Rice");
                    break;

                case 2:
                    InventoryUtility.DeleteItem("Wheats");
                    break;

                case 3:
                   InventoryUtility.DeleteItem("Pulses");
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Edits the inventory.
        /// </summary>
        public static  void EditInventory()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Edit rice inventory");
                Console.WriteLine("2. Edit wheat inventory");
                Console.WriteLine("3. Edit pulse inventory");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 3 || choice < 1);

            switch (choice)
            {
                case 1:
                    InventoryUtility.EditItem("Rice");
                    break;

                case 2:
                    InventoryUtility.EditItem("Wheats");
                    break;

                case 3:
                   InventoryUtility.EditItem("Pulses");
                    break;

                default:
                    break;
            }
        }

        public  void DisplayInventory()
        {
            utility.Display();
        }
    }
}
