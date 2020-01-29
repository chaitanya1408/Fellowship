// ******************************************************************************
//  <copyright file="InventoryData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution: InventoryData.cs
//  
//     Purpose: To create all the Function related to DeckOfCards
//     @author  Chaitanya Vaidya
//     @version 1.0
//     @since   27-02-2020
//  </copyright>
//  <creator name="Chaitanya Vaidya"/>
// ******************************************************************************
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
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name of rice,wheat,pulses.
        /// </value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight of rice,wheat,pulses
        /// </value>
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg of whert pulses and rice.
        /// </value>
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
