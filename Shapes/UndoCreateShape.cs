using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// undo the creation of a shape.
    /// </summary>
    public class UndoCreateShape : UndoAction
    {
        private shapehelper Undo;

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoCreateShape"/> class.
        /// </summary>
        /// <param name="undo"></param>
        public UndoCreateShape(shapehelper undo)
        {
            this.Undo = undo;
        }

        /// <summary>
        /// gets the shapes that must be removes.
        /// </summary>
        /// <returns></returns>
        public shapehelper Getshape()
        {
            return this.Undo;
        }

        /// <summary>
        /// executes the deletion of a shape.
        /// </summary>
        /// <param name="change"></param>
        public void Execute(ShapeList change)
        {
            change.RemoveShape(this.Undo);
        }
    }
}
