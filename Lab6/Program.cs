using System;

class Logic
{
    protected bool A;
    protected bool B;

    public Logic(bool a, bool b)
    {
        A = a;
        B = b;
    }

    public Logic(Logic other)
    {
        A = other.A;
        B = other.B;
    }

    public bool Equivalence()
    {
        return A == B;
    }

    public override string ToString()
    {
        return "A = " + A + ", B = " + B;
    }
}

class LogicExtended : Logic
{
    private string? m_name;

    public LogicExtended(bool a, bool b, string? name)
        : base(a, b)
    {
        m_name = name;
    }

    public LogicExtended(LogicExtended other)
        : base(other)
    {
        m_name = other.m_name;
    }

    public void Invert()
    {
        A = !A;
        B = !B;
    }

    public bool IsBothTrue()
    {
        return A && B;
    }

    public void SetValues(bool a, bool b)
    {
        A = a;
        B = b;
    }

    public override string ToString()
    {
        return base.ToString() + ", Name = " + m_name;
    }
}



class Program
{
    static bool InputBool(string message)
    {
        while (true)
        {
            Console.Write(message + " (true/false): ");
            var input = Console.ReadLine();

            if (input == "true")
                return true;
            if (input == "false")
                return false;

            Console.WriteLine("Ошибка ввода! Введите true или false.");
        }
    }

    static void Main(string[] args)
    {
        bool a = InputBool("Введите A");
        bool b = InputBool("Введите B");

        var obj1 = new Logic(a, b);
        var obj2 = new Logic(obj1);

        Console.WriteLine("\nБазовый класс:");
        Console.WriteLine(obj1.ToString());
        Console.WriteLine("Эквиваленция: " + obj1.Equivalence());

        Console.WriteLine("\nКопия:");
        Console.WriteLine(obj2.ToString());

        Console.Write("\nВведите имя: ");
        var name = Console.ReadLine();

        var ext = new LogicExtended(a, b, name);
        var extCopy = new LogicExtended(ext);

        Console.WriteLine("\nДочерний класс:");
        Console.WriteLine(ext.ToString());

        Console.WriteLine("Оба true? " + ext.IsBothTrue());

        ext.Invert();
        Console.WriteLine("После инверсии:");
        Console.WriteLine(ext.ToString());

        Console.WriteLine("\nКопия дочернего:");
        Console.WriteLine(extCopy.ToString());
    }
}