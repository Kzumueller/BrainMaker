using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainMaker.Input;

namespace BrainMaker.LearningStrategy
{
    public abstract class LearningStrategy<Number> : ILearningStrategy<Number>
    {
        public IDendrite<Number> Dendrite { get; set; }

        public Number Proportionality { get; set; }

        public abstract void AdjustWeight(Number expected);
    }
}
