using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Introduction_To_Events.Program;

namespace Introduction_To_Events
{
    internal class Broadcaster
    {
        internal event PriceChangedHandler PriceChanged;
    }
}
