using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.Write("nechinchi oyligini kiriting= ");
        int a = int.Parse(Console.ReadLine());
       
        if (a == 12 || a == 1 || a == 2) { Console.WriteLine("Qish"); }
        else if (a == 3 || a == 4 || a == 5) { Console.WriteLine("Bahor"); }
        else if (a == 6 || a == 7 || a == 8) { Console.WriteLine("yoz"); }
        else if (a == 9 || a == 10 || a == 11) { Console.WriteLine("Kuz"); }
        else
        {
            Console.WriteLine("Null");
        }
    }
}



