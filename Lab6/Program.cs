using System;
// добавить смысл

namespace Lab6
{
    internal class Program
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
}