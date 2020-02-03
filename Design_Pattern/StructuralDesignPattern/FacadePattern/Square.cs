using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern.StructuralDesignPattern.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Square implements inetrface IShape
    /// </summary>
    public class Square : IShape
    {
        /// <summary>
        /// Function to draw square
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
