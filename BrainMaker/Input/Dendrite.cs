using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Input
{
    abstract class Dendrite<Number> : IDendrite<Number> where Number : struct
    {
        public Number Input { get; set; }

        public Number Weight { get; set; }

        public abstract Number CalculateEffective();
    }
}
