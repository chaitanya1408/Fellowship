
namespace FellowshipChaitanya.Object_Oriented_Programs.Inventory_Data_Management
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InventoryData
    {
        private string name;
        private int weight;
        private int pricePerKg;

       public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public int PricePerKg
        {
            get { return this.pricePerKg; }
            set { this.pricePerKg = value; }
        }
    }

    public class InventoryList
    {
        public List<InventoryData> Rice { get; set; }
        public List <InventoryData> Pulses { get; set; }
        public List<InventoryData> Wheats { get; set; }
    }
}
