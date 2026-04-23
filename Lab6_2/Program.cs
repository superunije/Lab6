using System;
// code style m_hours m_minutes
namespace Lab6_2
{
    class Program
    {
        static byte InputByte(string msg, int max) // code style
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
            Console.WriteLine("Введите время");
            byte h1 = InputByte("Часы 1: ", 256);
            byte m1 = InputByte("Минуты 1: ", 256);

            byte h2 = InputByte("Часы 2: ", 256);
            byte m2 = InputByte("Минуты 2: ", 256);

            var t1 = new Time(h1, m1);
            var t2 = new Time(h2, m2);

            var resultSubstract = t1 - t2;
            var resultAdd = t1 + t2;

            Console.WriteLine("Результат вычитания: " + resultSubstract);
            Console.WriteLine("Результат сложения: " + resultAdd);
        }
    }
}