using System;
using System.Collections.Generic;
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
        public void Move()
        {
            position.x += velocity.x;
            position.y += velocity.y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write('o');
        }
        public void CheckCollisions(Paddle player1, Paddle player2, int width, int height)
        {
            if (position.y == 20 || position.y == 0)
                velocity.y *= -1;
            if (position.x == 0 || position.x == width)
                position = (41, 20);
            if(position.x == player1.position.x || position.x == player2.position.x)
                velocity.x *= -1;
            
        }
    }
}