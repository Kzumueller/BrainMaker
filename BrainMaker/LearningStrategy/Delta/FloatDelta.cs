using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.LearningStrategy.Delta
{
    public class FloatDelta : LearningStrategy<double>
    {
        public override void AdjustWeight(double expected, double actual)
        {
            Dendrite.Weight += Proportionality * (actual - expected) * Dendrite.Input;
        }
    }
}
