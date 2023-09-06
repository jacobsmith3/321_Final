using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class I : Letter
    {
        string[] setup = { "Big Line" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'I';

        public I()
        {
        }
    }
}
