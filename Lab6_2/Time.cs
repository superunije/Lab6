using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class Time
    {
        private readonly byte hours;
        private readonly byte minutes;

        public Time(byte h, byte m)
        {
            if (h >= 24)
            {
                h = (byte)(h % 24);
            }
            if (m >= 60)
            {
                h += (byte)(m / 60);
                m = (byte)(m % 60);
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
            get 
            { 
                return hours; 
            }
        }
        public byte Minutes
        {
            get 
            { 
                return minutes; 
            }
        }
        public uint TotalMinutes
        {
            get 
            { 
                return (uint)hours * 60 + minutes; 
            }
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}";
        }

        public static Time operator -(Time left, Time right)
        {
            int hours = left.Hours - right.Hours;
            int minutes = left.Minutes - right.Minutes;
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
