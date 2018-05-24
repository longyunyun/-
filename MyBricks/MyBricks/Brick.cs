using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBricks
{
    class Brick
    {
        /// <summary>
        /// 游戏区域
        /// </summary>
        public int GameWidth { get; set; }
        /// <summary>
        /// 游戏区域
        /// </summary>
        public int GameHeight { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        private int SpeedX = -5;
        private int SpeedY = -5;
         
        const int MyWidth = 40;
        const int MyHeight = 20;
        public Rectangle rectangle
        {
            get
            {
                return new Rectangle(Left, Top, MyWidth, MyHeight);
            }
        }
        public Brick (int width, int height,int mleft,int mtop)
        {
            GameWidth = width;
            GameHeight = height;
            Left = mleft;
            Top = mtop;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Yellow), rectangle);
        }
    }
}
