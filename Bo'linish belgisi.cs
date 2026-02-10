using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("son kiriting= ");
        int a = int.Parse(Console.ReadLine());
        if (a % 5 == 0 && a % 3 == 0) { Console.WriteLine("bu son 5 ga ham 3 ga ham bo'linadi"); }
        else  { Console.WriteLine("Null"); }


    }
}