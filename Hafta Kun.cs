using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("1 dan 7 gacha son kirit= ");
        int a = int.Parse(Console.ReadLine());
        if (a == 0) { Console.WriteLine("null"); }
        else if (a == 1) { Console.WriteLine("dushanba"); }
        else if (a == 2) { Console.WriteLine("seshanba"); }
        else if (a == 3) { Console.WriteLine("chorshanba"); }
        else if (a == 4) { Console.WriteLine("Payshanba"); }
        else if (a == 5) { Console.WriteLine("Juma"); }
        else if (a == 6) { Console.WriteLine("Shanba"); }
        else if (a == 7) { Console.WriteLine("Yakshanba"); }
        else { Console.WriteLine("Null"); }
    }
}

