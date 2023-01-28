using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 贪吃蛇.Draw
{
   abstract class GameObject : IDraw
    {
        //游戏对象位置
        public Position pos;

        //继承接口后把接口中的行为变成抽象行为
        //供子类去实现 因为是抽象行为所有子类中是必须去实现
        public abstract void Draw();
        
    }
}