using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("N= ");
        int a = int.Parse(Console.ReadLine());
        int b = 0;
        for (int i = 1; i <= a; i++)
        {
            Console.WriteLine(b+=i);
        }
    }
}