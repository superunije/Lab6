using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class Time
    {
        public const byte MAX_HOURS = 24; 
        public const byte MAX_MINUTES = 60;

        private readonly byte hours;
        private readonly byte minutes;

        public Time(byte h, byte m)
        {
            if (h >= 24)
            {
                h = (byte) (h % MAX_HOURS);
            }
            if (m >= 60)
            {
                h += (byte)(m / MAX_MINUTES);
                m = (byte) (m % MAX_MINUTES);
            }
            hours = h;
            minutes = m;
        }

        public Time(uint totalMinutes)
        {
            totalMinutes = totalMinutes % (24 * 60);

            hours = (byte)(totalMinutes / 60);
            minutes = (byte)(totalMinutes % 60);
        }

        public Time(Time copy) : this(copy.Hours, copy.Minutes) { }

        public byte Hours
        {
            get { return hours; }
        }
        public byte Minutes
        {
            get { return minutes; }
        }
        public uint TotalMinutes
        {
            get { return (uint)hours * 60 + minutes; }
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}";
        }

        public static Time operator -(Time left, Time right) // code style
        {
            var hours = left.Hours - right.Hours;
            var minutes = left.Minutes - right.Minutes;
            if (minutes < 0)
            {
                minutes += 60;
                hours--;
            }

            if (hours < 0)
            {
                hours += 24;
            }

            return new((byte)hours, (byte)minutes);
        }

        public static Time operator +(uint minutes, Time right)
        {
            uint total = (right.TotalMinutes + minutes) % (24 * 60);
            return new Time(total);
        }

        public static Time operator +(Time left, uint minutes)
        {
            uint total = (left.TotalMinutes + minutes) % (24 * 60);
            return new Time(total);
        }

        public static Time operator +(Time left, Time right)
        {
            uint total = (left.TotalMinutes + right.TotalMinutes) % (24 * 60);
            return new Time(total);
        }

        public static implicit operator bool(Time origin)
        {
            return origin.Hours != 0 || origin.Minutes != 0;
        }
    }
}
