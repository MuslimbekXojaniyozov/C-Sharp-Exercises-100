using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("1-son= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("amal = ");
        char amal = char.Parse(Console.ReadLine());
        Console.WriteLine("2- son= ");
        int b = int.Parse(Console.ReadLine());
       
        if (amal == '+')
        {
            Console.WriteLine(a + b);
        }
        else if (amal == '-')
        {
            Console.WriteLine(a - b);
        }
        else if (amal == '*')
        {
            Console.WriteLine(a * b);
        }
        else if (amal == '/' || amal == ':')
        {
            Console.WriteLine(a / b);
        }
    }
}