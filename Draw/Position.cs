using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇.Draw
{
    struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //结构体和类都可以运用重载运算符的方法去进行比较
        public static bool operator ==(Position p1, Position p2) {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return true;
        }

        public static bool operator !=(Position p1, Position p2) {
            if(p1.x == p2.x && p1.y == p2.y) {
                return false;
            }
            return false;
        }
    }
}
