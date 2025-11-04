using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    public class Ball
    {
        //budget vector2 for pos and velocity
        public (int x, int y) position;
        (int x, int y) velocity;
        //konstructor for pos and vel starting
        public Ball((int x, int y) pos, (int x, int y) vel)
        {
            position = pos;
            velocity = vel;
        }
        //moving
        public void Move(int height)
        {
            //create int nextPos for comparrison
            int nextPos = position.y + velocity.y;
            //if next pos is inside height paramaters move, else reverse y vel
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
        //undraw current pos
        public void UnDraw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write(' ');
        }
        //draw current pos
        public void Draw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write('o');
        }
        public void CheckCollisions(Paddle player1, Paddle player2, int width, int height)
        {
            //outside left paramaters restet pos and point increase
            if (position.x <= 0)
            {
                UnDraw();
                position = (width/2, height/2);
                player2.points++;
            }
            //outside right paramaters
            else if (position.x >= width - 1)
            {
                UnDraw();
                position = (width/2, height/2);
                player1.points++;
            }
            //if x pos is same, for each player size cheack y pos
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
            //if x pos is same, for each player size cheak y pos
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