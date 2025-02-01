using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagementSystem.DataAccess;

namespace MovieManagementSystem.BusinessLogic
{
    public class MovieService : IMovieService
    {
        public static Dictionary<int, Movie> movieDictionary = new Dictionary<int, Movie>();
        public const string FilePath = "movies.json";

        public bool AddMovie(Movie movie)
        {
            if (movieDictionary.ContainsKey(movie.movieID)) {
                return false;
            }
            if (movie.movieID == -1) {
                return false;
            }
            movieDictionary.Add(movie.movieID, movie);
            return true;
        }

        public bool DeleteMovie(int MovieID)
        {
            if (movieDictionary.ContainsKey(MovieID))
            {
                movieDictionary.Remove(MovieID);
                return true;
            }
            return false;


        }

        public bool UpdateMovie(int movieID, Movie updatedMovie)
        {
            if (movieDictionary.ContainsKey(movieID))
            {
                movieDictionary[movieID] = updatedMovie;
                return true;
            }
            return false;
        }

        public Movie GetMovie(int MovieID)
        {
            if (movieDictionary.ContainsKey(MovieID))
            {
                return movieDictionary[MovieID];
            }
            return null;

        }

        public List<Movie> GetAllMovies()
        {
            if (movieDictionary.Count == 0) {
                return new List<Movie>();
            }
            return new List<Movie>(movieDictionary.Values);
        }

        public void LoadMovies(List<Movie> movies)
        {
            movieDictionary = movies.ToDictionary(m => m.movieID, m => m);
        }


        public List<Movie> GetAllMoviesSorted()
        {
            List<int> sortedKeys = new List<int>(movieDictionary.Keys);
            sortedKeys.Sort();

            List<Movie> sortedMovies = new List<Movie>();
            foreach (int key in sortedKeys)
            {
                sortedMovies.Add(movieDictionary[key]);
            }
            return sortedMovies;
        }
    }
}
