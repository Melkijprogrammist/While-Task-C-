using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма первых {0}, членов арфимитической прогрессии  равна {1}", n, sum);
        Console.ReadLine();
    }
}
