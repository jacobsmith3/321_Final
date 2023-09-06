using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class D : Letter
    {
        string[] setup = { "Big Curve", "Big Line"};

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'D';

        public D()
        {
        }
    }
}
