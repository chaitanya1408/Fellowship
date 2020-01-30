
namespace FellowshipChaitanya.Object_Oriented_Programs.Stock_Account_Management
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StockAccountManagemennt
    {
        public static void StockAccountManagementOperations()
        {
            try
            {
                Boolean flag = true;
                while (flag)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Stock Account Management Program!!!");
                    Console.WriteLine("1. View All the Stocks and their value");
                    Console.WriteLine("2. Add the new company");
                    Console.WriteLine("3. Stock Value");
                    Console.WriteLine("4. Total stock value");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("");
                    Console.WriteLine("Enter Your Choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            StockAccountManagementUtility.Display();
                            break;
                        case 2:
                            StockAccountManagementUtility.AddStock();
                            break;
                        case 3:
                            StockAccountManagementUtility.StockValue();
                            break;
                        case 4:
                            StockAccountManagementUtility.TotalStockValue();
                            break;
                        case 5:
                            Console.WriteLine("Exit from Stock Account Management");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in Stock Account Management?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                StockAccountManagemennt.StockAccountManagementOperations();
                            else
                                flag = false;
                            break;


                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
