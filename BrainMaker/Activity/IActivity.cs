using BrainMaker.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Activity
{
    public interface IActivity<Number>
    {
        IDendrite<Number> Dendrite { get; set; }

        Number ScalingFactor { get; set; }

        Number BaseValue { get; set; }

        Number Decrease { get; set; }

        Number Minimum { get; set; }

        Number Maximum { get; set; }

        Number Calculate();
    }
}
