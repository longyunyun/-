using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBricks
{/// <summary>
/// 游戏类
/// </summary>
    class Game
    {
        public int Width { get; set; }
        public int Height { get; set; }
        private Ball ball { get; set; }
       private  Bar bar { get; set; }
        private List<Brick> bricks { get; set; }
        /// <summary>
        /// 定义委托类型
        /// </summary>
        public delegate void GameOver();
        /// <summary>
        /// 定义事件
        /// </summary>
        public event GameOver gameover;
        public Game (int width,int height)
        {
            Width = width;
            Height = height;
            ball = new Ball(width, height);
            bar = new Bar(width, height);
            bricks = new List<Brick>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Brick brick1 = new Brick(width, height, 20+i*200, 20+j*40);
                    bricks.Add(brick1);
                }
            }
           

        }

        public void Draw(Graphics g)
        {
            g.Clear(Color.Black);

            ball.Draw(g);
            bar.Draw(g);
            foreach (var brick in bricks)
            {
                brick.Draw(g);

            }
        }
        /// <summary>
        /// 时针走一步
        /// </summary>
        public void Step()
        {
            //小球走一步
            ball.Step();
            //判断碰撞
            if (ball.rectangle.IntersectsWith(bar.rectangle))
            {
                ball.Recflect();
            }
            foreach (var brick in bricks)
            {
                if (ball.rectangle.IntersectsWith(brick.rectangle))
                {
                    ball.Recflect();
                    this.bricks.Remove(brick);
                    break;
                }
            }
            if (bricks.Count==0)
            {//游戏结束
                
                gameover();
            }
           
        }
        public void move(string key)
        {
            bar.move(key);
        }
    }
}
