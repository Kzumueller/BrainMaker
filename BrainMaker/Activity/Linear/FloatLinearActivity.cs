using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Activity.Linear
{
    class FloatLinearActivity : Activity<double>
    {
        public override double Calculate()
        {
            return ScalingFactor * Dendrite.CalculateEffective();
        }
    }
}
