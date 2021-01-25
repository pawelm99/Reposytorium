using System;
using System.Collections.Generic;
using System.Linq;


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
                tablica[i] = new Person(i, $"{rnd.Next(0, 100)}", GenLiczb());
            }

            List<object> lista = new List<object>();


            //dodawanie klonów
            for (int i = 0; i < tablica.Length; i++)
            {
                lista.Add(tablica[i].Clone());
            }


            //zerowanie

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].LiczbyCałkowite.Length; j++)
                {
                    tablica[i].LiczbyCałkowite[j] = 0;
                    //tablica[i]._id = 0;
                }
            }

            Array.Sort(tablica);


            int NrTab = 0;
            foreach (var item in tablica)
            {
                Console.WriteLine($"Collection: {NrTab}");
                item.Print();
                NrTab++;
            }

            Console.WriteLine("//-------------------KOPIE !!!!!!!!!!!!!!!!!!!!!!!!!!");
            foreach (Person item in lista)
            {
                Console.WriteLine($"ID: {item._id}, Name: {item._name}, ");
                Console.WriteLine("Tablica int: ");
                for (int j = 0; j < item.LiczbyCałkowite.Length; j++)
                {
                    Console.Write(item.LiczbyCałkowite[j]);
                }

                Console.WriteLine();
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