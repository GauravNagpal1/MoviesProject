using System.Collections.Generic;

namespace MoviesProject.DataLayer
{
    public interface IMoviesDL
    {
        IEnumerable<Movie> getAllMovies();
        Movie getMovieDetailsByID(int id);
    }
}