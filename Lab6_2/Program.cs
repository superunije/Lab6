using System;
public class Time
{
    public const byte MAX_HOURS = 23;
    public const byte MAX_MINUTES = 59;

    private readonly byte m_hours;
    private readonly byte m_minutes;

    public Time(byte h, byte m)
    {
        m_hours = h;
        m_minutes = m;
    }

    public Time(uint totalMinutes)
    {
        totalMinutes = totalMinutes % (24 * 60);

        m_hours = (byte)(totalMinutes / 60);
        m_minutes = (byte)(totalMinutes % 60);
    }

    public Time(Time copy) : this(copy.Hours, copy.Minutes) { }

    public byte Hours
    {
        get { return m_hours; }
    }
    public byte Minutes
    {
        get { return m_minutes; }
    }
    public uint TotalMinutes
    {
        get { return (uint)m_hours * 60 + m_minutes; }
    }

    public override string ToString()
    {
        return $"{Hours:D2}:{Minutes:D2}";
    }

    public static Time operator -(Time left, Time right)
    {
        var hours = left.Hours - right.Hours;
        var minutes = left.Minutes - right.Minutes;
        if (minutes < 0)
        {
            minutes += 60;
            hours--;
        }

        if (hours < 0) hours += 24;

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

class Program
{
    static byte InputByte(string msg, int max)
    {
        while (true)
        {
            Console.Write(msg);
            var s = Console.ReadLine();
            
            if (byte.TryParse(s, out var value) && value < max)
                return value;

            Console.WriteLine("Ошибка ввода!");
        }
    }

    static void Main()
    {
        byte h1 = InputByte("Часы 1: ", 24);
        byte m1 = InputByte("Минуты 1: ", 60);

        byte h2 = InputByte("Часы 2: ", 24);
        byte m2 = InputByte("Минуты 2: ", 60);

        var t1 = new Time(h1, m1);
        var t2 = new Time(h2, m2);

        var result = t1 - t2;

        Console.WriteLine("Результат: " + result);
    }
}