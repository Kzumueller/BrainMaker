using BrainMaker.Input;
using BrainMaker.LearningStrategy;
using BrainMaker.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Neuron
{
    public interface INeuron<Number>
    {
        List<IDendrite<Number>> Dendrites { get; set; }

        IAxon<Number> Axon { get; set; }

        ILearningStrategy<Number> LearningStrategy { get; set; }
    }
}
