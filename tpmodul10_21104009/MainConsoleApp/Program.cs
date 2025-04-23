using System;
using AljabarLibraries;

class Program
{
    static void Main(string[] args)
    {
        double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine("Akar persamaan kuadrat: " + string.Join(", ", akar));

        double[] kuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine("Hasil kuadrat: " + string.Join(", ", kuadrat));
    }
}