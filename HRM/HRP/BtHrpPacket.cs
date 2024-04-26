﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGT.HRM.HRP
{
    public class BtHrpPacket : IHRMPacket
    {
        public int HeartRate { get; set; }
        public bool HasExpendedEnergy { get; set; }
        public int ExpendedEnergy { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        public int RRInterval { get; set; } // Added for storing RR intervals

        public override string ToString()
        {
            // Create a string representation of the RR intervals list
            return $"[ HeartRate = {HeartRate}, HRV = {RRInterval} ]";
        }

    }
}
