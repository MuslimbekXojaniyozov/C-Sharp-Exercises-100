using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("sonni kiriting= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("darajani kiriting= ");
        int b = int.Parse(Console.ReadLine());
        int c = 1;
        for (int i = 1; i < a; i++)
        {
            c*= b;
        }
        Console.WriteLine($"{a} sonining {b}-darajasi={c} ");
    }
}