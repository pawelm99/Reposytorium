using System;

namespace ConsoleApp4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Kasiazka[,,] tab = new Kasiazka[3, 6, 10];

            wypelnij(tab);
            tab[1, 1, 5].Autor = "J.K. Rowling";
            tab[1, 1, 5].Tytul = "Harry Potter i Czara Ognia";
          
            
            

            var wczytaj = Console.ReadLine();
            show(tab,wczytaj);
        }

        private static void show(Kasiazka[,,] tab,string wczytaj)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int k = 0; k < tab.GetLength(2); k++)
                    {
                        //if ((tab[i,j,k].Tytul.StartsWith(wczytaj)) || (tab[i,j,k].Autor.StartsWith(wczytaj)))
                        if ((System.Text.RegularExpressions.Regex.IsMatch(tab[i,j,k].Tytul, wczytaj)) || (System.Text.RegularExpressions.Regex.IsMatch(tab[i,j,k].Autor, wczytaj)))
                        {
                            Console.WriteLine(tab[i, j, k]);
                        }
                        
                        
                    }
                }
            }
        }

        private static void wypelnij(Kasiazka[,,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int k = 0; k < tab.GetLength(2); k++)
                    {
                        tab[i,j,k] = new Kasiazka(i,j,k,"Pan Tadeusz","Adam Mickiewicz");
                    }
                }
            }
        }
    }
}