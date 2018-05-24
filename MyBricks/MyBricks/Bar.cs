using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBricks
{
    class Bar
    {
        /// <summary>
        /// 游戏区域
        /// </summary>
        private int GameWidth { get; set; }
        /// <summary>
        /// 游戏区域
        /// </summary>
        private  int GameHeight { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        private int SpeedX = -5;
        private int SpeedY = -5;

        const int MyWidth = 200;
        const int MyHeight = 20;

        const int speed = 10;

        public Rectangle rectangle
        {
            get
            {
                return new Rectangle(Left, Top, MyWidth, MyHeight);
            }
        }
        public Bar(int width, int height)
        {
            GameWidth = width;
            GameHeight = height;
            Left = GameWidth / 2 - MyWidth / 2;
            Top = GameHeight - 80;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.White), rectangle);
        }
        public void move(string Key)
        {
            switch(Key){ case "A":
                    this.Left -= speed;
                    break;
                case "D":
                    this.Left += speed;
                    break;
                default:
                    break;



            }
        }
    }
}
