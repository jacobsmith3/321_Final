using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class R : Letter
    {
        string[] setup = { "Little Curve", "Big Line", "Little Line" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'R';

        public R()
        {
        }
    }
}
