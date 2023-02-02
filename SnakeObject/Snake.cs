using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Draw;
using 贪吃蛇.Object;
using 贪吃蛇.Game;
using 贪吃蛇.MapObject;




/// <summary>
/// Summary description for Class1
/// </summary>
namespace 贪吃蛇.SnakeObject
{
    enum E_MoveDir
    {
        Up,
        Down,
        Left,
        Right
    }
    class Snake : IDraw
    {
        SnakeBody[] bodys;

        //当前移动的方向
        E_MoveDir dir;
        int currentNum;
        public Snake(int x, int y)
        {
            bodys = new SnakeBody[200];
            bodys[0] = new SnakeBody(E_SnakeBody_Type.Head, x, y);
            currentNum = 1;
            dir = E_MoveDir.Right;
        }

        public void Draw()
        {
            //画每一节的身子
            for (int i = 0; i < currentNum; i++)
            {
                bodys[i].Draw();
            }
        }

        

        public void Move()
        {
            //移动前擦除最后一个位置（擦屁股）
            SnakeBody lastBody = bodys[currentNum- 1];
            Console.SetCursorPosition(lastBody.pos.x, lastBody.pos.y);
            Console.Write("  ");

            //在蛇头移动之前从蛇尾开始不停让后一个位置等于前一个位置
            for (int i = currentNum; i > 0; i--)
            {
                bodys[i].pos = bodys[i - 1].pos;
            }

            switch (dir)
            {
                case E_MoveDir.Up:
                    --bodys[0].pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].pos.x += 2;
                    break;
                default:
                    break;
            }
        }

        public void ChangeDir(E_MoveDir dir)
        {
            //规则上只有头部可以上下左右动，有身子的时候不能反向动
            if(dir == this.dir || 
                currentNum > 1 &&
                (this.dir == E_MoveDir.Left && dir == E_MoveDir.Right ||
                this.dir == E_MoveDir.Up && dir == E_MoveDir.Down ||
                this.dir == E_MoveDir.Right && dir == E_MoveDir.Left ||
                this.dir == E_MoveDir.Down && dir == E_MoveDir.Up)
                ){
                return;
            }

            this.dir = dir;
        }

        #region 撞墙撞到身体结束逻辑
        public bool CheckEnd(Map map)
        {
            //是否和墙体位置重合
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }
            //是否和身体位置重合
            for (int i = 0; i < currentNum; i++)
            {
                if (bodys[0].pos == bodys[i].pos)
                {
                    return true;
                }
            }
                return false;
        }
        #endregion

        public bool CheckSamePos(Position p)
        {
            for(int i = 0; i < currentNum; i++)
            {
                if (bodys[i].pos == p)
                {
                    return true;
                }
            }
             return false;
        }

        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                food.RandowPos(this);

                AddBody();
            }
        }

        //长身体的逻辑
        private void AddBody()
        {
            SnakeBody frontBody = bodys[currentNum - 1];
            //先长
            bodys[currentNum] = new SnakeBody(E_SnakeBody_Type.Body, frontBody.pos.x, frontBody.pos.y);

            //再加长度
            ++currentNum;
        }
    }
}
