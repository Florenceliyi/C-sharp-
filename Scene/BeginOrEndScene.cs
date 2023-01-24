using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Game;

namespace 贪吃蛇.Scene
{
    abstract class BeginOrEndScene : ISceneUpdate
    {
        protected string strTitle;
        protected string strOne;
        protected int currentIndex = 0;

        public abstract void EnterJDoSomething();
        public void Update()
        {
            //Console.SetCursorPosition(0, 0);
            //Console.Write("开始或结束场景");
            //显示标题C
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Game.Game.w / 2 - strTitle.Length, 5);
            Console.Write(strTitle);
            //显示下方选项
            Console.SetCursorPosition(Game.Game.w / 2 - strOne.Length, 8);
            Console.ForegroundColor = currentIndex == 0 ?ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);

            Console.SetCursorPosition(Game.Game.w / 2 - 4, 10);
            Console.ForegroundColor = currentIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");
            //检测输入
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --currentIndex;
                    if(currentIndex < 0)
                    {
                        currentIndex = 0;
                    }
                    break;
                 case ConsoleKey.S:
                    ++currentIndex;
                    if(currentIndex > 1)
                    {
                        currentIndex = 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    EnterJDoSomething();
                    break;
            }
            Console.WriteLine(currentIndex);
        }
    }
}
