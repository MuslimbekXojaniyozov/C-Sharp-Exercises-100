using System;
using System.ComponentModel.Design;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("musbat");
        }
        else if (a < 0)
        {
            Console.WriteLine("manfiy");
        }
        else
        {
            Console.WriteLine("nol");

        }
    }
}