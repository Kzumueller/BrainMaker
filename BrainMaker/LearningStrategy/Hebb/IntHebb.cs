using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.LearningStrategy.Hebb
{
    public class IntHebb : LearningStrategy<int>
    {
        public override void AdjustWeight(int expected, int actual)
        {
            Dendrite.Weight += Proportionality * expected * Dendrite.Input;
        }
    }
}
