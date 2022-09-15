using System;
using System.Collections.Generic;

namespace MoldyPotatoes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface variable
            ICustomConsole _console;

            Console.Write("1. Spanish\n" +
            "2. English\n" +
            "3. Francais");
            Console.Write("\nEnter Selection: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //setting that variable equal to a CLASS that implements that INTERFACE.
                    _console = new CustomConsoleES(); //spanish
                    break;
                case "2":
                    //setting that variable equal to a CLASS that implements that INTERFACE.
                    _console = new CustomConsole(); //english
                    break;
                default:
                    _console = new CustomConsole();
                    break;
            }

            UserInterface ui = new UserInterface(_console);

            ui.Run();
        }
    }
}

