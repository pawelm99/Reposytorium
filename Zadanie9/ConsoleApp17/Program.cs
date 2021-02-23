using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YouTube
{
    class Program
    {
        private static void WyswietlFIlmMethod(List<Uzytkownik> users, Kanal kanal, string film)
        {
            
            for (int i = 0; i < users.Count; i++)
            {
                kanal.WyswietlFilm(users[i], film);
            }
            Console.WriteLine($"FIlm {film} widziało {users.Count} osób");
        }


        private static void SubAndShow(List<Uzytkownik> users, Kanal kanal)
        {
            for (int i = 0; i < users.Count; i++)
            {
                kanal.OpublikowanoFilm += users[i].SubskrybujKanał;
            }

            kanal.IloscSubskrypcji += users.Count;
        }


        private static List<Uzytkownik> UserGenerate()
        {
            var users = new List<Uzytkownik>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                users.Add(new Uzytkownik($"User{i}", rnd.Next(100)));
            }

            return users;
        }

       

        static void Main(string[] args)
        {
            var kanal = new Kanal("Programowanie", 1);
            var users = UserGenerate();
            var users2 = UserGenerate();

            SubAndShow(users, kanal);
            var film1 = kanal.OpublikujFilm(users);
            var film2 = kanal.OpublikujFilm(users);
            WyswietlFIlmMethod(users, kanal, film1);
            WyswietlFIlmMethod(users, kanal, film2);


            Console.WriteLine();
            Console.WriteLine(kanal.Serialize());
        }
    }
}