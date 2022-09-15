using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.Repository
{
    public class MovieRepository
    {
        // FAKE DATABASE
        private List<Movie> _movieList = new List<Movie>();

        // CRUD

        // CREATE / READ / UPDATE / DELETE

        // CREATE
        public void AddMovieToList(Movie movie)
        {
            _movieList.Add(movie);
        }


        // READ
        public List<Movie> GetAllMoviesFromList()
        {
            return _movieList;
        }

        public Movie GetMovieFromListByTitle(string userInputTitleSearch)
        {
            foreach (Movie movie in _movieList)
            {
                if (movie.Title.ToUpper() == userInputTitleSearch.ToUpper())
                {
                    return movie;
                }
            }

            return null;
        }

        public bool UpdateMovie(Movie movie)
        {
            foreach (Movie existingMovie in _movieList)
            {
                if (existingMovie.Title.ToUpper() == movie.Title.ToUpper())
                {
                    existingMovie.Title = movie.Title;
                    existingMovie.DirectorName = movie.DirectorName;
                    existingMovie.MovieGenre = movie.MovieGenre;
                    existingMovie.IsKidFriendly = movie.IsKidFriendly;
                    existingMovie.MovieRating = movie.MovieRating;
                    existingMovie.Stars = movie.Stars;

                    return true;
                }
            }

            return false;
        }

        public bool UpdateMovie(Movie movie, string title)
        {
            foreach (Movie existingMovie in _movieList)
            {
                if (existingMovie.Title.ToUpper() == title.ToUpper())
                {
                    existingMovie.Title = movie.Title;
                    existingMovie.DirectorName = movie.DirectorName;
                    existingMovie.MovieGenre = movie.MovieGenre;
                    existingMovie.IsKidFriendly = movie.IsKidFriendly;
                    existingMovie.MovieRating = movie.MovieRating;
                    existingMovie.Stars = movie.Stars;

                    return true;
                }
            }

            return false;
        }


        // DELETE
        public bool DeleteMovieByTitle(string title)
        {
            foreach (Movie movie in _movieList)
            {
                if (movie.Title.ToUpper() == title.ToUpper())
                {
                    _movieList.Remove(movie);
                    return true;
                }
            }

            return false;
        }

        // SEED DATA METHOD

        public void SeedMovieData()
        {
            Movie encanto = new Movie("Encanto", "Byron Howard", Genre.Comedy, true, Rating.G, 5);
            Movie dieHard = new Movie("Die Hard", "John McTiernan", Genre.Action, false, Rating.R, 8);
            Movie heGotGame = new Movie("He Got Game", "Spike Lee", Genre.Drama, false, Rating.R, 8);
            Movie ponyo = new Movie("Ponyo", "Hayao Miyazaki", Genre.SciFi_Fantasy, true, Rating.G, 7);
            Movie officeSpace = new Movie("Office Space", "Mike Judge", Genre.Comedy, false, Rating.PG_13, 8);

            Movie[] moviesArr = { encanto, dieHard, heGotGame, ponyo, officeSpace };

            foreach (Movie movie in moviesArr)
            {
                AddMovieToList(movie);
            }
        }

    }
}