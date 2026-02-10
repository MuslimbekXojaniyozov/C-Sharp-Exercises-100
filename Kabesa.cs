using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("yilni kiriting= ");
        int a = int.Parse(Console.ReadLine());
        if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0) { Console.WriteLine(a + " Yil Kabesa yili "); }
        else { Console.WriteLine("Kabesa yili emas"); }
    }
}