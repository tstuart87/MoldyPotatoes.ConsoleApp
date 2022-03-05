using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.ConsoleApp
{
    public class UserInterface
    {
        MovieRepository _movieRepo = new MovieRepository();
        bool isRunning = true;

        public void Run()
        {
            _movieRepo.SeedMovieData();

            while (isRunnin)
            {
                PrintMainMenu();

                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("\n1. Add new movie.\n" +
                    "2. View all movies.\n" +
                    "3. View one movie.\n" +
                    "4. Edit movie.\n" +
                    "5. Delete movie.\n" +
                    "6. Exit.\n"
            );

            Console.Write("Enter Selection: ");
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

        private string CreateNewMovie()
        {
            Console.WriteLine("Create a NEW MOVIE:");

            Console.Write("\nTitle: ");
            string title = GetUserInput();

            Console.Write("\nDirector: ");
            string directorName = GetUserInput();

            Console.WriteLine("\nMovie Genres:\n" +
                    "1. Action\n" +
                    "2. Comedy\n" +
                    "3. Drama\n" +
                    "4. Horror\n" +
                    "5. Romance\n" +
                    "6. RomCom\n" +
                    "7. Thriller\n" +
                    "8. SciFi/Fantasy\n"
            );

            Console.Write("\nSelect Genre: ");
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

            Console.WriteLine("\nMovie Rating:\n" +
                    "1. G\n" +
                    "2. PG\n" +
                    "3. PG-13\n" +
                    "4. R\n" +
                    "5. MA\n"
            );

            Console.Write("\nSelect Movie Rating: ");
            string ratingSelection = GetUserInput();

            Rating rating = Rating.G;

            switch (ratingSelection)
            {
                case "1":
                    rating = G;
                    break;
                case "2":
                    rating = PG;
                    break;
                case "3":
                    rating = PG_13;
                    break;
                case "4":
                    rating = R;
                    break;
                case "5":
                    rating = MA;
                    break;
                default:
                    break;
            }

            bool isKidFriendly = false;

            if (rating === Rating.G | rating === Rating.PG)
            {
                isKidFriendly = true;
            }

            Console.Write("\nNumber of STARS: ");
            int stars = Convert.ToInt32(GetUserInput());
            //int stars = (int)Console.ReadLine();

            Movie newMovie = new Movie(title, directorName, genre, isKidFriendly, rating, stars);

            _movieRepo.AddMovieToList(newMovie);
        }

        private void PrintMovie(Movie movie)
        {
            Console.WriteLine($"\n{movie.Title}\n" +
                    $"Directed by: {movie.DirectorName}\n" +
                    $"Genre: {movie.MovieGenre}\n" +
                    $"OK for Kiddos: {movie.IsKidFriendly}\n" +
                    $"Movie Rating: {movie.MovieRating}\n" +
                    $"Stars: {movie.Stars}/10\n"
            );
        }

        private void ViewAllMovies()
        {
            List<Movie> allMovies = _movieRepo.GetAllMoviesFromList();

            foreach (Movie tomato in allMovies)
            {
                PrintMovie(tomato);
            }

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        private void ViewMovie()
        {
            Console.Write("Please enter a movie title: ");
            string title = GetUserInput();

            Movie movie = movieRepo.GetMovieFromListByTitle(title);

            if (movie != null)
            {
                PrintMovie(movie);
                Console.WriteLine("\nPress any key to continue....");
            }
            else
            {
                Console.WriteLine("We couldn't find that movie. Press any key to continue....");
            }

            Console.ReadKey();
        }

        private void EditMovie()
        {
            Console.Write("\nPlease enter the title of the movie you'd like to edit: ");
            string? title = Console.ReadLine();

            Movie movie = _movieRepo.GetMovieFromListByTitle(title);

            if (movie != null)
            {
                PrintAMovie(movie);

                Console.Write("\n NEW Title: ");
                string newTitle = GetUserInput();

                Console.Write("\nNEW Director: ");
                string newDirector = GetUserInput();

                Console.WriteLine("\nMovie Genres:\n" +
                    "1. Action\n" +
                    "2. Comedy\n" +
                    "3. Drama\n" +
                    "4. Horror\n" +
                    "5. Romance\n" +
                    "6. RomCom\n" +
                    "7. Thriller\n" +
                    "8. SciFi/Fantasy\n");

                Console.Write("\nSelect NEW Genre: ");
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

                Console.WriteLine("\nMovie Rating:\n" +
                    "1. G\n" +
                    "2. PG\n" +
                    "3. PG-13\n" +
                    "4. R\n" +
                    "5. MA\n");

                Console.Write("\nSelect NEW Movie Rating: ");
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

                Console.Write("\nNEW STARS: ");
                int newStars = GetUserInput();

                Movie updatedMovie = new Movie(newTitle, newDirector, newGenre, newIsKidFriendly, newRating, newStars);

                if (updatedMovie.Title.ToUpper() == movie.Title.ToUpper())
                {
                    bool isSuccess = _movieRepo.UpdateMovie(updatedMovie);
                    Console.WriteLine($"Successfully updated {updatedMovie.Title}. Press any key to continue....");
                }
                else
                {
                    //HINT: THINK ABOUT SCOPE
                    isSuccess = _movieRepo.UpdateMovie(updatedMovie, movie.Title);
                    Console.WriteLine($"Successfully updated {updatedMovie.Title}. Press any key to continue....");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("We couldn't find that movie. Press any key to continue....");
                Console.ReadKey();
            }
        }

        private void DeleteMovie()
        {
            Console.Write("\nEnter title of movie to delete: ");
            string input = GetUserInput();

            //HINT: YOU WON'T FIX THIS RED SQUIGGLY IN THIS FILE
            bool isSuccess = _movieRepo.DeleteMovieByTitle(input);

            if (isSuccess)
            {
                Console.WriteLine("Movie successfully deleted. Press any key to continue....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("We couldn't find that movie. Press any key to continue....");
                Console.ReadKey();
            }

        }

        public void ExitApplication()
        {
            Console.WriteLine("We hate to see you go. Press any key to EXIT....");
            Console.ReadKey();
        }
        //next method
    }
}