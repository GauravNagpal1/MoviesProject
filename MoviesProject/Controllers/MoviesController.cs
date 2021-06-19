using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesProject.BusinessLogic;

namespace MoviesProject.Controllers
{
    [ApiController]
    //[Route("[controller]")]

    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesBL _moviesbl;

        private IEnumerable<Movie> Movies;


        public MoviesController(ILogger<MoviesController> logger, IMoviesBL moviesBL)
        {
            _logger = logger;
            _moviesbl = moviesBL;
        }

        /**
         * get details of movie with id
         */
        [Route("details/{id}")]
        [HttpGet]
        public Movie GetMovieDetails(int id)
        {
            return _moviesbl.getMovieDetailsByID(id);
        }

        /**
        * get all the movies available
        */
        [Route("all")]
        [HttpGet]
        public IEnumerable<Movie> GetAllMovies()
        {
            return _moviesbl.getAllMovies();
        }

    }
}
