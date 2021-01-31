using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YouTube
{
    class Program
    {
         private static void WyswietlFIlmMethod(List<Uzytkownik> users, Kanal kanal)
        {
            for (int i = 0; i < users.Count; i++)
            {
                kanal.WyswietlFilm(users[i]);
            }
        }


        private static void SubAndShow(List<Uzytkownik> users,Kanal kanal)
        {
            
            for (int i = 0; i < users.Count; i++)
            {
                kanal.OpublikowanoFilm += users[i].SubskrybujKanał;
                
            }
            kanal.OpublikujFilm(users);
            
           
            
        }

        private static List<Uzytkownik> UserGenerate()
        {
           var users = new List<Uzytkownik>();
           Random rnd = new Random();
           for (int i = 0; i < 20; i++)
           {
               users.Add(new Uzytkownik($"User{i}",rnd.Next(100)));
           }
   
           return users;
        }
        
        static void Main(string[] args)
        {
            var kanal = new Kanal("Programowanie",1);
            var users = UserGenerate();
            
            SubAndShow(users,kanal);
            WyswietlFIlmMethod(users,kanal);
            

            Console.WriteLine();
            Console.WriteLine(kanal.Serialize());
            
 

        }

       
    }
}