namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width = 81;
        int height = 40;
        Paddle player1 = new Paddle((0, 10), 3);
        Paddle player2 = new Paddle((81, 10), 3);
        Ball ball = new Ball((41, 20),(1,1));

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

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 1 uppåt
                player1.MoveY(-1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 1 nedåt
                player1.MoveY(1);
            }

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 2 uppåt
                player2.MoveY(-1);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 2 nedåt
                player2.MoveY(1);
            }
            player1.Draw();
            player2.Draw();
            ball.Move();
            ball.Draw();
            ball.CheckCollisions(player1, player2, width, height);
            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
