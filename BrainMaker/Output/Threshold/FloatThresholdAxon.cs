using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Output.Threshold
{
    class FloatThresholdAxon : Axon<double>
    {
        public override double CalculateOutput()
        {
            if (Threshold <= Activity.Calculate())
            {
                return Activity.Maximum;
            }

            return Activity.Minimum;
        }
    }
}
