using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.LearningStrategy.Hebb
{
    public class FloatHebb : LearningStrategy<double>
    {
        public override void AdjustWeight(double expected, double actual)
        {
            Dendrite.Weight += Proportionality * expected * Dendrite.Input;
        }
    }
}
