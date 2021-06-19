using System;
using System.Collections.Generic;
using System.Linq;
using MoviesProject.DataLayer;

namespace MoviesProject.BusinessLogic
{
    public class MoviesBL : IMoviesBL
    {
        private IMoviesDL _moviesDL;

        public MoviesBL(IMoviesDL moviesDL)
        {
            _moviesDL = moviesDL;
        }

        public IEnumerable<Movie> getAllMovies()
        {
            return this._moviesDL.getAllMovies();
        }

        public Movie getMovieDetailsByID(int id)
        {
            var movie =  this._moviesDL.getMovieDetailsByID(id);

            if (movie==null)
            {
                throw new MovieNotFoundException("Sorry unable to fetch details of this movie. Id:" + id);
            }

            return movie;
        }
    }


    [Serializable]
    public class MovieNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MovieNotFoundException"/> class
        /// </summary>
        public MovieNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MovieNotFoundException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        public MovieNotFoundException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MovieNotFoundException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception. </param>
        public MovieNotFoundException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MovieNotFoundException"/> class
        /// </summary>
        /// <param name="context">The contextual information about the source or destination.</param>
        /// <param name="info">The object that holds the serialized object data.</param>
        protected MovieNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}
