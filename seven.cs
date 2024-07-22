using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            if (b < 10 || b <= a)
                Console.WriteLine("Некорректные значения a и b.");
            else
            {
                // Задача а)
                for (int i = 20; i <= 35; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();

                // Задача б)
                int square;
                for (int i = 10; i < b; i++)
                {
                    square = i * i;
                    Console.WriteLine($"{i}^2 = {square}");
                }

                Console.WriteLine();

                // Задача в)
                for (int i = a; i <= 50; i++)
                {
                    int cube = (int)Math.Pow(i, 3);
                    Console.WriteLine($"i^3 = {cube}");
                }

                Console.WriteLine();

                // Задача г)
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
