﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class M : Letter
    {
        string[] setup = { "Little Line", "Big Line", "Little Line", "Big Line" };

        public override List<string> Build => new List<string>(this.setup);

        public override char letter => 'M';

        public M()
        {
        }
    }
}
