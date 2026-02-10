using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("r= ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("h= ");
        int h=int.Parse(Console.ReadLine());
        double V=Math.PI*Math.Pow(r,2)*h;
        Console.Write("V= "+V);
    }
}