using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width = 40;
        int height = 20;
        Paddle player1 = new Paddle((9, 10), 3);
        Paddle player2 = new Paddle((40, 10), 3);

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;
        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
