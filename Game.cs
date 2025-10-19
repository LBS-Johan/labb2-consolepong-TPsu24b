namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width = 80;
        int height = 40;
        Paddle player1 = new Paddle((0, 10), 3);
        Paddle player2 = new Paddle((80, 10), 3);
        Ball ball = new Ball((20, 10),(1,1));

        public void StartGame()
        {
            // Setup konsol-fönstret
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;
        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();
            if (Input.IsPressed(ConsoleKey.W))
                player1.MoveY(-1);
            if (Input.IsPressed(ConsoleKey.S))
                player1.MoveY(1);
            if (Input.IsPressed(ConsoleKey.UpArrow))
                player2.MoveY(-1);
            if (Input.IsPressed(ConsoleKey.DownArrow))
                player2.MoveY(1);

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
