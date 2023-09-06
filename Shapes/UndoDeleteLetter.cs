using Alphabet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// undo the deletion of a letter.
    /// </summary>
    public class UndoDeleteLetter : UndoAction
    {
        private List<shapehelper> Undo = new List<shapehelper>();
        private Letter letter;

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoDeleteLetter"/> class.
        /// </summary>
        /// <param name="ltr"></param>
        /// <param name="undo"></param>
        public UndoDeleteLetter(Letter ltr, List<shapehelper> undo)
        {
            this.letter = ltr;
            this.Undo = undo;
        }

        /// <summary>
        /// gets the list of shapes used to create the letter.
        /// </summary>
        /// <returns></returns>
        public List<shapehelper> Getshape()
        {
            return this.Undo;
        }

        /// <summary>
        /// executes the deleted letter to bring it back.
        /// </summary>
        /// <param name="change"></param>
        public void Execute(ShapeList change)
        {
            change.AddletterbyItem(this.letter, this.Undo);
        }
    }
}
