using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Game;

namespace 贪吃蛇.Scene
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    class EndScene : BeginOrEndScene
    {
        public EndScene()
        {
            strTitle = "结束游戏";
            strOne = "回到开始界面";
        }

        public override void EnterJDoSomething()
        {
            //按j键
            if (currentIndex == 0)
            {
                Game.Game.changeScene(E_SceneType.Begin);
            }
            else
            {
                Environment.Exit(0);

            }
        }
    }
}
