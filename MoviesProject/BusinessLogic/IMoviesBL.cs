using System.Collections.Generic;

namespace MoviesProject.BusinessLogic
{
    public interface IMoviesBL
    {
        IEnumerable<Movie> getAllMovies();
        Movie getMovieDetailsByID(int id);
    }
}