using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesProject.DataLayer
{
    public class MoviesDL : IMoviesDL
    {
        private IEnumerable<Movie> movies = new List<Movie>(){
                new Movie
        {   ID =1,
            Language = "ENGLISH",
            Location = "PUNE",
            Plot = "Forced to spend his summer holidays with his muggle relations, Harry Potter gets a real shock when he gets a surprise visitor: Dobby the house-elf, who warns Harry Potter against returning to Hogwarts, for terrible things are going to happen. Harry decides to ignore Dobby's warning and continues with his pre-arranged schedule. But at Hogwarts, strange and terrible things are indeed happening: Harry is suddenly hearing mysterious voices from inside the walls, muggle-born students are being attacked, and a message scrawled on the wall in blood puts everyone on his/her guard - \"The Chamber Of Secrets Has Been Opened. Enemies Of The Heir, Beware\" .",
            Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTcxODgwMDkxNV5BMl5BanBnXkFtZTYwMDk2MDg3._V1_SX300.jpg",
            SoundEffects = new string[]{
                "DOLBY",
                "DTS"
            },
            Stills = new string[]{
                "https://i.imgur.com/3fJ1P48.gif",
                "https://i.imgur.com/j6ECXmD.gif",
                "https://i.imgur.com/v0ooIH0.gif"
            },
            Title = "Harry Potter and the Chamber of Secrets",
            IMDB_ID = "tt0295297",
            ListingType = "NOW_SHOWING",
            IMDBRating = "7.4"
        },
         new Movie
         {
             ID = 2,
             Language = "HINDI",
             Location = "DELHI",
             Plot = "Harry, Ron, and Hermione continue their quest of finding and destroying the Dark Lord's three remaining Horcruxes, the magical items responsible for his immortality. But as the mystical Deathly Hallows are uncovered, and Voldemort finds out about their mission, the biggest battle begins and life as they know it will never be the same again.",
             Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIyZGU4YzUtNDkzYi00ZDRhLTljYzctYTMxMDQ4M2E0Y2YxXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_SX300.jpg",
             SoundEffects = new string[]{
                "RX6",
                "SDDS"
            },
             Stills = new string[]{
                "https://i.imgur.com/i3aD05u.png",
                "https://i.imgur.com/ABinULO.gif",
                "https://i.imgur.com/Wflfyct.gif"
            },
             ListingType = "NOW_SHOWING",
             Title = "Harry Potter and the Deathly Hallows: Part 2",
             IMDB_ID = "tt1201607",
             IMDBRating = "8.1"
         },
         new Movie
         {
             ID = 3,
             Language = "ENGLISH",
             Location = "DELHI",
             Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
             Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
             SoundEffects = new string[]{
                "RX6",
                "SDDS"
            },
             Stills = new string[]{
                "https://m.media-amazon.com/images/M/MV5BNTYxOTYyMzE3NV5BMl5BanBnXkFtZTcwOTMxNDY3Mw@@._V1_UY99_CR24,0,99,99_AL_.jpg",
                "https://m.media-amazon.com/images/M/MV5BNzAwOTk3MDg5MV5BMl5BanBnXkFtZTcwNjQxNDY3Mw@@._V1_UY99_CR29,0,99,99_AL_.jpg",
                "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL__QL50.jpg"
            },
             Title = "The Shawshank Redemption",
             IMDB_ID = "tt0111161",
             ListingType = "NOW_SHOWING",
             IMDBRating = "9.2"
         }
        };

        public MoviesDL()
        {
        }

        public IEnumerable<Movie> getAllMovies()
        {
            return this.movies;
        }

        public Movie getMovieDetailsByID(int id)
        {
            return this.movies.Where(x => x.ID == id).First() ;
        }
    }
}
