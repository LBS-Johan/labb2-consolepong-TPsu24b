using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    public class Paddle
    {
        public (int x, int y) position;
        int size;
        public Paddle((int x, int y) newPos, int newSize)
        {
            position = newPos;
            size = newSize;
        }
        public void MoveY(int yAmount)
        {
            if (position.y + yAmount - 1 == 19 || position.y + yAmount + 1 == 1)
            {
            }
            else
                position.y += yAmount;
        }
        public void Draw()
        {
            Console.SetCursorPosition(10, position.y);
            Console.Write(position.y);
            for (int i = -1; i < size - 1; i++)
            {
                Console.SetCursorPosition(position.x, position.y + i);
                Console.Write('|');
            }
        }
    }
}