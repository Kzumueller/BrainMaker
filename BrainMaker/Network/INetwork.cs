﻿using BrainMaker.Neuron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainMaker.Network
{
    public interface INetwork<Number>
    {
        List<INeuron<Number>> Neurons { get; set; }

        List<Number> Run(List<Number> vector);
    }
}
