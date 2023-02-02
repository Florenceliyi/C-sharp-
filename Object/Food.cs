using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Draw;
using 贪吃蛇.SnakeObject;
using 贪吃蛇.Game;



namespace 贪吃蛇.Object
{
    class Food : GameObject
    {

        public Food(Snake snake)
        {
            RandowPos(snake);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }

        //随机位置的行为和蛇的位置有关系
        public void RandowPos(Snake snake)
        {
            //食物随机位置
            Random r = new Random();
            int x = r.Next(2, Game.Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.Game.h - 4);
            //得到蛇的位置
            pos = new Position(x, y);

            //如果重合的情况
            if(snake.CheckSamePos(pos))
            {
                RandowPos(snake);
            }
        }
    }
}
