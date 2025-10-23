using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    public class Paddle
    {
        public (int x, int y) position;
        public int size;
        public int points = 0;
        public Paddle((int x, int y) newPos, int newSize)
        {
            position = newPos;
            size = newSize;
        }
        public void MoveY(int yAmount, int height)
        {
            int newPosY = position.y + yAmount;

            // Clamp the paddle within the screen boundaries
            if (newPosY < 1)
                yAmount = 0;
            else if (newPosY >=  height - size/2)
                yAmount = 0;

            position.y += yAmount;
        }
        public void UnDraw()
        {
            for (int i = -1; i < size; i++)
            {
                Console.SetCursorPosition(position.x, position.y + i);
                Console.Write(' ');
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(position.x, Console.WindowHeight-1);
            Console.Write(points);
            for (int i = -1; i < size; i++)
            {
                Console.SetCursorPosition(position.x, position.y + i);
                Console.Write('|');
            }
        }
    }
}