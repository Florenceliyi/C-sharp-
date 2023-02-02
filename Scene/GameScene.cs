using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Game;
using 贪吃蛇.MapObject;
using 贪吃蛇.SnakeObject;
using 贪吃蛇.MapObject;
using 贪吃蛇.Object;





namespace 贪吃蛇.Scene
{
    class GameScene: ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;

        //控制蛇的更新速度
        int updateIndex = 0;

        public GameScene ()
        {
            map = new Map();
            snake = new Snake(40, 10);
            food = new Food(snake);
        }
        public void Update()
        {
            if(updateIndex % 555555 == 0)
            {

                map.Draw();
                snake.Draw();
                snake.Move();
                updateIndex = 0;

                //检测是否撞墙
                if (snake.CheckEnd(map))
                {
                    Game.Game.changeScene(E_SceneType.End);
                }

                snake.CheckEatFood(food);
            }

            ++updateIndex;

            //在控制台钟检测玩家输入让程序不被检测卡住
            if(Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_MoveDir.Right);
                        break;
                    default:
                        break;
                }

            }
        }

        
    }
}
