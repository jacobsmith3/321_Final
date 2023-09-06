using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class S : Letter
    {
        string[] setup = { "Little Curve", "Little Line", "Little Curve" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'S';

        public S()
        {
        }
    }
}
