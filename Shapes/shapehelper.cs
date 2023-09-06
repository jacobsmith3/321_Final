using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// thsi class allows the use of the Shape class.
    /// </summary>
    public class shapehelper : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="shapehelper"/> class.
        /// </summary>
        /// <param name="shp"></param>
        /// <param name="clr"></param>
        /// <param name="text"></param>
        public shapehelper(string shp, string clr, string text) : base(shp, clr, text)
        {

        }

        /// <summary>
        /// gets the shape at a given index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Shape getShape(int index)
        {
            return (Shape)this;
        }
    }
}
