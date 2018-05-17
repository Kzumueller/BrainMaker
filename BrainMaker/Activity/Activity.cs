using BrainMaker.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Activity
{
    abstract class Activity<Number> : IActivity<Number>
    {
        public IDendrite<Number> Dendrite { get; set; }

        public Number ScalingFactor { get; set; }

        public Number BaseValue { get; set; }

        public Number Decrease { get; set; }

        public Number Minimum { get; set; }

        public Number Maximum { get; set; }

        public abstract Number Calculate();
    }
}
