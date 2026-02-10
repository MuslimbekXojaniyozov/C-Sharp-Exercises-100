using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c= ");
        int c = int.Parse(Console.ReadLine());
              if (a > b && a > c) { Console.WriteLine(a); }
        else if (a > b && b < c)
        {
            Console.WriteLine(c);
        }

        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b) {
            Console.WriteLine(c);
        }
   
    }
}