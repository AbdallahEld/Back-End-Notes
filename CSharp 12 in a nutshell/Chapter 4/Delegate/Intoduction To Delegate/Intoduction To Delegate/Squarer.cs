using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intoduction_To_Delegate
{
    internal class Squarer : ITransformer
    {
        public int Transform(int x) => x * x;
    }
}
