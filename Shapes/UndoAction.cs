using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// used as a class that will be inherited by other classes so the undo function can work.
    /// </summary>
    public class UndoAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UndoAction"/> class.
        /// </summary>
        public UndoAction() { }
    }
}
