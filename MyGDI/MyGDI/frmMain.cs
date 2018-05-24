using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGDI
{
    public partial class frmMain : Form
    {/// <summary>
     /// 常量，指定界面显示的数据队列长度
     /// </summary>
        const int LengthOfQueue = 20;
        /// <summary>
        /// 常量，产生最大随机数
        /// </summary>
        const int MaxNumber = 100;
        /// <summary>
        ///保存数据的队列
        /// </summary>
        Queue<int> queue { get; set; }

        public frmMain()
        {
            InitializeComponent();
            //初始化队列
            this.queue = new Queue<int>();
            for (int i = 0; i < LengthOfQueue; i++)
            {
                queue.Enqueue(0);
            }
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// btuStart_Click响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btuStart_Click(object sender, EventArgs e)
        {
            //显示文字
            if (this.timer1.Enabled)
            {
                this.btuStart.Text = "开始";
            }
            else
                this.btuStart.Text = "停止";
            this.timer1.Enabled = !this.timer1.Enabled;

        }

        private void MyBox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            MyDraw();
            if (this.btuStart.Text == "停止")
            {
                this.timer1.Enabled = true;
            }
        }
        /// <summary>
        /// 产生随机数
        /// </summary>
        private void ChangeDate()
        {
            Random rnd = new Random();
            int newInt = rnd.Next(MaxNumber + 1);
            queue.Enqueue(newInt);
            queue.Dequeue();
        }
        private void MyDraw()
        {
            int intSpace = 100;

            //获得MyBox的Graphics对象
            Graphics g = this.MyBox.CreateGraphics();
            g.Clear(Color.Black);
            Pen pen = new Pen(Color.BlueViolet);
            Brush brush = new SolidBrush(Color.GreenYellow);
            g.DrawString(System.DateTime.Now.ToString(), new Font("宋体", 12), brush, new PointF(10, 10));
            
                ChangeDate();
                Rectangle rectangle = new Rectangle(intSpace, intSpace, this.MyBox.Width - intSpace * 2, this.MyBox.Height - intSpace * 2);
                g.FillRectangle(new SolidBrush(Color.Red), rectangle);
                var data = queue.ToArray();
                int intSmallWidth = rectangle.Width / (data.Length - 1);

                int intSmallHeight = rectangle.Height / MaxNumber;
                for (int i = 1; i < data.Length - 1; i++)
                {
                    Point point = new Point(intSpace + rectangle.Width - i * intSmallWidth, intSpace + rectangle.Height - data[i] * intSmallHeight);
                    Point point2 = new Point(intSpace + rectangle.Width - (i + 1) * intSmallWidth, intSpace + rectangle.Height - data[i+1] * intSmallHeight);
                    g.DrawLine(pen, point, point2);
                }
        
        }

    }
    
}
