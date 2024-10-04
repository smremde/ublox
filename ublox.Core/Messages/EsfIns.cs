using BinarySerialization;
using ublox.Core.Data;
using ublox.Core.Messages.Enums;

namespace ublox.Core.Messages
{
    public class EsfIns : PacketPayload
    {
        [FieldOrder(0)]
        public byte Bitfield0 { get; set; }

        [FieldOrder(1)]
        [FieldLength(4)]
        public byte[] Reserved1 { get; set; }

        [FieldOrder(2)]
        public GpsTimeOfWeek iTOW { get; set; }

        [FieldOrder(3)]
        [FieldScale(1000)]
        [SerializeAs(SerializedType.Int4)]
        public float xAngRate { get; set; }

        [FieldOrder(4)]
        [FieldScale(1000)]
        [SerializeAs(SerializedType.Int4)]
        public float yAngRate { get; set; }

        [FieldOrder(5)]
        [FieldScale(1000)]
        [SerializeAs(SerializedType.Int4)]
        public float zAngRate { get; set; }

        [FieldOrder(6)]
        public int xAccel { get; set; }

        [FieldOrder(7)]
        public int yAccel { get; set; }

        [FieldOrder(8)]
        public int zAccel { get; set; }
    }
}
