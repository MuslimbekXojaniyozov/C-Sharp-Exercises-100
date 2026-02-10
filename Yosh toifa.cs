using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("yoshni kiriting");
        int a=int.Parse(Console.ReadLine());
        if (a > 0 && a <= 12)
        {
            Console.WriteLine(a + " yoshli Bola");
        }
        else if(a>12 && a < 19)
        {
            Console.WriteLine(a + " yoshli O'spirin");
        }
        else if (a>19 && a < 60)
        {
            Console.WriteLine(a + " yoshli Kattalar");
        }
        else if (a > 60)
        {
            Console.WriteLine(a + " yoshli Qariya");
        }
        else { Console.WriteLine("Null"); }
    }
}