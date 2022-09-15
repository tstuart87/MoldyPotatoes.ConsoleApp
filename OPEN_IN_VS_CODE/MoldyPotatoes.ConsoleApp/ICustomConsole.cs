using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{
    public interface ICustomConsole
    {
        //An INTERFACE is a CONTRACT that classes can 'implement', and then those classes have to abide by the rules of the contract.

        void MainMenu();
        void EnterSelection();
        void CreateNewMovie();
        void Title();
        void Director();
        void AllGenreList();
        void SelectGenre();
        void AllMovieRatingsList();
        void SelectMovieRating();
        void NumberOfStars();
        void PrintAMovie(Movie movie);
        void PressAnyKeyToContinue();
        void CouldntFindMovie();
        void TheWordNew();
        void SuccessfullyUpdated(Movie movie);
        void MovieToDelete();
        void MovieSuccessfullyDeleted();
        void ExitApplication();
    }
}