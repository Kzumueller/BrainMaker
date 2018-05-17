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
    class Neuron<Number> : INeuron<Number>
    {
        public List<IDendrite<Number>> Dendrites { get; set; }

        public IAxon<Number> Axon { get; set; }

        public ILearningStrategy LearningStrategy { get; set; }
    }
}
