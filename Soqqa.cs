using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("kunlik summa= ");
        double kunlik_summa = double.Parse(Console.ReadLine());
        Console.Write("kun= ");
        int kun = int.Parse(Console.ReadLine());
        
   
        double sof_oylik = kunlik_summa * kun;

        double soliq = sof_oylik * 0.12;
        double natija = sof_oylik - soliq;
        Console.WriteLine("sof oylik= " + sof_oylik + " so'm");
        Console.WriteLine("soliq= " + soliq + " so'm");
        Console.WriteLine("natija= " + natija + " so'm");



    }
}

