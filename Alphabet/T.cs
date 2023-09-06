using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class T : Letter
    {
        string[] setup = { "Big Line", "Big Line" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'T';

        public T()
        {
        }
    }
}
