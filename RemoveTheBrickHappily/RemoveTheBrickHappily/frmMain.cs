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

            game.score = 0;
            this.btnStart.Text = "重新开始";
            this.buttonStop.Text = "暂停游戏";
            this.buttonStop.Image = Properties.Resources.redbtn;

        }

        private void panelgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panelgame.CreateGraphics();
            g.DrawImage(Properties.Resources.bg, 0, 0,this.panelgame.Width,this.panelgame.Height);
        }
      

        private void panelgame_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.buttonStop.Text == "暂停游戏")
            {
                game.Mouse(e.X, e.Y, this.panelgame.CreateGraphics());
                this.NameforGame.Text = game.step.ToString();
                this.labelscore.Text = game.score.ToString();
                if (this.NameforGame.Text == "0")
                {
                    MessageBox.Show("Game over!");
                }
                if (Convert.ToInt32(this.labelscore.Text )>= 2000)
                {
                    MessageBox.Show("闯关成功");
                }
            }
          
        }

        private void NameforGame_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.buttonStop.Text == "继续游戏")
            {
                this.buttonStop.Text = "暂停游戏";
                this.buttonStop.Image = Properties.Resources.redbtn;

            }
           else
            {
                this.buttonStop.Text = "继续游戏";
                this.buttonStop.Image = Properties.Resources.greenbtn1;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
