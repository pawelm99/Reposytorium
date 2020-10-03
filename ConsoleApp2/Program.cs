using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;


namespace ConsoleApp2
{
   
    class Program
    {

        enum MiejscaZ
        {
            
            Brak,
            Jedno,
            Dwa,
            
        }
        
        static void Main(string[] args)
        {
            
            
            for (;;)
            {
            
            var liczbaA = Console.ReadLine();
            var liczbaB = Console.ReadLine();
            var liczbaC = Console.ReadLine();

           
                
            var czyUdaloSie1 = int.TryParse(liczbaA, out int a);
            var czyUdaloSie2 = int.TryParse(liczbaB, out int b);
            var czyUdaloSie3 = int.TryParse(liczbaC, out int c);

            
                if ((czyUdaloSie1) && (czyUdaloSie2) && (czyUdaloSie3))
                {
                    var delta =(Math.Pow(b, 2)) - (4 * a * c);
                    Console.WriteLine("Delta: {0}",delta);
                    var wynik=0;
                    
                    if (delta > 1) wynik = 2;
                    else if (delta == 0) wynik = 1;
                    else wynik = 0;

                    var z = (wynik) switch
                    {
                        (1) => MiejscaZ.Jedno,
                        (2) => MiejscaZ.Dwa,
                        (0) => MiejscaZ.Brak,
                    };
                    
                    Console.WriteLine("Liczba miejsc zerowych: {0}", z);
                    break;
                }
                else
                {
                    Console.WriteLine("Podales bledne dane spróbuj ponownie");
                    continue;
                }
            }
        }
    }
}
