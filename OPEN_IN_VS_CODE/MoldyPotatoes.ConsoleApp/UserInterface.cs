using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{
    public class UserInterface
    {
        // _print can be set equal to anything that IMPLEMENTS the ICustomConsole INTERFACE.
        ICustomConsole _print;

        //CONSTRUCTOR
        // DEPENDENCY INJECTION : _console is injected in the constructor and set equal to _print.
        public UserInterface(ICustomConsole _console)
        {
            _print = _console;
        }

        MovieRepository _movieRepo = new MovieRepository();
        private bool isRunning = true;

        public void Run()
        {
            _movieRepo.SeedMovieData();

            while (isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        //CAN DELETE THIS.
        private void PrintMainMenu()
        {
            _print.MainMenu();

            _print.EnterSelection();
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch (input)
            {
                case "1":
                    CreateNewMovie();
                    break;
                case "2":
                    ViewAllMovies();
                    break;
                case "3":
                    ViewMovie();
                    break;
                case "4":
                    EditMovie();
                    break;
                case "5":
                    DeleteMovie();
                    break;
                case "6":
                    isRunning = false;
                    ExitApplication();
                    break;
                default:
                    break;
            }
        }

        private void CreateNewMovie()
        {
            _print.CreateNewMovie();

            _print.Title();
            string title = GetUserInput();

            _print.Director();
            string directorName = GetUserInput();

            //I want a method that fits on single line, that cleans all of this up.

            _print.AllGenreList();

            _print.SelectGenre();
            string genreSelection = GetUserInput();

            Genre genre = Genre.Action;

            switch (genreSelection)
            {
                case "1":
                    genre = Genre.Action;
                    break;
                case "2":
                    genre = Genre.Comedy;
                    break;
                case "3":
                    genre = Genre.Drama;
                    break;
                case "4":
                    genre = Genre.Horror;
                    break;
                case "5":
                    genre = Genre.Romance;
                    break;
                case "6":
                    genre = Genre.RomCom;
                    break;
                case "7":
                    genre = Genre.Thriller;
                    break;
                case "8":
                    genre = Genre.SciFi_Fantasy;
                    break;
                default:
                    break;
            }

            _print.AllMovieRatingsList();

            _print.SelectMovieRating();
            string ratingSelection = GetUserInput();

            Rating rating = Rating.G;

            switch (ratingSelection)
            {
                case "1":
                    rating = Rating.G;
                    break;
                case "2":
                    rating = Rating.PG;
                    break;
                case "3":
                    rating = Rating.PG_13;
                    break;
                case "4":
                    rating = Rating.R;
                    break;
                case "5":
                    rating = Rating.MA;
                    break;
                default:
                    break;
            }

            bool isKidFriendly = false;

            if (rating == Rating.G || rating == Rating.PG)
            {
                isKidFriendly = true;
            }

            _print.NumberOfStars();
            int stars = Convert.ToInt32(GetUserInput());
            //int stars = (int)Console.ReadLine();

            Movie newMovie = new Movie(title, directorName, genre, isKidFriendly, rating, stars);

            _movieRepo.AddMovieToList(newMovie);
        }


        //CAN DELETE THIS.
        private void PrintMovie(Movie movie)
        {
            _print.PrintAMovie(movie);
        }

        private void ViewAllMovies()
        {
            List<Movie> allMovies = _movieRepo.GetAllMoviesFromList();

            foreach (Movie tomato in allMovies)
            {
                PrintMovie(tomato);
            }

            _print.PressAnyKeyToContinue();
            Console.ReadKey();
        }

        private void ViewMovie()
        {
            _print.Title();
            string title = GetUserInput();

            Movie movie = _movieRepo.GetMovieFromListByTitle(title);

            if (movie != null)
            {
                PrintMovie(movie);
                _print.PressAnyKeyToContinue();
            }
            else
            {
                _print.CouldntFindMovie();
                _print.PressAnyKeyToContinue();
            }

            Console.ReadKey();
        }

        private void EditMovie()
        {
            _print.Title();
            string title = Console.ReadLine();

            Movie movie = _movieRepo.GetMovieFromListByTitle(title);

            if (movie != null)
            {
                PrintMovie(movie);

                _print.TheWordNew();
                _print.Title();
                string newTitle = GetUserInput();

                _print.Director();
                string newDirector = GetUserInput();

                _print.AllGenreList();

                _print.SelectGenre();
                string newGenreSelection = GetUserInput();

                Genre newGenre = movie.MovieGenre;

                switch (newGenreSelection)
                {
                    case "1":
                        newGenre = Genre.Action;
                        break;
                    case "2":
                        newGenre = Genre.Comedy;
                        break;
                    case "3":
                        newGenre = Genre.Drama;
                        break;
                    case "4":
                        newGenre = Genre.Horror;
                        break;
                    case "5":
                        newGenre = Genre.Romance;
                        break;
                    case "6":
                        newGenre = Genre.RomCom;
                        break;
                    case "7":
                        newGenre = Genre.Thriller;
                        break;
                    case "8":
                        newGenre = Genre.SciFi_Fantasy;
                        break;
                    default:
                        break;
                }

                _print.AllMovieRatingsList();

                _print.SelectMovieRating();
                string newRatingSelection = GetUserInput();

                Rating newRating = movie.MovieRating;

                switch (newRatingSelection)
                {
                    case "1":
                        newRating = Rating.G;
                        break;
                    case "2":
                        newRating = Rating.PG;
                        break;
                    case "3":
                        newRating = Rating.PG_13;
                        break;
                    case "4":
                        newRating = Rating.R;
                        break;
                    case "5":
                        newRating = Rating.MA;
                        break;
                    default:
                        break;
                }

                bool newIsKidFriendly = movie.IsKidFriendly;

                if (newRating == Rating.G || newRating == Rating.PG)
                {
                    newIsKidFriendly = true;
                }

                _print.NumberOfStars();
                int newStars = Convert.ToInt32(GetUserInput());
                //int stars = (int)Console.ReadLine();

                Movie updatedMovie = new Movie(newTitle, newDirector, newGenre, newIsKidFriendly, newRating, newStars);

                if (updatedMovie.Title.ToUpper() == movie.Title.ToUpper())
                {
                    bool isSuccess = _movieRepo.UpdateMovie(updatedMovie);
                    _print.SuccessfullyUpdated(updatedMovie);
                    _print.PressAnyKeyToContinue();
                    Console.ReadKey();
                }
                else
                {
                    bool isSuccess = _movieRepo.UpdateMovie(updatedMovie, movie.Title);
                    _print.SuccessfullyUpdated(updatedMovie);
                    _print.PressAnyKeyToContinue();
                    Console.ReadKey();
                }

            }
            else
            {
                _print.CouldntFindMovie();
                _print.PressAnyKeyToContinue();
                Console.ReadKey();
            }
        }

        private void DeleteMovie()
        {
            _print.MovieToDelete();
            _print.Title();

            string input = GetUserInput();

            bool isSuccess = _movieRepo.DeleteMovieByTitle(input);

            if (isSuccess)
            {
                _print.MovieSuccessfullyDeleted();
                _print.PressAnyKeyToContinue();
                Console.ReadKey();
            }
            else
            {
                _print.CouldntFindMovie();
                _print.PressAnyKeyToContinue();
                Console.ReadKey();
            }

        }

        public void ExitApplication()
        {
            _print.ExitApplication();
            Console.ReadKey();
        }
        //next method
    }
}