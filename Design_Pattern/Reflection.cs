using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern
{
    using System;

    /// <summary>
    /// Reflection class
    /// </summary>
    public class Reflection
    {
        /// <summary>
        /// ReflectionTest as a function
        /// </summary>
        public static void ReflectionTest()
        {
            int integer = 32;
            ////Check the type of input for reflection
            Type type = integer.GetType();
            Console.WriteLine(type);
        }
    }
}
