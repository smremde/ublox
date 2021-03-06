﻿using BinarySerialization;
using ublox.Core.Data;
using ublox.Core.Messages.Enums;

namespace ublox.Core.Messages
{
    public class CfgTp5 : PacketPayload
    {
        private const byte DefaultVersion = 1;

        public CfgTp5()
        {
            Version = DefaultVersion;
        }

        [FieldOrder(0)]
        public Timepulse Timepulse { get; set; }

        [FieldOrder(1)]
        public byte Version { get; set; }

        [FieldOrder(2)]
        public byte Reserved { get; set; }

        [FieldOrder(3)]
        public SignedNanosecond2 AntennaDelay { get; set; }

        [FieldOrder(4)]
        public SignedNanosecond2 RfGroupDelay { get; set; }

        [FieldOrder(5)]
        public uint FrequencyPeriod { get; set; }
        
        [FieldOrder(6)]
        public uint FrequencyPeriodLock { get; set; }

        [FieldOrder(7)]
        public uint PulseLengthRatio { get; set; }

        [FieldOrder(8)]
        public SignedNanosecond4 UserConfigurablePulseDelay { get; set; }

        [FieldOrder(9)]
        [SerializeWhen("Version", 0)]
        public TimepulseOptions Options { get; set; }

        [FieldOrder(10)]
        [SerializeWhen("Version", 1)]
        public TimepulseOptions OptionsExt { get; set; }
    }
}
