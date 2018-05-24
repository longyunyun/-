using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheBrickHappily
{
   
    class Map
    {
        /// <summary>
        /// 游戏区域
        /// </summary>
        public int GameWidth { get; set; }
        /// <summary>
        /// 游戏区域
        /// </summary>
        public int GameHeight { get; set; }

        public Brick[,] brick = new Brick[9, 9];

        const int X = 8;
        const int Y = 8;

        private int _size = 40;//每一格宽度  
        private Point _topleft = new Point(40, 100);//记录左上角坐标  
        /// <summary>
        /// 随机生成地图
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public  Map(int X, int Y)
        {
            Random myRand = new Random();
            for (int i = 1; i <= X; i++)
                for (int j = 1; j <= Y; j++)
                {
                    brick[i, j] = new Brick((BrickColor)myRand.Next(1, 5),
                        new Point(_topleft.X + (j - 1) * _size, _topleft.Y + (i - 1) * _size), _size, _size);

                }
            return;
        }

     
         /// <summary>
         /// 画地图
         /// </summary>
         /// <param name="g"></param>
        public void MapDraw(Graphics g)
        {
            for (int i = 1; i <= X; i++)
                for (int j = 1; j <= Y; j++)
                {
                    brick[i,j].Draw(g);
                }
          
        }
        /// <summary>
        ///获取与用户鼠标点击位置距离最近的棋盘交叉点的行号和列号
        /// </summary>
        /// <param name="point"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool ConvertPointToRowCol(Point point, out int row, out int col)
        {
            int tempRow = (point.Y - _topleft.Y) / _size + 1;
            int tempCol = (point.X - _topleft.X) / _size + 1;
            if ((tempRow <= 8) && (tempRow >= 1) && (tempCol <= 8) && (tempCol >= 1))
            {
                //返回行号和列号，并返回true，表示该点击有效
                row = tempRow;
                col = tempCol;
                return true;
            }
            else
            {
                //把行号和列号都设置为-1，并返回false，表示无效点击
                row = -1;
                col = -1;
                return false;
            }
        }


    }
}
