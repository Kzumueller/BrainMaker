using BrainMaker.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Output
{
    public abstract class Axon<Number> : IAxon<Number>
    {
        public IActivity<Number> Activity { get; set; }

        public Number Threshold { get; set; }

        public Number Slope { get; set; }

        public abstract Number CalculateOutput();
    }
}
