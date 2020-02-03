using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern.StructuralDesignPattern.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Circle implements inteface IShape
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Function to draw circle
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }
}
