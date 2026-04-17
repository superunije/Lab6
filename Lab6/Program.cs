using System;
// добавить смысл
// раскидать по файлам классы
class Logic
{
    protected bool fstBool;
    protected bool sndBool;

    public Logic(bool a, bool b)
    {
        fstBool = a;
        sndBool = b;
    }

    public Logic(Logic copy)
    {
        fstBool = copy.fstBool;
        sndBool = copy.sndBool;
    }

    public bool Equivalence()
    {
        return fstBool == sndBool;
    }

    public override string ToString()
    {
        return "A = " + fstBool + ", B = " + sndBool;
    }
}

class LogicExtended : Logic
{
    private string? _name;

    public LogicExtended(bool a, bool b, string? name) : base(a, b)
    {
        _name = name;
    }

    public LogicExtended(LogicExtended other) : base(other)
    {
        _name = other._name;
    }

    public void Invert()
    {
        fstBool = !fstBool;
        sndBool = !sndBool;
    }

    public bool IsBothTrue()
    {
        return fstBool && sndBool;
    }

    public void SetValues(bool a, bool b)
    {
        fstBool = a;
        sndBool = b;
    }

    public override string ToString()
    {
        return base.ToString() + ", Name = " + _name;
    }
}

class Program
{
    static bool InputBool(string message)
    {
        while (true)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (input == "true")
                return true;
            if (input == "false")
                return false;

            Console.WriteLine("Ошибка ввода! Введите true или false.");
        }
    }

    static void Main(string[] _)
    {
        Console.WriteLine("Ввод логических значений(true/false)");
        bool a = InputBool("Введите A: ");
        bool b = InputBool("Введите B: ");

        var obj = new Logic(a, b);
        var objCopy = new Logic(obj);

        Console.WriteLine("\nБазовый класс:");
        Console.WriteLine(obj.ToString());
        Console.WriteLine("Эквиваленция: " + obj.Equivalence());

        Console.WriteLine("\nКопия:");
        Console.WriteLine(objCopy.ToString());

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