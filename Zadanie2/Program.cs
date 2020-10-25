using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;


namespace ConsoleApp2
{
    class Program
    {
        enum MiejscaZ
        {
            Brak = 0,
            Jedno = 1,
            Dwa = 2,
        }

        static MiejscaZ iloscMiejsc;

        static void Main(string[] args)
        {
            
                var liczbaA = Console.ReadLine();
                var liczbaB = Console.ReadLine();
                var liczbaC = Console.ReadLine();


                var czyUdaloSie1 = int.TryParse(liczbaA, out int a);
                var czyUdaloSie2 = int.TryParse(liczbaB, out int b);
                var czyUdaloSie3 = int.TryParse(liczbaC, out int c);


                if ((czyUdaloSie1) && (czyUdaloSie2) && (czyUdaloSie3))
                {
                    var delta = (Math.Pow(b, 2)) - (4 * a * c);
                    Console.WriteLine("Delta: {0}", delta);
                    var pDelta = Math.Sqrt(delta);
                    string wynik;

                    if (delta > 1)
                    {
                        iloscMiejsc = MiejscaZ.Dwa;
                        var placeZeroOne = (-b - pDelta) / (2 * a);
                        var placeZeroTwo = (-b + pDelta) / (2 * a);
                        wynik = $"Miejsca: {placeZeroOne:F} {placeZeroTwo:F}";
                    }
                    else if (delta == 0)
                    {
                        iloscMiejsc = MiejscaZ.Jedno;
                        var placeZero = -b / (2 * a);
                        wynik = $"Miejsca: {placeZero:F}";
                    }
                    else
                    {
                        iloscMiejsc = MiejscaZ.Brak;
                        wynik = $"Miejsca: Brak";
                    }

                    Console.WriteLine("Liczba miejsc zerowych: {0}\n{1}", iloscMiejsc,wynik);
                    
                }
                else
                {
                    Console.WriteLine("Podales bledne dane");
                    
                }
            
        }
    }
}