using System;
class Programm {
    static void Main(string[] args)
    {
        Console.Write("Soatni kiriting= ");
        int soat = int.Parse(Console.ReadLine());
        int minut = soat * 60;
        Console.WriteLine("Minut= "+minut);

    }
}
