using BrainMaker.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Output
{
    public interface IAxon<Number>
    {
        IActivity<Number> Activity { get; set; }

        Number Threshold { get; set; }

        Number Slope { get; set; }
    
        Number CalculateOutput();
    }
}
