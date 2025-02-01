using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementSystem.DataAccess
{
    public class Movie
    {
        public int movieID { get; set; }
        public string movieTitle { get; set; }
        
        public MovieGenre movieGenre { get; set; }

        public string movieDirector { get; set; }

        public DateTime releaseDate { get; set; }

        public int releaseYear => releaseDate.Year;

        public Movie (int movieID, string movieTitle, MovieGenre movieGenre, string movieDirector, DateTime releaseDate)
        {
            this.movieID = movieID;
            this.movieTitle = movieTitle;
            this.movieGenre = movieGenre;
            this.movieDirector = movieDirector;
            this.releaseDate = releaseDate;
        }
    }
}
