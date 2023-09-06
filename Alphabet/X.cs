using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class X : Letter
    {
        string[] setup = { "Big Line", "Big Line" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'X';

        public X()
        {
        }
    }
}
