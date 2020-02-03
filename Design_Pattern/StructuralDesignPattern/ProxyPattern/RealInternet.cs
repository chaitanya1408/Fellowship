using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern.StructuralDesignPattern.ProxyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class RealInternet implements interface IInternet
    /// </summary>
    public class RealInternet : IInternet
    {
        /// <summary>
        /// implementing ConnectTo method from IInternet
        /// </summary>
        /// <param name="serverHost">serverHost as a parameter</param>
        public void ConnectTo(string serverHost)
        {
            Console.WriteLine("Connecting to " + serverHost);
        }
    }
}
