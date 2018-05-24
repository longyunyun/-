using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MyBricks
{/// <summary>
/// 小球类
/// </summary>
    class Ball
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

        const int MyWidth = 20;
        const int MyHeight = 20;
        public Rectangle rectangle
        {
            get
            {
                return new Rectangle(Left, Top, MyWidth, MyHeight);
            }
        }
        public Ball(int width, int height)
        {
            GameWidth = width;
            GameHeight = height;
            Left = GameWidth / 2 - 10;
            Top = GameHeight - 100;
        }
        public void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), rectangle);
        }
        /// <summary>
        /// 小球走一步
        /// </summary>
        public void Step()
        {
            this.Left += SpeedX;
            this.Top += SpeedY;
            //判断是否出界，如果出界，改速度
            if (this.Left<=0)
            {
                this.SpeedX *= -1;
                this.Left = 0;
            }
            //上边界
            if (this.Top<=0)
            {
                this.SpeedY *= -1;
                this.Top = 0;
            }
            //下边界
            if (this.Top+MyHeight>=GameHeight)
            {
                this.SpeedY *= -1;
                this.Top = GameHeight - MyHeight;
            }
            //右边界
            if (this.Left+MyWidth>=GameWidth)
            {
                this.SpeedX *= -1;
                this.Left = GameWidth - MyWidth;
            }
        }
    }
}
