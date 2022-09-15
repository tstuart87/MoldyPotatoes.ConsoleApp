using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{
    //CustomeConstole is IMPLEMENTING the ICustomConsole INTERFACE.
    //CLASS     :    INTERFACE
    public class CustomConsole : ICustomConsole
    {
        public void MainMenu()
        {
            Console.WriteLine("\n1. Add new movie.\n" +
                    "2. View all movies.\n" +
                    "3. View one movie.\n" +
                    "4. Edit movie.\n" +
                    "5. Delete movie.\n" +
                    "6. Exit.\n"
            );
        }

        public void EnterSelection()
        {
            Console.Write("Enter Selection: ");
        }

        public void CreateNewMovie()
        {
            Console.WriteLine("Create a NEW MOVIE:");
        }

        public void Title()
        {
            Console.Write("\nTitle: ");
        }

        public void Director()
        {
            Console.Write("\nDirector: ");
        }

        public void AllGenreList()
        {
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
        }

        public void SelectGenre()
        {
            Console.Write("\nSelect Genre: ");
        }

        public void AllMovieRatingsList()
        {
            Console.WriteLine("\nMovie Rating:\n" +
                    "1. G\n" +
                    "2. PG\n" +
                    "3. PG-13\n" +
                    "4. R\n" +
                    "5. MA\n"
            );
        }

        public void SelectMovieRating()
        {
            Console.Write("\nSelect Movie Rating: ");
        }

        public void NumberOfStars()
        {
            Console.Write("\nNumber of STARS: ");
        }

        public void PrintAMovie(Movie movie)
        {
            Console.WriteLine($"\n{movie.Title}\n" +
                    $"Directed by: {movie.DirectorName}\n" +
                    $"Genre: {movie.MovieGenre}\n" +
                    $"OK for Kiddos: {movie.IsKidFriendly}\n" +
                    $"Movie Rating: {movie.MovieRating}\n" +
                    $"Stars: {movie.Stars}/10\n"
            );
        }

        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue....");
        }

        public void CouldntFindMovie()
        {
            Console.WriteLine("We couldn't find the movie you were looking for.");
        }

        public void TheWordNew()
        {
            Console.Write("NEW:");
        }

        public void SuccessfullyUpdated(Movie movie)
        {
            Console.WriteLine($"Successfully updated {movie.Title}.");
        }

        public void MovieToDelete()
        {
            Console.WriteLine("DELETE:");
        }

        public void MovieSuccessfullyDeleted()
        {
            Console.WriteLine("Movie successfully deleted.");
        }

        public void ExitApplication()
        {
            Console.WriteLine("We hate to see you go. Press any key to EXIT....");
        }
        //
    }
}