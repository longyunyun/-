using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheBrickHappily

{


    /// <summary>
    /// 游戏类
    /// </summary>
    class Game
    {

        const int X = 8;
        const int Y = 8;
        public int Width { get; set; }//宽
        public int Height { get; set; }//高

        private Map Map { get { return map; } set { map = value; } }
     
        private  int swaping = 0;//记录是否在交换
        private  int start = 0;//记录是否开始
        public Map map = new Map(X, Y);


        private Brick j1 = new Brick(BrickColor.无, new Point(0, 0), 40, 0);//临时交换用
        private Brick j2 = new Brick(BrickColor.无, new Point(0, 0), 40, 0);
    

        private int _ispic;//记录是否选中方块
        private int _pickRow = 0;//记录选中的行
        private int _pickCol = 0;//记录选中的列
        private int _dropRow = 0;
        private int _dropCol = 0;
   
        public Game(int width, int height)
        {
            Width = width;
            Height = height;
        }
       
        /// <summary>
        /// 画地图
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            start = 1;//标记游戏开始

            if (start == 1)//如果已经开始，画出图
                map.MapDraw(g);

            if (swaping == 1) //如果正在交换 画出临时变量
            {
                j1.Draw(g);
                j2.Draw(g);
            }
        }
        /// <summary>
        /// 判断是否能消除
        /// </summary>
        /// <returns></returns>
        public bool isclean(Graphics g )
        {
            int tot = 0;
            bool isclean = false;
            //初始化消除标记
            for (int i = 1; i <= X; i++)
                for (int j = 1; j <= Y; j++)
                {

                    map.brick[i, j]._Willclean = 0;
                }

            //遍历每个方格，每个都向右向下搜索
            for (int i = 1; i <= X; i++)
                for (int j = 1; j <= Y; j++)
                {

                    if (map.brick[i, j].BrickColor != BrickColor.无)//如果有颜色则搜索
                    {
                        //纵向搜
                        int cnt = 1;//记录相连的同色方块个数
                        int x = i + 1;
                        while (x <= X)
                        {
                            if (map.brick[x, j].BrickColor == map.brick[i, j].BrickColor)//如果颜色相同记录个数
                            { x++; cnt++; }
                            else break;
                        }
                        if (cnt >= 3)//如果大于等于3个，标记将消除
                        {
                            isclean = true;
                            for (int k = i; k < i + cnt; k++)
                            {
                                map.brick[k, j]._Willclean = 1;
                             
                                tot += cnt;
                            }
                        }
                        //横向搜
                        cnt = 1;
                        int y = j + 1;
                        while (y <= Y)
                        {
                            if (map.brick[i, y].BrickColor == map.brick[i, j].BrickColor)//如果颜色相同记录个数
                            { y++; cnt++; }
                            else break;
                        }
                        if (cnt >= 3)//如果大于等于3个，标记将消除
                        {
                            isclean = true;
                            for (int k = j; k < j + cnt; k++)
                            {
                                map.brick[i, k]._Willclean = 1;
                              
                                tot += cnt;
                            }
                        }
                    }
                }
            //注意这里一定要先标记再同意消除，如果直接在上面消除，会导致十字不可消
            for (int i = 1; i <= X; i++)//将待消除的方块消除
                for (int j = 1; j <= Y; j++)
                {
                    if (map.brick[i, j]._Willclean == 1)
                        map.brick[i, j].BrickColor = BrickColor.无;
                    map.brick[i, j].Draw(g);
                }

            return isclean;//返回是否可消
        }
   
        private bool flag = true ;
       public void Down(Graphics g)
        {
            
          
            //搜索每一列，把最下面的空白慢慢换上来，类似冒泡排序
            do
            {
                for (int j = 1; j <= Y; j++)
                {
                    for (int i = X; i >= 2; i--)
                    {
                        if (map.brick[i, j].BrickColor == BrickColor.无)
                        {
                            for (int k = i; k >= 2; k--)
                            {
                                swap(k, j, k - 1, j);
                                    map.brick[k, j].Draw(g);
                                    map.brick[k-1, j].Draw(g);


                                    break;

                            }

                            }
                        }
                }
                //空白的第一行随机生成
                Random myRand = new Random();
                    for (int j = 1; j <= Y; j++)
                    {
                        if (map.brick[1, j].BrickColor == BrickColor.无)
                        { map.brick[1, j].BrickColor = (BrickColor)myRand.Next(1, 5);
                            map.brick[1, j].Draw(g);

                        }

                    }
                flag = false;
                for (int i = 1; i <= X; i++)
                {
                    for (int j = 1; j <= X; j++)
                    {
                        if (map.brick[i, j].BrickColor == BrickColor.无)
                        {
                            flag = true;
                            break;
                        }
                       
                    }
                   
                }
            } while (flag || isclean(g));

           
              
           

        }   
        /// <summary>
        /// 交换方块颜色
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="tox"></param>
        /// <param name="toy"></param>
        public void swap(int x, int y, int tox, int toy)
        {
            //交换的实质是两个颜色的互换
            BrickColor color = map.brick[x, y].BrickColor;
            map.brick[x, y].BrickColor = map.brick[tox, toy].BrickColor;
            map.brick[tox, toy].BrickColor = color;


        }

        public void Mouse(int X, int Y, Graphics g)
        {

            if (start == 1)
            {


                if (_ispic == 0)//如果没有点击过，标记点击位置
                {
                    int row, col;
                    bool value = map.ConvertPointToRowCol(new Point(X, Y), out row, out col); //捕捉行列
                    if (value == true)
                    {
                        if (map.brick[row, col].BrickColor != BrickColor.无) //如果不是无，就选择
                        {
                            _pickRow = row;
                            _pickCol = col;
                            _ispic = 1;
                        
                        }
                    }
                }
                else//如果已经点击过
                {
                    int row, col;
                    bool value = map.ConvertPointToRowCol(new Point(X, Y), out row, out col);
                    if (value == true)
                    {
                        if (map.brick[row, col].BrickColor != BrickColor.无)
                        {
                            //如果点击和标记位置相连，交换
                            if ((row == _pickRow && Math.Abs(col - _pickCol) == 1) || (col == _pickCol && Math.Abs(row - _pickRow) == 1))
                            {
                                _dropRow = row;
                                _dropCol = col;
                                map.brick[_pickRow, _pickCol]._Flag = 0;
                           
                                swap(row, col, _pickRow, _pickCol);
                      
                                map.MapDraw(g);


                        

                                swaping = 1;
                              

                                if (!isclean(g))//如果不能消除那么换回来,重新标记
                                {
                              
                                    swap(_dropRow, _dropCol, _pickRow, _pickCol);
                              
                                    swaping = 1;
                                    map.brick[_pickRow, _pickCol]._Flag = 0;
                                    _ispic = 0;
                                }
                                else//交换成功
                                {
                                    Down(g);
                                    _pickRow = 0;
                                    _pickCol = 0;
                                    _ispic = 0;

                                }

                            }
                            else//不相邻就重新标记
                            {
                                map.brick[_pickRow, _pickCol]._Flag = 0;
                                _pickRow = row;
                                _pickCol = col;
                                map.brick[_pickRow, _pickCol].change();
                                _ispic = 1;
                            }
                        }
                    }
                    map.MapDraw(g);

                }
            }
        }
     
    }
}

