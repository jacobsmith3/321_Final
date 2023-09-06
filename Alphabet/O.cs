using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class O : Letter
    {
        string[] setup = { "Big Curve", "Big Curve" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'O';

        public O()
        {
        }
    }
}