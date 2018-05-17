using BrainMaker.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Output
{
    abstract class Axon<Number> : IAxon<Number>
    {
        public Number Threshold { get; set; }

        public IActivity<Number> Activity { get; set; }

        public abstract Number CalculateOutput();
    }
}
