using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    public class Ball
    {
        (int x, int y) position;
        (int x, int y) velocity;
        public Ball((int x, int y) pos, (int x, int y) vel)
        {
            position = pos;
            velocity = vel;
        }
        public void Move(int height)
        {
            int nextPos = position.y + velocity.y;
            if (nextPos > -1 && nextPos < height)
            {
                position.x += velocity.x;
                position.y += velocity.y;
            }
            else
            {
                velocity.y *= -1;
            }
        }
        public void UnDraw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write(' ');
        }
        public void Draw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write('o');
        }
        public void CheckCollisions(Paddle player1, Paddle player2, int width, int height)
        {
            if (position.x == 0)
            {
                UnDraw();
                position = (Console.WindowWidth/2, Console.WindowHeight/2);
                player2.points++;
            }
            if (position.x == Console.WindowWidth)
            {
                UnDraw();
                position = (Console.WindowWidth/2, Console.WindowHeight/2);
                player1.points++;
            }
            if (position == player1.position || position == player2.position)
            {
                velocity.x *= -1;
                if (int.IsNegative(velocity.y))
                    velocity.y = -1;
                else
                    velocity.y = 1;
            }
            if (position == (player1.position.x, player1.position.y + player1.size/2) || position == (player2.position.x, player2.position.y + player2.size / 2))
            {
                velocity.x *= -1;
                velocity.y = 2;
            }
            if (position == (player1.position.x, player1.position.y - player1.size / 2) || position == (player2.position.x, player2.position.y - player2.size / 2))
            {
                velocity.x *= -1;
                velocity.y = -2;
            }
        }
    }
}