using System;
using System.Collections.Generic;

namespace YouTube
{
    public class Kanal
    {
        private Random rnd = new Random();
        public string Name { get; set; }
        public int Id { get; set; }
        public int LicznikWyswietlen { get; set; }
        public int IloscSubow { get; set; }

        public Kanal(string name, int id)
        {
            Name = name;
            Id = rnd.Next(100);
        }

        public event EventHandler<Kanal> OpublikowanoFilm;
        
        public void WyswietlFilm(Uzytkownik user)
        {
            
            LicznikWyswietlen ++;
            Console.WriteLine($"Film zobaczyl {user.Name}");
        }

        public void OpublikujFilm(List<Uzytkownik> uzytkownik)
        {
            OpublikowanoFilm?.Invoke(this, this);
            WyslijPowiadomienieOFilnie(uzytkownik);
        }

        private void WyslijPowiadomienieOFilnie(List<Uzytkownik> uzytkownik)
        {
            for (int i = 0; i < uzytkownik.Count; i++)
            {
                Console.WriteLine($"Uzytkownik {uzytkownik[i].Name} otrzymał powiadomienie o nowym filmie");
            }
        }
    }
}