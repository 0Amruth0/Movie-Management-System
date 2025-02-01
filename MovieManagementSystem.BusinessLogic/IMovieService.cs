using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagementSystem.DataAccess;

namespace MovieManagementSystem.BusinessLogic
{
    internal interface IMovieService
    {
        bool AddMovie(Movie movie);
        bool UpdateMovie(int movieID, Movie updatedMovie);
        bool DeleteMovie(int  MovieID);
        Movie GetMovie(int MovieID);
        List<Movie> GetAllMovies();

    }
}
