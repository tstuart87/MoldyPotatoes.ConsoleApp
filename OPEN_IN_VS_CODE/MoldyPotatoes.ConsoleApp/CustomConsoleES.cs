using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;


namespace MoldyPotatoes.ConsoleApp
{
    //Spanish CustomConsole
    public class CustomConsoleES : ICustomConsole
    {
        public void MainMenu()
        {
            Console.WriteLine("\n1. Pelicula Nueva.\n" +
                    "2. Vea todas las peliculas.\n" +
                    "3. Vea una pelicula.\n" +
                    "4. Edita una pelicula.\n" +
                    "5. Elimina una pelicula.\n" +
                    "6. Salida.\n"
            );
        }

        public void EnterSelection()
        {
            Console.Write("Entre una seleccion: ");
        }

        public void CreateNewMovie()
        {
            Console.WriteLine("Creatar una pelicula nueva:");
        }

        public void Title()
        {
            Console.Write("\nTitulo: ");
        }

        public void Director()
        {
            Console.Write("\n:Director");
        }

        public void AllGenreList()
        {
            Console.WriteLine("\nPelicula Genres:\n" +
                    "1. Accion\n" +
                    "2. Comedia\n" +
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
            Console.Write("\nEleja Genre: ");
        }

        public void AllMovieRatingsList()
        {
            Console.WriteLine("\nPelicula Rating:\n" +
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
            Console.Write("\nNumero de ESTRELLAS: ");
        }

        public void PrintAMovie(Movie movie)
        {
            Console.WriteLine($"\n{movie.Title}\n" +
                    $"Directado por: {movie.DirectorName}\n" +
                    $"Genre: {movie.MovieGenre}\n" +
                    $"Bien para los ninos: {movie.IsKidFriendly}\n" +
                    $"Movie Rating: {movie.MovieRating}\n" +
                    $"Estrellas: {movie.Stars}/10\n"
            );
        }

        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any tecla to continuar....");
        }

        public void CouldntFindMovie()
        {
            Console.WriteLine("We couldn't find the pelicula you were looking for.");
        }

        public void TheWordNew()
        {
            Console.Write("NUEVO:");
        }

        public void SuccessfullyUpdated(Movie movie)
        {
            Console.WriteLine($"Successfully updated {movie.Title}.");
        }

        public void MovieToDelete()
        {
            Console.WriteLine("ELIMINAR:");
        }

        public void MovieSuccessfullyDeleted()
        {
            Console.WriteLine("Pelicula successfully deleted.");
        }

        public void ExitApplication()
        {
            Console.WriteLine("We hate to see you go. Press any key to SALIDA....");
        }
    }
}