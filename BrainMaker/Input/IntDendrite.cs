using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Input
{
   public class IntDendrite : Dendrite<int>
    {
        public override int CalculateEffective()
        {
            return Input * Weight;
        }
    }
}
