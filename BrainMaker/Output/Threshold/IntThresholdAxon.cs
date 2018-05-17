using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Output.Threshold
{
    class IntThresholdAxon : Axon<int>
    {
        public override int CalculateOutput()
        {
            if (Threshold <= Activity.Calculate())
            {
                return Activity.Maximum;
            }

            return Activity.Minimum;
        }
    }
}
