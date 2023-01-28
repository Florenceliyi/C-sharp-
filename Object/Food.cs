using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Draw;

namespace 贪吃蛇.Object
{
    class Food : GameObject
    {

        public Food(int x, int y)
        {
            pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }

        //随机位置的行为和蛇的位置有关系

    }
}
