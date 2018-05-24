using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveTheBrickHappily
{
    public partial class frmMain : Form
    {
        private Game game;
        public frmMain()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(this.panelgame.Width, this.panelgame.Height);

        }
        /// <summary>
        /// 游戏开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new Game(this.panelgame.Width, this.panelgame.Height);

            Graphics g = this.panelgame.CreateGraphics();
            game.Draw(g);
            game.isclean(g);
           game.Down(this.panelgame.CreateGraphics());

        }

        private void panelgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panelgame.CreateGraphics();
            g.DrawImage(Properties.Resources.bg, 0, 0,this.panelgame.Width,this.panelgame.Height);
        }
      

        private void panelgame_MouseDown(object sender, MouseEventArgs e)
        {

            game.Mouse(e.X, e.Y, this.panelgame.CreateGraphics());
        }

        private void NameforGame_Click(object sender, EventArgs e)
        {

        }
    }
}
