using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    public class Paddle
    {
        (int x, int y) position;
        int size;
        public Paddle((int x, int y) newPos, int newSize)
        {
            position = newPos;
            size = newSize;
        }
        void Move(int yAmount)
        {
            position.y += yAmount;
        }
        void Draw()
        {
            for (int i = -1; i < size - 1; i++)
            {
                Console.SetCursorPosition(position.x, position.y + i);
                Console.Write('|');
            }
        }
    }
}