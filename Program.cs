using ConsoleRpg.GUI;
using System;


namespace ConsoleRpg
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            Gui.Title("Welcome to Rapid Tilting");
            game.Run();
        }
    }
}