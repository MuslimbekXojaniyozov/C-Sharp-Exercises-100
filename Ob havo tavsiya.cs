using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("haroratni kiritng (C)= ");
        int a=int.Parse(Console.ReadLine());
        if (a < 0) { Console.WriteLine("Juda sovuq"); }
        else if (a>=0 && a < 20) { Console.WriteLine("Salqin "); }
        else { Console.WriteLine("Juda issiq"); }
    }
}