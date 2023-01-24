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
        public const int w = 40;
        public const int h = 20;
        //当前选中的场景
        public static ISceneUpdate currentScene;
        //构造函数
        public Game()
        {
            Console.CursorVisible  = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            //初始化场景
            changeScene(E_SceneType.End);

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
        public static void changeScene(E_SceneType type)
        {
            Console.Clear();

            switch (type)
            {
                case E_SceneType.Begin:
                    currentScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    currentScene = new GameScene();
                    break;
                case E_SceneType.End:
                    currentScene = new EndScene();
                    break;
                default:
                    break;
            }
        }
    }
}
