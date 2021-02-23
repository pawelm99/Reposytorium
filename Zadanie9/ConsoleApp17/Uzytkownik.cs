using System;

namespace YouTube
{
    public class Uzytkownik
    {
        public Uzytkownik(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        
        public void SubskrybujKanał(object sender,Kanal kanal)
        {
            Console.WriteLine($"Uzytkownik {Name} otrzymał powiadomienie o nowym filmie {kanal.FilmName}z kanału : {kanal.Name}");
        }
    }
}