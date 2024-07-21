{
    Console.WriteLine("Введите сумму вклада: ");
    decimal sum = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Введите срок вклада в месяцах: ");
    int period = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= period; i++)
    {
        sum = sum * 0.07M;
    }
    Console.WriteLine($"После{period} месяцев  сумма вклада составит {sum}");
    Console.ReadKey();
}
