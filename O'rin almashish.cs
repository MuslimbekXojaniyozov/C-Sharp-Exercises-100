using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        int c = a;
        a = b;
        b = a;
        Console.WriteLine("a= " + b);
        Console.WriteLine("b= " + c);
    }
}