using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern.StructuralDesignPattern.ProxyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IInternet as an interface
    /// </summary>
    internal interface IInternet
    {
        /// <summary>
        /// Function ConnectTo for class which implement this
        /// </summary>
        /// <param name="serverHost">serverHost as a parameter</param>
        void ConnectTo(string serverHost);
    }
}
