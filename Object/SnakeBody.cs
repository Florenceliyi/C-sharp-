using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Draw;

namespace 贪吃蛇.Object
{
   enum E_SnakeBody_Type
    {
        Head,
        Body
    }
    class SnakeBody : GameObject
    {

        private E_SnakeBody_Type type;

        public SnakeBody(E_SnakeBody_Type type, int x, int y)
        {
            this.type = type;
            this.pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = type == E_SnakeBody_Type.Body ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write(type == E_SnakeBody_Type.Head ? "★" : "■");

        }

    }
}
