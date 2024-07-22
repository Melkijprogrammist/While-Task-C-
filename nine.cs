using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
        foreach (int i in mas)
        {
            Console.WriteLine(i);
        }
    }
}
