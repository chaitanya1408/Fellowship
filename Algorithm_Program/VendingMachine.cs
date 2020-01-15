using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class VendingMachine
    {
        public static void vendingMachineInput()
        {
            Console.WriteLine("Enter the how much change do you want?");
            int change = Utility.IntegerInput();
            int[] notesarray = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Utility.vendingMachineCalculation(change, notesarray);
        }
    }
}
