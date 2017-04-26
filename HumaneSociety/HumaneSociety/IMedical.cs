﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    interface IMedical
    {
        bool SpayedNeutered { get; set; }
        bool Shots { get; set; }

        void GetSpayedNeutered();
        void GetShots();
    }
}
