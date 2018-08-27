using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public abstract class GameObject
    {
        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public GameObject(int x, int y, int width, int height)
        {
            this.X = X;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        //move的方法，draw的方法
        //鸟是上下移动，管子是左右移动

        public abstract void Move();

        public abstract void Draw(Graphics g);
    }
}
