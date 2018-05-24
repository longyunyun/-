﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockPaint
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {
            //画表盘
            Graphics g = this.panelFill.CreateGraphics();
            g.Clear(Color.White);

            Clock clock = new Clock();
            clock.OnStart(g, panelFill.Width / 2, panelFill.Height / 2);
            timer1.Tick += new EventHandler(Draw);
        }
        private void Draw(object sender, EventArgs e)
        {
            Graphics g = this.panelFill.CreateGraphics();
            Clock clock = new Clock();
            clock.OnDraw(g, panelFill.Width / 2, panelFill.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {

            Graphics g = this.panelFill.CreateGraphics();
            g.Clear(Color.White);
            Clock clock = new Clock();
            clock.OnStart(g, panelFill.Width / 2, panelFill.Height / 2);
            timer1.Tick += new EventHandler(Draw);


        }
    
    }
    class Clock
    {
        public void OnStart(Graphics g, int width, int height)
        {

            var center = new Point(width, height);
            int r = 100;
            g.FillEllipse(new SolidBrush(Color.White), width - r, height - r, 2 * r, 2 * r);
            g.DrawEllipse(new Pen(Color.Red, 1), width - r, height - r, 2 * r, 2 * r);
            for (int z = 0; z < 60; z++)
            {
                g.ResetTransform();
                g.TranslateTransform(width, height); //更改坐标原点
                g.RotateTransform(z * 6);  //旋转，每一秒旋转6度
                if (z % 5 == 0)
                    g.DrawLine(new Pen(Color.Black, 3.0f), r - 12, 0, r - 5, 0); //小时刻度             
                else
                    g.DrawLine(new Pen(Color.Black, 1.5f), r - 8, 0, r - 5, 0); //分钟标准刻度
            }
        }
        public void OnDraw(Graphics g, int width, int height)
        {
            int r = 80;
            g.FillEllipse(new SolidBrush(Color.White), width - r, height - r, 2 * r, 2 * r);
            int second = DateTime.Now.Second;//获取系统时间
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;
            g.ResetTransform();
            //画时针
            g.TranslateTransform(width, height);
            g.RotateTransform(second / 100 + minute / 10 + hour * 30 + 270);
            Pen hourPen = new Pen(Color.Black, 3);
            hourPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(hourPen, 0, 0, 35, 0);
            g.RotateTransform(-(second / 100 + minute / 10 + hour * 30 + 270));
            //分针
            g.RotateTransform(second / 10 + minute * 6 + 270);
            Pen minutePen = new Pen(Color.Black, 2);
            minutePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(minutePen, 0, 0, 40, 0);
            g.RotateTransform(-(second / 10 + minute * 6 + 270));
            //秒针
            g.RotateTransform(second * 6 + 270);
            Pen secondPen = new Pen(Color.Black, 2);
            secondPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(secondPen, 0, 0, 45, 0);
        }
    }
}
