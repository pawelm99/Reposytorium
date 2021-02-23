using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace YouTube
{
    public class Kanal
    {
        private Random rnd = new Random();
        public string Name { get; set; }
        public int IloscSubskrypcji { get; set; }
        public int Id { get; set; }
        public string FilmName { get; set; }
        public int LicznikWyswietlen { get; set; }

        public Kanal(string name, int id)
        {
            Name = name;
            Id = rnd.Next(100);
        }

    
        public event EventHandler<Kanal> OpublikowanoFilm;
        
        public void WyswietlFilm(Uzytkownik user,string film)
        {
            
            LicznikWyswietlen ++;
            Console.WriteLine($"Film: {film} zobaczyl {user.Name}");
        }

        public string OpublikujFilm(List<Uzytkownik> uzytkownik)
        {
            FilmName = $"\"Numer {rnd.Next(1, 100)}\" ";
            OpublikowanoFilm?.Invoke(this, this);
            return FilmName;
        }

    }
}