using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheBrickHappily
{
    public enum BrickColor
    {
        无 = 0, 白 = 1, 蓝 = 2, 粉 = 3,紫=4,特效=5
    }
    class Brick
    {     /// <summary>
          /// 游戏区域
          /// </summary>
        public int GameWidth { get; set; }
        /// <summary>
        /// 游戏区域
        /// </summary>
        public int GameHeight { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int _Willclean { get; set; }
        public  int _Size { get; set; }
        public int flag;
        public int _Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public BrickColor BrickColor { get; set; }
        private Point _topleft = new Point(40, 100);//记录左上角坐标  
        private Bitmap[] picture = new Bitmap[6];//储存位图
        private Bitmap nowpic = new Bitmap(40, 40);//现在的图片
        private int _size = 40;//每一格宽度  
        private Point _top;//左上角坐标

        public Point _Top
        {
            get { return _top; }
            set { _top = value; }
        }

 
        public Brick(BrickColor color, Point top, int width, int height)
        {
            GameWidth = width;
            GameHeight = height;
            Left = GameWidth / 2 - 10;
            Top = GameHeight - 100;
            _top = top;
            BrickColor = color;
           picture[1] = new Bitmap(Properties.Resources._1);
            picture[2] = new Bitmap(Properties.Resources._2);
            picture[3] = new Bitmap(Properties.Resources._3);
            picture[4] = new Bitmap(Properties.Resources._4);
            picture[0] = new Bitmap(Properties.Resources._0);
            picture[5] = new Bitmap(Properties.Resources.边框特效004_7);

            nowpic = picture[(int)color];//当前图片颜色
        }
        public void Draw(Graphics g)
        {
          
           if (BrickColor==0)
            {
                 g.DrawImage(Properties.Resources._0, _top.X, _top.Y, _size, _size);

            }
            if (BrickColor == BrickColor.白)
            {
                g.DrawImage(Properties.Resources._1, _top.X, _top.Y, _size, _size);

            }
            if (BrickColor == BrickColor.粉)
            {
                g.DrawImage(Properties.Resources._3, _top.X, _top.Y, _size, _size);

            }
            if (BrickColor == BrickColor.紫)
            {
                g.DrawImage(Properties.Resources._4, _top.X, _top.Y, _size, _size);

            }
            if (BrickColor == BrickColor.蓝)
            {
                g.DrawImage(Properties.Resources._2, _top.X, _top.Y, _size, _size);

            }
            if (BrickColor == BrickColor.特效)
            {
                g.DrawImage(Properties.Resources.边框特效004_7, _top.X, _top.Y, _size, _size);

            }

        }
        public void change()//改变图片样子
        {
            if (BrickColor != BrickColor.无)
            {
                nowpic = picture[(int)BrickColor];
                nowpic.MakeTransparent(Color.White);
                flag = 1;
            }
        }

    }
}
