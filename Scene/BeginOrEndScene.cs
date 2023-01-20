using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Game;

namespace 贪吃蛇.Scene
{
    class BeginOrEndScene : ISceneUpdate
    {
        protected string strTitle;
        protected string strOne;
        protected int currentIndex = 0;
        public void Update()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("开始或结束场景");
        }
    }
}
