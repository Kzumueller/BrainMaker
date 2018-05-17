using BrainMaker.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.LearningStrategy
{
    public interface ILearningStrategy<Number>
    {
        IDendrite<Number> Dendrite { get; set; }

        Number Proportionality { get; set; }

        void AdjustWeight(Number expected, Number actual);
    }
}
