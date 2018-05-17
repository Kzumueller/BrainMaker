using BrainMaker.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Training
{
    public interface ITrainingSession<Number>
    {
        INetwork<Number> Network { get; set; }

        Dictionary<List<Number>, List<Number>> PatternMapping { get; set; }

        Number Tolerance { get; set; }

        void Train();
    }
}
