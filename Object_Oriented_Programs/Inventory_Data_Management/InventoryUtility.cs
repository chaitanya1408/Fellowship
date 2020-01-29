// ******************************************************************************
//  <copyright file="InventoryDataManagement.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution: InventoryUtility.cs
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
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    public class InventoryUtility
    {
        static string path = @"C:\Users\admin\source\repos\FellowshipChaitanya\FellowshipChaitanya\Object_Oriented_Programs\Inventory_Data_Management\InventoryDataManagement.json";
        public InventoryList List()
        {            
            //// read file into a string and deserialize JSON to a type
            InventoryList inventory = JsonConvert.DeserializeObject<InventoryList>(File.ReadAllText(path));
            //// deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                InventoryList list = (InventoryList)serializer.Deserialize(file, typeof(InventoryList));
                return list;
            }
        }
        /// <summary>
        /// Displays this instance.
        /// Description:display()
        ///Puropse: Displays the detail information of inventory the product name,stock,price
        /// </summary>
        public void Display()
        {
            var list = this.List();
                Console.WriteLine("\t\t Rice \n Name \t Total stock \t Price per kg");
                int totalRice = 0;
                foreach (var item in list.Rice)//it iterates throgh the rice array 
                {
                    totalRice += item.Weight;
                    Console.WriteLine(item.Name + "\t\t" + item.Weight + "kg \t\t" + item.PricePerKg);
                }
                Console.Write("---------------------------------\nTotal   \t" + totalRice);

                Console.WriteLine("\n\n\t\t Pulses \n Name \t   Total stock \t Price per kg");
                int totalPulse = 0;
                foreach (var item in list.Pulses)// it iterates through the pulse array
                {
                    totalPulse += item.Weight;
                    Console.WriteLine(item.Name + "\t" + item.Weight + "kg \t\t" + item.PricePerKg);
                }
                Console.Write("---------------------------------\nTotal   \t" + totalPulse);

                Console.WriteLine("\n\n\t\t Wheat \n Name \t   Total stock \t Price per kg");
                int totalWheat = 0;
                foreach (var item in list.Wheats)// it iterates through pulse
                {
                    totalWheat += item.Weight;
                    Console.WriteLine(item.Name + "\t\t" + item.Weight + "kg \t\t" + item.PricePerKg);
                }
                Console.Write("---------------------------------\nTotal   \t" + totalWheat);            
        }
        /// <summary>
        /// Adds the item.
        /// Description:Additem(String item)
        /// this method is to add the new item details
        /// </summary>
        /// <param name="item">The item.</param>

        public static void AddItem(string item)
        {
            
            Console.WriteLine("Enter " + item + " name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter " + item + " weight");
            var weight = Console.ReadLine();
            Console.WriteLine("Price per 1 kg of " + item);
            var pricePerKg = Console.ReadLine();
            var newRice = "{'name': '" + name + "' ,'weight':" + weight + ",'pricePerKg':" + pricePerKg + "}";
            try
            {
                var json = File.ReadAllText(path);
                var jsonObj = JObject.Parse(json);
                var riceArrary = jsonObj.GetValue(item) as JArray;
                var newInventory = JObject.Parse(newRice);
                riceArrary.Add(newInventory);
                jsonObj[item] = riceArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Deletes the item.
        /// Description:Deleteitem(String item)
        /// in thsi the userwill provide the item which we want to delete
        /// the type of item which we want to delet
        /// </summary>
        /// <param name="item">The item.</param>
        public static void DeleteItem(string item)
        {
            var json = File.ReadAllText(path);            
            Console.WriteLine("Enter the " + item + " type you want to delete");
            string itemType = Console.ReadLine();
            var jObject = JObject.Parse(json);
            JArray itemArrary = (JArray)jObject[item];
            bool found = false;
                foreach (var x in jObject[item])
                {
                    if (x["name"] + string.Empty == itemType)
                    {
                        var itemToDelete = itemArrary.FirstOrDefault(obj => obj["name"].Value<string>() == itemType);
                        itemArrary.Remove(itemToDelete);
                        jObject[item] = itemArrary;
                        string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(path, output);
                        found = true;
                        return;
                    }                                        
                }
            if (!found)
            {
                Console.WriteLine("File not found");
            }
        }
        /// <summary>
        /// Edits the item.
        /// Description:EditItem(String item)
        /// in this we edit the items properties like weight price
        /// </summary>
        /// <param name="item">The item.</param>
        public static void EditItem(string item)
        {
            var json = File.ReadAllText(path);
            Console.WriteLine("Enter the " + item +" type you want to edit");
            string itemType = Console.ReadLine();
            var jObject = JObject.Parse(json);
            JArray itemArrary = (JArray)jObject[item];
            bool found = false;
            foreach (var updateItems in itemArrary.Where(obj => obj["name"].Value<string>() == itemType))
            {
                Console.WriteLine("Enter new name");
                updateItems["name"] = Console.ReadLine();
                Console.WriteLine("Enter new weight");
                updateItems["weight"] = Console.ReadLine();
                Console.WriteLine("Enter new price per kg");
                updateItems["pricePerKg"] = Console.ReadLine();
                found = true;
            }
            jObject[item] = itemArrary;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);            
            if (!found)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
