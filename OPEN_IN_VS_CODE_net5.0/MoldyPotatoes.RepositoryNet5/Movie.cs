using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.RepositoryNet5
{
    public class Movie
    {
        // CLASS Object of MOVIE

        //Property
        public string Title { get; set; }
        public string DirectorName { get; set; }
        public Genre MovieGenre { get; set; }
        public bool IsKidFriendly { get; set; }
        public Rating MovieRating { get; set; }
        public int Stars { get; set; }

        //FULL Constructor
        public Movie(string title, string directorName, Genre movieGenre, bool isKidFriendly, Rating movieRating, int stars)
        {
            Title = title;
            DirectorName = directorName;
            MovieGenre = movieGenre;
            IsKidFriendly = isKidFriendly;
            MovieRating = movieRating;
            Stars = stars;
        }
    }

    public enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }
    public enum Rating { G, PG, PG_13, R, MA }
}