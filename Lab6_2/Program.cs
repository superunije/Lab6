using System;

namespace Lab6_2
{
    class Program
    {
        static byte InputByte(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                var s = Console.ReadLine();

                if (byte.TryParse(s, out var value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка ввода!");
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите время");
            byte h1 = InputByte("Часы 1: ");
            byte m1 = InputByte("Минуты 1: ");

            byte h2 = InputByte("Часы 2: ");
            byte m2 = InputByte("Минуты 2: ");

            var t1 = new Time(h1, m1);
            var t2 = new Time(h2, m2);

            var resultSubstract = t1 - t2;
            var resultAdd = t1 + t2;

            Console.WriteLine("Результат вычитания: " + resultSubstract);
            Console.WriteLine("Результат сложения: " + resultAdd);
        }
    }
}