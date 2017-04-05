﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsThing.Paye
{
    /// <summary>
    /// What we need to calculate
    /// </summary>
    public enum CalculationType
    {
        /// <summary>
        /// We need to calculate the payout. We have the total salary.
        /// </summary>
        Payout,

        /// <summary>
        /// We need to calculate the total PAYE. We have the payout.
        /// </summary>
        Paye
    }
}
