using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        double a = double.Parse(Console.ReadLine());

        double ildiz = Math.Sqrt(a);
        Console.WriteLine("Kvadrat ildizi: " + ildiz);
    }
}