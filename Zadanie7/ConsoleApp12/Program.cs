using System;
using System.Collections.Generic;


namespace ConsoleApp12
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var rnd = new Random();
            Person[] tablica = new Person[100];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = new Person(i, $"{rnd.Next(0,100)}", GenLiczb());
            }

            List<Person> lista = new List<Person>();
            
            
            //dodawanie klonów
            for (int i = 0; i < tablica.Length; i++)
            {
                lista.Add(tablica[i].DeepCopy());
            }
            
           
            
            //zerowanie
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = null;
            }
            
            lista.Sort();

            int NrKol = 0;
            foreach (var item in lista)
            {
                Console.WriteLine($"Collection: {NrKol}");
                item.Print();
                NrKol++;

            }
            
        }
        
        
        public static int[] GenLiczb()
        {
            var rnd = new Random();
            int[] tab = new int[10];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(0, 100);
            }
            
            return tab;
        }
       
    }
}