using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.Write("sonni kiriting = ");
        int a = int.Parse(Console.ReadLine());
        int b = 1;
        for (int i = 1; i <= a; i++) {
         
            b = b * i;
        }
        Console.WriteLine("Faktorial: " + b);
         
          
       

    }
    
}