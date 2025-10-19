namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;
        public Paddle player1 = new Paddle((1, 10), 3);
        public Paddle player2 = new Paddle((79, 10), 3);
        Ball ball = new Ball((20, 10),(1,1));

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
            player1.UnDraw();
            player2.UnDraw();
            if (Input.IsPressed(ConsoleKey.W))
                player1.MoveY(-1);
            if (Input.IsPressed(ConsoleKey.S))
                player1.MoveY(1);
            if (Input.IsPressed(ConsoleKey.UpArrow))
                player2.MoveY(-1);
            if (Input.IsPressed(ConsoleKey.DownArrow))
                player2.MoveY(1);

            player1.Draw(11);
            player2.Draw(69);
            ball.UnDraw();
            ball.Move();
            ball.Draw();
            ball.CheckCollisions(player1, player2, width, height);
            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
