﻿using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Draw;
using 贪吃蛇.Map;
using 贪吃蛇.Game;
using 贪吃蛇.Object;


namespace 贪吃蛇.Map
{
    class Map: IDraw
    {
        private Wall[] walls;

        public Map()
        {
            walls = new Wall[Game.Game.w + (Game.Game.h - 3) * 2];
            int index = 0;
             for (int i = 0; i < Game.Game.w - 2; i+=2)
            {
                walls[index] = new Wall(i, 0);
                walls[index] = new Wall(i, Game.Game.h - 2);
                ++index;
            }

           /* for (int i = 0; i < Game.Game.w; i+=2)
            {
                ++index;
            }*/

            for (int i = 1; i < Game.Game.h - 2; i++)
            {
                walls[index] = new Wall(0, i);
                walls[index] = new Wall(Game.Game.w - 2, i);
                ++index;
            }

           /* for (int i = 1; i < Game.Game.h - 3; i++)
            {
                ++index;
            }*/
        }

        public void Draw()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].Draw();
            }
        }
    }
}
