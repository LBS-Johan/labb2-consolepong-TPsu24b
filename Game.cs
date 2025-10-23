namespace Labb2_ConsolePong
{
    internal class Game
    {
        public int width, height;
        public Paddle player1 = new Paddle((1, 10), 2);
        public Paddle player2 = new Paddle((79, 10), 2);
        Ball ball = new Ball((20, 10),(1,1));

        public void StartGame()
        {
            // Setup konsol-fönstret
            Console.CursorVisible = false;
        }

        public bool Run()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            player2.position.x = width - 1;
            //Töm hela skärmen i början av varje uppdatering.
            player1.UnDraw();
            player2.UnDraw();
            if (Input.IsPressed(ConsoleKey.W))
                player1.MoveY(-1, height);
            if (Input.IsPressed(ConsoleKey.S))
                player1.MoveY(1, height);
            if (Input.IsPressed(ConsoleKey.UpArrow))
                player2.MoveY(-1, height);
            if (Input.IsPressed(ConsoleKey.DownArrow))
                player2.MoveY(1, height);

            player1.Draw();
            player2.Draw();
            ball.UnDraw();
            ball.Move(height);
            ball.Draw();
            ball.CheckCollisions(player1, player2, width, height);
            DrawCenterLine();
            //Return true om spelet ska fortsätta
            return true;

        }
        public void DrawCenterLine()
        {
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                if(i % 2 == 0)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, i);
                }
            }
        }
    }
}
