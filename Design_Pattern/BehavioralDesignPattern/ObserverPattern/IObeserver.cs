
namespace FellowshipChaitanya.Design_Pattern.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IObserver as a interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Function to update data to observer
        /// </summary>
        void Update();
    }
}
