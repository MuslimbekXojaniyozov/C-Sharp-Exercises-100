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
        double D = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine(D);
        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1= " + x1);
            Console.WriteLine("x2= " + x2);
        }
        else if (D == 0)
        {
            double x = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("1 ta yechimga ega x= " + x);
        }
        else
        {
            Console.WriteLine("yechimga ega emas ");
        }
    }
}