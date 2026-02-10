using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("oylikni kiriting= ");

        double oylik =double.Parse(Console.ReadLine());
        Console.WriteLine("stajni kiriting= ");

        int staj =int.Parse(Console.ReadLine());

        if (staj >= 5)
        {
            Console.WriteLine(oylik + oylik * 0.05);
        }
        else
        {
            Console.WriteLine("staj 5 yildan kam "+oylik);
        }
    }
}