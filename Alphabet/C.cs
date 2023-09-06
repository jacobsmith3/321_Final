using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class C : Letter
    {
        string[] setup = { "Big Curve" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'C';

        public C()
        {
        }
    }
}
