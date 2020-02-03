﻿//----------------------------------------------------
// <copyright file="ComputerDisplay.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace FellowshipChaitanya.DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ComputerDisplay implements interface IObserver
    /// </summary>
    public class ComputerDisplay : IObserver
    {
        /// <summary>
        /// WeatherStation as a field
        /// </summary>
        private WheatherStation wheatherStation;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerDisplay"/> class.
        /// </summary>
        /// <param name="wheatherStation">weatherStation as a parameter</param>
        public ComputerDisplay(WheatherStation wheatherStation)
        {
            this.wheatherStation = wheatherStation;
        }

        /// <summary>
        /// Function to update data
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Computer displays temperature as " + this.wheatherStation.GetTemperature());
        }
    }
}
