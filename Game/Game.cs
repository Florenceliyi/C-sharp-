using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Scene;

namespace 贪吃蛇.Game
{
    /// <summary>
    /// 场景类型枚举
    /// </summary>
    enum E_SceneType
    {
        Begin,
        Game,
        End
    }
    class Game
    {
        public int w = 40;
        public int h = 20;
        //当前选中的场景
        public ISceneUpdate currentScene;
        //构造函数
        public Game()
        {
            Console.CursorVisible  = false;
            Console.SetCursorPosition(w, h);
            //Console.SetBufferSize(w, h);

            //初始化场景
            changeScene(E_SceneType.Begin);

        }

        //游戏开始的方法
        public void Start()
        {
            while(true)
            {
                if (currentScene != null)
                {
                    currentScene.Update();
                }
            }
        }

        //切换场景的方法
        public void changeScene(E_SceneType type)
        {
            Console.Clear();

            switch (type)
            {
                case E_SceneType.Begin:
                    currentScene = new BeginOrEndScene();
                    break;
                case E_SceneType.Game:
                    currentScene = new GameScene();
                    break;
                case E_SceneType.End:
                    currentScene = new BeginOrEndScene();
                    break;
                default:
                    break;
            }
        }
    }
}
