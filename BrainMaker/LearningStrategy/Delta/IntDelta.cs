using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.LearningStrategy.Delta
{
    public class IntDelta : LearningStrategy<int>
    {
        public override void AdjustWeight(int expected, int actual)
        {
            Dendrite.Weight += Proportionality * (actual - expected) * Dendrite.Input;
        }
    }
}
