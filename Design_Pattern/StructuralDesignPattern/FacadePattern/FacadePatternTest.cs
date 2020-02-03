using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern.StructuralDesignPattern.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FacadePatternTest as a class 
    /// </summary>
    public class FacadePatternTest
    {
        /// <summary>
        /// Function to execute Facade Pattern
        /// </summary>
        public void FacadeTest()
        {
            ////Create instance of ShapeMaker
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }
}
