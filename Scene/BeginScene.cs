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
    class BeginScene: BeginOrEndScene
    {
	    public BeginScene()
        {
            strTitle = "贪食蛇";
            strOne = "开始游戏";
        }

        public override void EnterJDoSomething()
        {
            //按j键
            if(currentIndex == 0)
            {
                Game.Game.changeScene(E_SceneType.Game);
            }else
            {
                Environment.Exit(0);
            }
        }
    }
}
