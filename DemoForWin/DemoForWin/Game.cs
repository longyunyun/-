using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForWin
{
    class Game
    { 
        public void Draw (Graphics g)
        {
            g.DrawString(System.DateTime.Now.ToString(),
                new Font("宋体", 12),
                new SolidBrush(Color.Red),
               new Point(10, 10));
            g.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(100, 100), new Point(150, 49));
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), 39, 99, 56, 90);
            g.FillRectangle(new SolidBrush(Color.Red), 49, 44, 44, 44);
            g.DrawEllipse(new Pen(new SolidBrush(Color.Black)), 70, 70, 70, 70);
            g.DrawImage(Properties.Resources.白, new Point(30, 30));
        }
    }
}
