using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tomonlar uzunligini kiritng ");
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        int c=int.Parse(Console.ReadLine());
        if (a + b > c || b + c > a || a + c > b) { Console.WriteLine("Uchburchak bo'ladi"); }
        else
        {
            Console.WriteLine("Uchburchak bo'lmaydi");
        }
    }
}