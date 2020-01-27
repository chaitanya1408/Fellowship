namespace FellowshipChaitanya.Object_Oriented_Programs.Stock_Account_Management
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    public class StockAccountManagementUtility
    {
        static string path = @"C:\Users\admin\source\repos\FellowshipChaitanya\FellowshipChaitanya\Object_Oriented_Programs\Stock_Account_Management\StockAccountManagement.json";
        public static void Display()
        {
            var json = File.ReadAllText(path);//Opens a file, reads all text in the file 
            var jObject = JObject.Parse(json);//A jObject populated from the string that contains JSON
            Console.WriteLine("Stock Name\t Number Of shares  \tShare Prise ");
            foreach (var details in jObject["Stock"]) // this for loop iterate through elements
            {
                Console.WriteLine(details["stockName"] + "\t" + details["numberOfShares"] + "\t" + details["sharePrise"]);
            }
        }
        public static void AddStock()
        {
            Console.WriteLine("Enter Stock Name");
            String stockName = Console.ReadLine();
            Console.WriteLine("Enter number of shares");
            int numberOfShares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Share Prise");
            int sharePrise = Convert.ToInt32(Console.ReadLine());

            var newStock = "{'stockName': '" + stockName + "' ,'numberOfShares':" + numberOfShares + ",'sharePrise':" + sharePrise + "}";
           
            try
            {
                var json = File.ReadAllText(path);
                var jsonObj = JObject.Parse(json);
                var stockArrary = jsonObj.GetValue("Stock") as JArray;
                var newStockInfo = JObject.Parse(newStock);
                stockArrary.Add(newStockInfo);
                jsonObj["Stock"] = stockArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
                Display();
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}
