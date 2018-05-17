using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Output.Fermi
{
    public class FloatFermiAxon : Axon<double>
    {
        public override double CalculateOutput()
        {
            var range = Activity.Maximum - Activity.Minimum;

            return Activity.Minimum +
                range /
                (1 + Math.Exp(
                    -4 * Slope * (Activity.Calculate() - Threshold) / range
                    )
                 );
        }
    }
}
