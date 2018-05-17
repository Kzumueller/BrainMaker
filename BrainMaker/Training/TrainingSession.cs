using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainMaker.Network;

namespace BrainMaker.Training
{
    public abstract class TrainingSession<Number> : ITrainingSession<Number>
    {
        public INetwork<Number> Network { get; set; }

        public Dictionary<List<Number>, List<Number>> PatternMapping { get; set; }

        public Number Tolerance { get; set; }

        public abstract void Train();
    }
}
