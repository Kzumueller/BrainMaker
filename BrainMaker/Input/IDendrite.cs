using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Input
{
    public interface IDendrite<Number>
    {
        Number Input { get; set; }

        Number Weight { get; set; }

        Number CalculateEffective();
    }
}
