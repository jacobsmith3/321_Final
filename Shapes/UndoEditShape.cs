using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// undoes an edit to a shape.
    /// </summary>
    public class UndoEditShape : UndoAction
    {
        private shapehelper Undo;
        private shapehelper Compare;

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoEditShape"/> class.
        /// </summary>
        /// <param name="undo"></param>
        /// <param name="comp"></param>
        public UndoEditShape(shapehelper undo, shapehelper comp)
        {
            this.Undo = undo;
            this.Compare = comp;
        }

        /// <summary>
        /// gets the shape.
        /// </summary>
        /// <returns></returns>
        public shapehelper Getshape()
        {
            return this.Undo;
        }

        /// <summary>
        /// executes the shape so it goes back to what it was.
        /// </summary>
        /// <param name="change"></param>
        public void Execute(ShapeList change)
        {
            foreach (var shape in change.getshapes().ToList<shapehelper>())
            {
                if (this.Compare == shape)
                {
                    int index = change.getshapes().IndexOf(shape);
                    change.Undoeditshape(index, this.Undo.shapes, this.Undo.Clr, this.Undo.Texture);
                }
            }
        }
    }
}
