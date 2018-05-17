﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Input
{
    class FloatDendrite : Dendrite<double>
    {
        public override double CalculateEffective()
        {
            return Input * Weight;
        }
    }
}