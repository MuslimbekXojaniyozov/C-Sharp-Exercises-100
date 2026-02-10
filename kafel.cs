Console.Write("Xona uzunligi: ");
double L = double.Parse(Console.ReadLine());

Console.Write("Xona eni: ");
double W = double.Parse(Console.ReadLine());

Console.Write("Kafel tomoni: ");
double K = double.Parse(Console.ReadLine());

double xonaYuza = L * W;
double kafelYuza = K * K;

int soni = (int)(xonaYuza / kafelYuza);
Console.WriteLine("Kerakli kafel soni: " + soni);
