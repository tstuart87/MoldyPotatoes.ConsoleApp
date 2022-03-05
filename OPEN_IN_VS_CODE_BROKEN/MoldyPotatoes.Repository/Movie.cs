using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.Repository
{
    public class Movie
    {
        // CLASS Object of MOVIE

        //Property
        public string Title { get; set; }
        public string DirectorName { get; set; }
        public Genre MovieGenre { get; set; }
        private bool IsKidFriendly { get; set; }
        public Rating MovieRating { get; set; }

        public Stars { get; set; }

    //FULL Constructor
    public Movie(string title, string directorName, Genre movieGenre, bool isKidFriendly, Rating movieRating, int stars)
    {
        //HINT: THERE'S SOMETHING WRONG IN HERE, EVEN THOUGH THERE'S NO RED SQUIGGLY

        Title = Title;
        DirectorName = directorName;
        MovieGenre = movieGenre;
        IsKidFriendly = isKidFriendly;
        MovieRating = movieRating;
        Stars = stars;
    }
}

enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }
enum Rating { G, PG, PG_13, R, MA }
}