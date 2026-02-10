using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("S= ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("t= ");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("v= " + (a/b));
    }
}