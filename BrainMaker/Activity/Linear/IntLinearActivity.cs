using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Activity.Linear
{
   public class IntLinearActivity : Activity<int>
    {
        public override int Calculate()
        {
            return ScalingFactor * Dendrite.CalculateEffective();
        }
    }
}
