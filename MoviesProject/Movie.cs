using System;
namespace MoviesProject
{
    public class Movie
    {

        public int ID { get; set; }

        public string Language { get; set; }

        public string Location { get; set; }

        public string Plot { get; set; }

        public string Poster { get; set; }

        public string[] SoundEffects { get; set; }

        public string[] Stills { get; set; }

        public string Title { get; set; }

        public string IMDB_ID { get; set; }

        public string ListingType { get; set; }

        public string IMDBRating { get; set; }
    }
}
