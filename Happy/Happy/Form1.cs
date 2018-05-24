
 
using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.Media;  
  
namespace JellyCancellation
{
    public partial class JellyCancellation : Form
    {

        private int _height = 10;//地图大小  
        private int _width = 8;
        private Jelly[,] _map = new Jelly[11, 9];//储存地图信息  
        private int _size = 40;//每一格宽度  
        private Point _topleft = new Point(40, 100);//记录左上角坐标  
        private int _istart = 0;//记录游戏是否开始  
        private int _stop = 0;
        private int _ispic = 0;//记录是否选中方块  
        private int _pickRow = 0;//记录选中的行  
        private int _pickCol = 0;//记录选中的列  
        private int _dropRow = 0;
        private int _dropCol = 0;
        private int _changeFlag = 0;//记录是否交换成功  


        private Jelly j1 = new Jelly(jcolor.无, new Point(0, 0), 40, 0);//临时交换用  
        private Jelly j2 = new Jelly(jcolor.无, new Point(0, 0), 40, 0);
        private int _x1 = 0;
        private int _y1 = 0;
        private int _x2 = 0;
        private int _y2 = 0;

        private int _time = 40;//记录时间  
        private int _step = 8;//交换移动步长  

    
        public void BuildMap()//随机生成地图  
        {
            Random myRand = new Random(DateTime.Now.Second);
            for (int i = 1; i <= _height; i++)
                for (int j = 1; j <= _width; j++)
                {
                    _map[i, j] = new Jelly((jcolor)myRand.Next(1, 7), new Point(_topleft.X + (j - 1) * _size, _topleft.Y + (i - 1) * _size), _size, 0);
                }
        }
        public void DrawMap(Graphics g)//绘制出地图  
        {
            for (int i = 1; i <= _height; i++)
                for (int j = 1; j <= _width; j++)
                {
                    _map[i, j].Drawme(g);
                }
        }

        //获取与用户鼠标点击位置距离最近的棋盘交叉点的行号和列号  
        public bool ConvertPointToRowCol(Point point, out int row, out int col)
        {
            int tempRow = (point.Y - _topleft.Y) / _size + 1;
            int tempCol = (point.X - _topleft.X) / _size + 1;
            if ((tempRow <= 10) && (tempRow >= 1) && (tempCol <= 8) && (tempCol >= 1))
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

        //消除图中方块  
        public bool clean()
        {

            int tot = 0;
            bool isclean = false;
            //初始化消除标记  
            for (int i = 1; i <= _height; i++)
                for (int j = 1; j <= _width; j++)
                {
                    _map[i, j]._Willclean = 0;
                }

            //遍历每个方格，每个都向右向下搜索  
            for (int i = 1; i <= _height; i++)
                for (int j = 1; j <= _width; j++)
                {
                    if (_map[i, j]._Color != jcolor.无)//如果有颜色则搜索  
                    {
                        //纵向搜  
                        int cnt = 1;//记录相连的同色方块个数  
                        int x = i + 1;
                        while (x <= _height)
                        {
                            if (_map[x, j]._Color == _map[i, j]._Color)//如果颜色相同记录个数  
                            { x++; cnt++; }
                            else break;
                        }
                        if (cnt >= 3)//如果大于等于3个，标记将消除   
                        {
                            isclean = true;
                            for (int k = i; k < i + cnt; k++)
                                _map[k, j]._Willclean = 1;
                            tot += cnt;
                        }
                        //横向搜  
                        cnt = 1;
                        int y = j + 1;
                        while (y <= _width)
                        {
                            if (_map[i, y]._Color == _map[i, j]._Color)//如果颜色相同记录个数  
                            { y++; cnt++; }
                            else break;
                        }
                        if (cnt >= 3)//如果大于等于3个，标记将消除  
                        {
                            isclean = true;
                            for (int k = j; k < j + cnt; k++)
                                _map[i, k]._Willclean = 1;
                            tot += cnt;
                        }
                    }
                }
            //注意这里一定要先标记再同意消除，如果直接在上面消除，会导致十字不可消  
            for (int i = 1; i <= _height; i++)//将待消除的方块消除  
                for (int j = 1; j <= _width; j++)
                {
                    if (_map[i, j]._Willclean == 1)
                        _map[i, j]._Color = jcolor.无;
                }
         

       
            return isclean;//返回是否可消  
        }

        //交换方块颜色  
        public void swap(int x, int y, int tox, int toy)
        {
            //交换的实质是两个颜色的互换  
            jcolor color = _map[x, y]._Color;
            _map[x, y]._Color = _map[tox, toy]._Color;
            _map[tox, toy]._Color = color;
            
        }

        //构造函数  
        public JellyCancellation()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

        }

        //游戏开始  
        private void BeginMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap("Image\\mouse.png");//自定义鼠标  
            SetCursor(a, new Point(0, 0));
          
            BuildMap();//随机生成地图  
            _istart = 1;//标记游戏开始  
            _stop = 0;
            _time = 40;//初始化时间  
            _money = 0;
            _point = 0;
            pictureBox1.Invalidate();
            timer3.Enabled = true;//生成的图可能能消除，刷新  
            timer1.Enabled = true;//开始计时  
        }


   

        //绘制函数  
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_istart == 1)//如果已经开始，画出图  
                DrawMap(e.Graphics);
            if (timer2.Enabled == true) //如果正在交换 画出临时变量  
            {
                j1.Drawme(e.Graphics);
                j2.Drawme(e.Graphics);
            }
        }

        //鼠标点击  
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (timer3.Enabled == false && _istart == 1 && _stop == 0)
            {
               
                if (_ispic == 0)//如果没有点击过，标记点击位置  
                {
                    int row, col;
                    bool value = ConvertPointToRowCol(new Point(e.X, e.Y), out row, out col); //捕捉行列  
                    if (value == true)
                    {
                        if (_map[row, col]._Color != jcolor.无) //如果不是无，就选择  
                        {
                            _pickRow = row;
                            _pickCol = col;
                            _ispic = 1;
                            _map[_pickRow, _pickCol].change();//将选择方块变样子  
                        }
                    }
                }
                else//如果已经点击过  
                {
                    int row, col;
                    bool value = ConvertPointToRowCol(new Point(e.X, e.Y), out row, out col);
                    if (value == true)
                    {
                        if (_map[row, col]._Color != jcolor.无)
                        {
                            //如果点击和标记位置相连，交换  
                            if ((row == _pickRow && Math.Abs(col - _pickCol) == 1) || (col == _pickCol && Math.Abs(row - _pickRow) == 1))
                            {
                                _dropRow = row;
                                _dropCol = col;
                                _map[_pickRow, _pickCol]._Flag = 0;
                                j1 = new Jelly(_map[_pickRow, _pickCol]._Color, _map[_pickRow, _pickCol]._Top, _map[_pickRow, _pickCol]._Size, _map[_pickRow, _pickCol]._Flag);
                                j2 = new Jelly(_map[_dropRow, _dropCol]._Color, _map[_dropRow, _dropCol]._Top, _map[_dropRow, _dropCol]._Size, _map[_dropRow, _dropCol]._Flag);
                                //  swap(row, col, _pickRow, _pickCol);  
                                _map[_pickRow, _pickCol]._Color = jcolor.无;//交换好了先隐藏  
                                _map[_dropRow, _dropCol]._Color = jcolor.无;

                                pictureBox1.Invalidate();

                                _x1 = j1._Top.X;//记录一系列临时变量  
                                _y1 = j1._Top.Y;
                                _x2 = j2._Top.X;
                                _y2 = j2._Top.Y;
                                _changeFlag = 0;
                                timer1.Enabled = false;//暂停计时  
                                timer2.Enabled = true;//执行交换  


                            }
                            else//不相邻就重新标记  
                            {
                                _map[_pickRow, _pickCol]._Flag = 0;
                                _pickRow = row;
                                _pickCol = col;
                                _map[_pickRow, _pickCol].change();
                                _ispic = 1;
                            }
                        }
                    }

                }
            }

            pictureBox1.Invalidate();
        }

    
        //执行交换  
        private void timer2_Tick(object sender, EventArgs e)
        {

            pictureBox1.Invalidate();
            int flag = 0;

            if (_y1 == _y2)
            {
                if (_x1 < _x2)
                {
                    j1._Top = new Point(j1._Top.X + _step, j1._Top.Y);
                    j2._Top = new Point(j2._Top.X - _step, j2._Top.Y);
                    if (j1._Top.X >= _x2)
                        flag = 1;
                }
                else
                {
                    j1._Top = new Point(j1._Top.X - _step, j1._Top.Y);
                    j2._Top = new Point(j2._Top.X + _step, j2._Top.Y);
                    if (j1._Top.X <= _x2)
                        flag = 1;

                }

            }
            else if (_x1 == _x2)
            {
                if (_y1 < _y2)
                {
                    j1._Top = new Point(j1._Top.X, j1._Top.Y + _step);
                    j2._Top = new Point(j2._Top.X, j2._Top.Y - _step);
                    if (j1._Top.Y >= _y2)
                        flag = 1;
                }
                else
                {
                    j1._Top = new Point(j1._Top.X, j1._Top.Y - _step);
                    j2._Top = new Point(j2._Top.X, j2._Top.Y + _step);
                    if (j1._Top.Y <= _y2)
                        flag = 1;
                }
            }
            if (flag == 1)//如果交换好了  
            {
                timer2.Enabled = false;//关闭交换计时器  
                timer1.Enabled = true;//继续计时  
                _map[_pickRow, _pickCol]._Color = j2._Color;
                _map[_dropRow, _dropCol]._Color = j1._Color;
                pictureBox1.Invalidate();
                if (_changeFlag == 0)
                {
                    if (!clean())//如果不能消除那么换回来,重新标记  
                    {
                        j1 = new Jelly(_map[_pickRow, _pickCol]._Color, _map[_pickRow, _pickCol]._Top, _map[_pickRow, _pickCol]._Size, _map[_pickRow, _pickCol]._Flag);
                        j2 = new Jelly(_map[_dropRow, _dropCol]._Color, _map[_dropRow, _dropCol]._Top, _map[_dropRow, _dropCol]._Size, _map[_dropRow, _dropCol]._Flag);
                        // swap(_dropRow, _dropCol, _pickRow, _pickCol);  
                        _map[_pickRow, _pickCol]._Color = jcolor.无;//交换好了先隐藏  
                        _map[_dropRow, _dropCol]._Color = jcolor.无;
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        _map[_pickRow, _pickCol]._Flag = 0;
                        _ispic = 0;
                        _changeFlag = 1;
                    }
                    else//交换成功  
                    {
                        timer3.Enabled = true;//执行下落  

                        _pickRow = 0;
                        _pickCol = 0;
                        _ispic = 0;

                    }
                }
            }
        }

        //执行下落 及判断是否还可消  
        private void timer3_Tick(object sender, EventArgs e)
        {
            //搜索每一列，把最下面的空白慢慢换上来，类似冒泡排序  
            for (int j = 1; j <= _width; j++)
            {
                for (int i = _height; i >= 2; i--)
                {
                    if (_map[i, j]._Color == jcolor.无)
                    {
                        for (int k = i; k >= 2; k--)
                            swap(k, j, k - 1, j);
                        break;
                    }
                }
            }

            //空白的第一行随机生成  
            Random myRand = new Random();
            for (int j = 1; j <= _width; j++)
                if (_map[1, j]._Color == jcolor.无)
                    _map[1, j]._Color = (jcolor)myRand.Next(1, 7);
            pictureBox1.Invalidate();
            int flag = 0;//判断是否还能下落  
            for (int i = 1; i <= _height; i++)
            {
                for (int j = 1; j <= _width; j++)
                {
                    if (_map[i, j]._Color == jcolor.无)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                    break;
            }
            if (flag == 0)//果果不能下落了  
            {
                if (!clean())//判断是否还可消 如果不可消，下落结束  
                    timer3.Enabled = false;
            }
        }

    


    }
    public enum jcolor
    {
        无 = 0, 黄 = 1, 蓝 = 2, 绿 = 3, 紫 = 4, 红 = 5, 褐 = 6
    }

    class Jelly
    {
        private jcolor _color;//方块颜色
        public jcolor _Color
        {
            get { return _color; }
            set { _color = value; }
        }
        private Point _top;//左上角坐标

        public Point _Top
        {
            get { return _top; }
            set { _top = value; }
        }

        private int _size = 40;//大小

        public int _Size
        {
            get { return _size; }
            set { _size = value; }
        }

        // private Bitmap[] picture=new Bitmap[6];
        private Bitmap _nowpic = new Bitmap(40, 40);//现在的图片

        public Bitmap _Nowpic
        {
            get { return _nowpic; }
            set { _nowpic = value; }
        }

        private int _flag;//是否被选中

        public int _Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }


        private int _willclean;//是否将消除

        public int _Willclean
        {
            get { return _willclean; }
            set { _willclean = value; }
        }



        private Bitmap[] _picture = new Bitmap[7];//储存位图
        private Bitmap[] _pickpic = new Bitmap[7];

        //构造函数
        public Jelly(jcolor color, Point top, int size, int flag)
        {
            _color = color;
            _top = top;
            _size = size;
            _flag = flag;
            for (int i = 0; i <= 6; i++)
            {
                _picture[i] = new Bitmap("Image\\" + ((jcolor)i).ToString() + ".jpg");
            }
            for (int i = 1; i <= 6; i++)
            {
                _pickpic[i] = new Bitmap("Image\\" + ((jcolor)i).ToString() + "2.jpg");
            }
            _nowpic = _picture[(int)_color];
        }



        public void Drawme(Graphics g)//绘制方块
        {

            if (_flag == 0)//如果被选中改变图片
            {
                _nowpic = _picture[(int)_color];
                _nowpic.MakeTransparent(Color.White);
            }
            g.DrawImage(_nowpic, _top);

        }

        public void change()//改变图片样子
        {
            if (_color != jcolor.无)
            {
                _nowpic = _pickpic[(int)_color];
                _nowpic.MakeTransparent(Color.White);
                _flag = 1;
            }
        }


    }
}

