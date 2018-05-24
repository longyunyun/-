using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
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
        public void pictureBox1_Click(object sender, EventArgs e)
        {//画表盘
            Graphics g=this.pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Clock clock = new Clock();
            clock.OnStart(g, pictureBox1.Width / 2, pictureBox1.Height / 2);
            timer1.Tick += new EventHandler(Draw);
        }
        private  void Draw(object sender, EventArgs e)
        {
            Graphics g=this.pictureBox1.CreateGraphics();
            Clock clock = new Clock();
            clock.OnDraw(g,pictureBox1.Width/2,pictureBox1.Height/2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {

            Graphics g=this.pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Clock clock = new Clock();
            clock.OnStart(g, pictureBox1.Width / 2, pictureBox1.Height / 2);
            timer1.Tick += new EventHandler(Draw);


        }
    }
}
