using System;
using System.Collections.Generic;
using Moq;
using MoviesProject;
using MoviesProject.BusinessLogic;
using MoviesProject.DataLayer;
using NUnit.Framework;

namespace TestMoviesProject
{
    public class Tests

    {
        private MoviesBL moviesBL;
        private Mock<IMoviesDL> moviesDL;
        private List<Movie> moviesList;
        private Movie movie;

        [SetUp]
        public void Setup()
        {
          
            moviesDL = new Mock<IMoviesDL>();
            moviesList = new List<Movie>();

            movie = new Movie() { ID = 1, IMDBRating = "7", Title = "Clash of Titans" };
            moviesList.Add(movie);
            moviesList.Add(new Movie() { ID = 2, IMDBRating = "9", Title = "The Flash" });
            moviesList.Add(new Movie() { ID = 3, IMDBRating = "8.2", Title = "The Final Destination" });

        }

        [Test]
        public void Test_Get_All_Movies_Success()
        {
            //Arrange
            moviesDL.Setup(x => x.getAllMovies()).Returns(moviesList);

            moviesBL = new MoviesBL(moviesDL.Object);

            //Act
            List<Movie> movies = (List < Movie >) moviesBL.getAllMovies();

            //Assert
            Assert.AreEqual(movies.Count, 3);
            moviesDL.Verify(m => m.getAllMovies(), Times.Once);
        }

        [Test]
        public void Test_Get_Movied_Details_By_ID_Success()
        {
            //Arrange
            moviesDL.Setup(x => x.getMovieDetailsByID(1)).Returns(movie);

            moviesBL = new MoviesBL(moviesDL.Object);

            //Act
            Movie movieDetails =  moviesBL.getMovieDetailsByID(1);

            //Assert
            Assert.AreEqual(movieDetails.ID, 1);
            Assert.AreEqual(movieDetails.IMDBRating, "7");
            Assert.AreEqual(movieDetails.Title, "Clash of Titans");

            moviesDL.Verify(m => m.getMovieDetailsByID(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void Test_Get_Movied_Details_By_ID_When_ID_Not_Exists_Fail()
        {
            //Arrange
            moviesDL.Setup(x => x.getMovieDetailsByID(4)).Throws(new MovieNotFoundException());

            moviesBL = new MoviesBL(moviesDL.Object);

            //Act

            //Assert
            Assert.Throws<MovieNotFoundException>(()=> moviesBL.getMovieDetailsByID(1));

            moviesDL.Verify(m => m.getMovieDetailsByID(It.IsAny<int>()), Times.Once);
        }

    }
}