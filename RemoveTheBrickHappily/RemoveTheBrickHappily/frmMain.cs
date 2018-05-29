using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveTheBrickHappily
{
    public partial class frmMain : Form
    {
        private Game game;
        SoundPlayer sp = new SoundPlayer(Properties.Resources.GameSceneBGM_01);

        private int n = 1;
        public frmMain()
        {
            InitializeComponent();
            //循环播放        
            Bgm.settings.setMode("loop", true);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(this.panelgame.Width, this.panelgame.Height);
            game.gameover += Game_gameover;
            game.win += Game_win;
            //背景音乐
            Bgm.URL = Application.StartupPath +@"\GameSceneBGM.mp3";
            Bgm.Ctlcontrols.play();
         

        }
        /// <summary>
        /// 闯关成功
        /// </summary>
        private void Game_win()
        {
            this.labelscore.Text = game.score.ToString();
            this.stepNumber.Text = game.step.ToString();
            if (MessageBox.Show("恭喜闯关成功，还想继续挑战自己吗?再来一关？", "闯关成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

             
                this.labelscore.Text = game.score.ToString();
                this.stepNumber.Text = game.step.ToString();
                this.btnStart.Text = "重新开始";
                this.buttonStop.Text = "暂停游戏";
                this.buttonStop.Image = Properties.Resources.redbtn;
                Graphics g = this.panelgame.CreateGraphics();

                game.Next(g);
                this.Text = "消消乐——第" + game.Number + "关";

                this.aim.Text = game.aimscore.ToString();

            }
        }
        /// <summary>
        /// 游戏结束
        /// </summary>
        private void Game_gameover()
        {
            this.labelscore.Text = game.score.ToString();
            this.stepNumber.Text = game.step.ToString();
            MessageBox.Show("Game over!");
        }

        /// <summary>
        /// 游戏开始 重新开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {

       
            Graphics g = this.panelgame.CreateGraphics();
            game.RePlay(g);
            this.labelscore.Text = game.score.ToString();
            this.stepNumber.Text = game.step.ToString();
            this.aim.Text = game.aimscore.ToString();
            this.Text = "消消乐——第" + game.Number + "关";

            this.btnStart.Text = "重新开始";
            this.buttonStop.Text = "暂停游戏";
            this.buttonStop.Image = Properties.Resources.redbtn;

        }

        private void panelgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panelgame.CreateGraphics();
            g.DrawImage(Properties.Resources.bg, 0, 0,this.panelgame.Width,this.panelgame.Height);
        }
      
        /// <summary>
        /// 点击鼠标刷新分数 步数 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelgame_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.buttonStop.Text == "暂停游戏")
            {
                game.Mouse(e.X, e.Y, this.panelgame.CreateGraphics());
                this.stepNumber.Text = game.step.ToString();
                this.labelscore.Text = game.score.ToString();
              
            }
          
        }
        /// <summary>
        /// 暂停 继续
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.buttonStop.Text == "继续游戏")
            {
                this.buttonStop.Text = "暂停游戏";
                this.buttonStop.Image = Properties.Resources.redbtn;

                Bgm.URL = Application.StartupPath + @"\GameSceneBGM.mp3";
                Bgm.Ctlcontrols.play();
            }
            else
            {
                this.buttonStop.Text = "继续游戏";
                this.buttonStop.Image = Properties.Resources.greenbtn1;
              
                Bgm.Ctlcontrols.stop();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            game.skill();
        }
    }
}
