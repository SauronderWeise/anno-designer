﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FandomParser.Core.Presets.Models
{
    [DebuggerDisplay("{" + nameof(Value) + "} ({" + nameof(Unit) + "})")]
    [DataContract]
    public class MaintenanceInfo
    {
        [DataMember(Order = 0)]
        public double Value { get; set; }

        [DataMember(Order = 1)]
        public CostUnit Unit { get; set; }
    }
}
