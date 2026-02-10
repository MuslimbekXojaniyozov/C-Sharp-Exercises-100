using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Parolni kiriting (# # # # #) =");
        int a = int.Parse(Console.ReadLine());
        if (a == 12345) { Console.WriteLine("Xush kelibsiz"); }
        else { Console.WriteLine("Xato"); }
    }
}