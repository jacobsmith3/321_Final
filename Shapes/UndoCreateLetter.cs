using Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// this class is used to undo the creation of a letter.
    /// </summary>
    public class UndoCreateLetter : UndoAction
    {
        private List<shapehelper> Undo = new List<shapehelper>();
        private char letter;

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoCreateLetter"/> class.
        /// </summary>
        /// <param name="ltr"></param>
        /// <param name="undo"></param>
        public UndoCreateLetter(char ltr, List<shapehelper> undo)
        {
            this.letter = ltr;
            this.Undo = undo;
        }

        /// <summary>
        /// gets the list of shapes for the letter.
        /// </summary>
        /// <returns></returns>
        public List<shapehelper> Getshape()
        {
            return this.Undo;
        }

        /// <summary>
        /// executes the undoing of the create letter function.
        /// </summary>
        /// <param name="change"></param>
        public void Execute(ShapeList change)
        {
            var holder = change.getalpha();
            List<shapehelper> shapes = new List<shapehelper>();

            // removes the letter
            foreach (var letter in holder)
            {
                if (letter.Item2 == this.Undo && letter.Item1.letter == this.letter)
                {
                    int index = holder.IndexOf(letter);
                    change.UndoremoveLetter(index);
                    shapes = letter.Item2;
                    break;
                }
            }

            if (shapes == null)
            {
                return;
            }

            // gets adds the shapes used to create the letter.
            foreach (var shape in shapes)
            {
                change.AddshapebyItem(shape);
            }
        }
    }
}
