using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Input.Linear
{
   public class FloatLinearDendrite : Dendrite<double>
    {
        public override double CalculateEffective()
        {
            return Input * Weight;
        }
    }
}
