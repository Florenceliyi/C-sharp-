using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Game;
using 贪吃蛇.Map;


namespace 贪吃蛇.Scene
{
    class GameScene: ISceneUpdate
    {
        Map.Map map;

        public GameScene ()
        {
            map = new Map.Map();
        }
        public void Update()
        {
            map.Draw();
        }
    }
}
