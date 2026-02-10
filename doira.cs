
using System;

class Program
{
    static void Main()
    {
        Console.Write("radius= ");
        double r = double.Parse(Console.ReadLine()!);

        double s = Math.PI * r * r;

        Console.WriteLine("Doira yuzi = " + s);
    }
}
