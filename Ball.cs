using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    public class Ball
    {
        public (int x, int y) position;
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
            if (position.x <= 0)
            {
                UnDraw();
                position = (width/2, height/2);
                player2.points++;
            }
            else if (position.x >= width - 1)
            {
                UnDraw();
                position = (width/2, height/2);
                player1.points++;
            }
            if (position.x == player1.position.x)
            {
                for (int i = -1 / 2; i < player1.size; i++)
                {
                    if (position.y == player1.position.y + i)
                    {
                        velocity.x *= -1;
                        if (i != 0)
                            velocity.y = i;
                        break;
                    }
                }
            }
            else if (position.x == player2.position.x)
            {
                for (int i = -1; i < player2.size; i++)
                {
                    if (position.y == player2.position.y + i)
                    {
                        velocity.x *= -1;
                        if (i != 0)
                            velocity.y = i;
                            break;
                    }
                }
            }
        }
    }
}