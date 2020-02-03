

namespace FellowshipChaitanya.Design_Pattern.BehavioralDesignPattern.VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ItemElement as an interface
    /// </summary>
    internal interface ItemElement
    {
        /// <summary>
        /// Function to accept the visitor
        /// </summary>
        /// <param name="visitor">visitor as a parameter</param>
        /// <returns>returns integer</returns>
        int Accept(IShopingCartVisitor visitor);
    }
}
